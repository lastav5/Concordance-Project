using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using java.util;
using edu.stanford.nlp.pipeline;
using edu.stanford.nlp.ling;
using edu.stanford.nlp.util;
using System.IO;
using System.Data;
using System.Windows.Forms;

namespace Concordance
{
    class Parser
    {
        public static System.Collections.ArrayList parse(string filename)
        {
            string fileLocation = LUAttributes.filesPathFromRoot + filename;

            //get metadata
            Document document = getMetadata(fileLocation);
            if (document == null) { return null; }

            // Path to the folder with models extracted from `stanford-corenlp-3.9.2-models.jar` 
            var jarRoot = Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"), @"Code\\stanford");

            var props = new java.util.Properties();
            props.setProperty("annotators", "tokenize, ssplit,pos, lemma");
            props.setProperty("ssplit.newlineIsSentenceBreak", "two");
            props.setProperty("tokenize.keepeol", "true");

            // We should change current directory, so StanfordCoreNLP could find all the model files automatically
            var curDir = Environment.CurrentDirectory;
            Directory.SetCurrentDirectory(jarRoot);
            var pipeline = new StanfordCoreNLP(props);
            Directory.SetCurrentDirectory(curDir);

            // assign lines and columns

            string[] lines = readAllLinesSkipMD(fileLocation);
            List<int> linenumbers = new List<int>();
            List<int> columnnumbers = new List<int>();

            List<CoreMap> blankSentencesList = new List<CoreMap>();
            java.util.ArrayList lineTokens;
            CoreLabel firstTokenInLine;
            int firstTokenInLinePos = 0;

            int columnInLine = 0;
            int lineNumber = 0;
            foreach (string line in lines)
            {

                Annotation annotation2 = new Annotation(line);
                pipeline.annotate(annotation2);
                lineTokens = (java.util.ArrayList)annotation2.get(typeof(CoreAnnotations.TokensAnnotation));

                if (line.Trim() != "")
                {
                    firstTokenInLine = (CoreLabel)lineTokens.get(0);
                    firstTokenInLinePos = firstTokenInLine.beginPosition();
                }
                else
                {
                    firstTokenInLinePos = 0;
                }
                foreach (CoreLabel token2 in lineTokens)
                {
                    columnInLine = token2.beginPosition() - firstTokenInLinePos;
                    token2.set(typeof(CoreAnnotations.LineNumberAnnotation), lineNumber);
                    blankSentencesList.Add(token2);
                    linenumbers.Add(lineNumber);
                    columnnumbers.Add(columnInLine);
                }
                lineNumber += 1;
            }


            // skip metadata
            string mdEnd = LUAttributes.metadataEnd;
            string txt = File.ReadAllText(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"), fileLocation));
            txt = txt.Substring(txt.IndexOf(mdEnd) + mdEnd.Length + 2);
            var annotation = new Annotation(txt);
            pipeline.annotate(annotation);

            //build datatable
            DataTable wordIndex = new DataTable("wordIndex");
            wordIndex.Columns.Add(new DataColumn("value", typeof(string)));
            wordIndex.Columns.Add(new DataColumn("length", typeof(int)));
            wordIndex.Columns.Add(new DataColumn("isSymbol", typeof(int)));
            wordIndex.Columns.Add(new DataColumn("lemma", typeof(string)));
            wordIndex.Columns.Add(new DataColumn("chapter", typeof(int)));
            wordIndex.Columns.Add(new DataColumn("line", typeof(int)));
            wordIndex.Columns.Add(new DataColumn("column", typeof(int)));
            wordIndex.Columns.Add(new DataColumn("sentence", typeof(int)));
            wordIndex.Columns.Add(new DataColumn("wordOrdinal", typeof(int)));
            wordIndex.Columns.Add(new DataColumn("tokenOrdinal", typeof(int)));
            
            //extract words into datatable
            var sentences = annotation.get(new CoreAnnotations.SentencesAnnotation().getClass()) as java.util.ArrayList;
            string word = "";
            int indexInSentence = 0, indexOfWordInSentence = 0, chapter = 1, isAposSkip = 0, lastTokenLine = -1;
            int sentenceCounter = 0;
            DataRow dr;
            CoreLabel token;
            int wordNumInText = 0;
            foreach (CoreMap sentence in sentences)
            {
                indexInSentence = 0;
                indexOfWordInSentence = 0;

                var tokens = sentence.get(new CoreAnnotations.TokensAnnotation().getClass()) as java.util.ArrayList;

                for (int i = 0; i < tokens.size(); i++)
                {

                    token = (CoreLabel)(tokens.get(i));
                    isAposSkip = 0;

                    //check if next token contains an apostrophe - also check if both current and next tokens are not symbols
                    if (i + 1 < tokens.size() && ((CoreLabel)tokens.get(i + 1)).word().IndexOf("'") >= 0 && !isSymbol(token.word()) && !isSymbol(((CoreLabel)tokens.get(i + 1)).word()))
                    {
                        //concat words
                        word = String.Concat(token.word(), ((CoreLabel)tokens.get(i + 1)).word());
                        //skip next word
                        i++;
                        wordNumInText++;
                        isAposSkip = 1;
                    }
                    else
                    {
                        word = token.word();
                    }
                    
                    //add newline rows
                    while (lastTokenLine + 1 < linenumbers[wordNumInText])
                    {
                        lastTokenLine++;
                        dr = wordIndex.NewRow();
                        dr["value"] = "\\n";
                        dr["length"] = 2;
                        dr["isSymbol"] = 1;
                        dr["lemma"] = "nolemma";
                        dr["chapter"] = chapter;
                        dr["line"] = lastTokenLine;
                        dr["column"] = 0;
                        dr["sentence"] = -1;
                        dr["wordOrdinal"] = -1;
                        dr["tokenOrdinal"] = 0;
                        wordIndex.Rows.Add(dr);
                    }

                    //check if new chapter
                    if (word == LUAttributes.chapterMark)
                    {
                        chapter++;
                        sentenceCounter = -1;
                        indexInSentence = -1;
                    }


                    dr = wordIndex.NewRow();
                    word = word.Replace("''", "\"").Replace("``", "\"").Replace("-LRB-","(").Replace("-RRB-",")");
                    dr["value"] = word;
                    dr["length"] = word.Length;
                    dr["isSymbol"] = isSymbol(word);
                    dr["chapter"] = chapter;
                    dr["line"] = linenumbers[wordNumInText];
                    dr["column"] = columnnumbers[wordNumInText - isAposSkip];
                    dr["sentence"] = sentenceCounter;
                    dr["tokenOrdinal"] = indexInSentence;
                    if (!isSymbol(word))
                    {
                        dr["wordOrdinal"] = indexOfWordInSentence;
                        dr["lemma"] = token.lemma().ToLower();
                    }
                    else
                    {
                        dr["wordOrdinal"] = -1;
                        dr["lemma"] = "nolemma";
                    }
                    wordIndex.Rows.Add(dr);
                    lastTokenLine = linenumbers[wordNumInText];
                    wordNumInText++;
                    indexInSentence++;
                    if (!isSymbol(word))
                    {
                        indexOfWordInSentence++;
                    }
                }

                sentenceCounter++;

            }
            
            System.Collections.ArrayList parsedDocList = new System.Collections.ArrayList();
            parsedDocList.Add(document);
            parsedDocList.Add(wordIndex);
            
            return parsedDocList;

        }

        public Dictionary<int, string> deparseWordIndexDT(DataTable wordIndex)
        {
            int spaces, prevEndCol = 0;
            string curWord, result = "";
            DataRow[] rows;
            int lastLine = Convert.ToInt32(wordIndex.Compute("max([line])", string.Empty));
            int firstLine = Convert.ToInt32(wordIndex.Compute("min([line])", string.Empty));
            Dictionary<int, string> lines = new Dictionary<int, string>();
            for (int k = firstLine; k <= lastLine; k++)
            {
                result = "";
                rows = wordIndex.Select("line=" + k);
                var orderedRows = rows.OrderBy(row => row["column"]);
                
                prevEndCol = 0;
                foreach (DataRow r in orderedRows)
                {
                    spaces = Convert.ToInt32(r["column"]) - prevEndCol;
                    prevEndCol = Convert.ToInt32(r["column"]) + Convert.ToInt32(r["length"]);
                    while (spaces > 0)
                    {
                        result += " ";
                        spaces--;
                    }
                    curWord = r["value"].ToString();
                    result += curWord;
                }
                //result += "\n";
                lines[k] = result;
            }
            return lines;
        }

        private static bool isSymbol(string token)
        {
            return (!token.Any(char.IsLetterOrDigit) || token == "\\n");
        }

        private static Document getMetadata(string fileLocation)
        {

            string[] metadata = (File.ReadLines(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"), fileLocation))
                                                        .SkipWhile(line => !line.Contains(LUAttributes.metadataBegin))
                                                        .Skip(1).SkipWhile(line => line.Trim() == "")
                                                        .TakeWhile(line => !line.Contains(LUAttributes.metadataEnd))).ToArray();

            if (metadata.Length < 5)
            {
                //msg
                return null;
            }
            //metadata[2].Insert(metadata[2].IndexOf(':'), ":");
            string[] nameMD = metadata[0].Split(':');
            string[] authorMD = metadata[1].Split(':');
            string[] linkMD = metadata[2].Split(new char[] {':'}, 2);
            string[] dateMD = metadata[3].Split(':');
            string[] chaptersMD = metadata[4].Split(':');
            if (nameMD[0].Trim() != "name" || authorMD[0].Trim() != "author" || linkMD[0].Trim() != "link" || dateMD[0].Trim() != "date" || chaptersMD[0].Trim() != "chapters")
            {
                //msg?
                return null;
            }

            Document document = new Document(nameMD[1].Trim(), authorMD[1].Trim(), Path.GetFileName(fileLocation), linkMD[1].Trim(), Convert.ToDateTime(dateMD[1].Trim()), Convert.ToInt32(chaptersMD[1].Trim()));
            
            return document;

        }

        private static string[] readAllLinesSkipMD(string fileLocation)
        {
            
            string[] lines = (File.ReadLines(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"), fileLocation))
                                                        .SkipWhile(line => !line.Contains(LUAttributes.metadataEnd))
                                                        .Skip(1)).ToArray();
            return lines;

        }
    }
}
