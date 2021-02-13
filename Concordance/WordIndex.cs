using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concordance
{
    public partial class WordIndex : Form
    {
        DataTable topFreqWords;
        DataTable documents;
        DataTable words;
        Services service;
        Parser parser;
        DataTable wordsOfLine;           //all wordIndexes of current line
        DataTable wordsOfSentence;
        DataRow[] allWordIndexesToDisplay;        //all wordIndexes matching current search
        int currentContext;

        public WordIndex()
        {
            InitializeComponent();
            service = new Services();
            initializeTables();
            parser = new Parser();
            currentContext = 0;
            columnTB.ReadOnly = true;
            AutoCompleteStringCollection autoCollection = new AutoCompleteStringCollection();
            columnTB.AutoCompleteCustomSource = autoCollection;
            columnTB.AutoCompleteMode = AutoCompleteMode.Suggest;
            columnTB.AutoCompleteSource = AutoCompleteSource.CustomSource;
            selectedWordRB.Checked = true;
            docNameLBL.Text = "";
        }

        private void initializeTables()
        {
            documents = new DataTable();
            documents.Columns.Add("Id",typeof(int));
            documents.Columns.Add("name");
            documents.Columns.Add("author");
            DataRow newrow = documents.NewRow();
            newrow["Id"] = -1;
            newrow["name"] = "All";
            documents.Rows.Add(newrow);
            documents.Merge(service.getAllDocuments());
            documentsGV.DataSource = documents;
            documentsGV.Columns["Id"].Visible = false;
            documentsGV.Columns["fileName"].Visible = false;
            //documentsGV.ColumnHeadersVisible = false;
            documentsGV.Rows[0].Selected = true;// 'All' selected

            words = new DataTable();
            words.Columns.Add("Id");
            words.Columns.Add("value");
            topFreqWords = service.getTopFrequentWordsByDocId(0,100,-1);
            words = topFreqWords;
            wordsGV.DataSource = words;
            wordsGV.Columns["Id"].Visible = false;
            wordsGV.Columns["occurrences"].Visible = false;
            wordsGV.ColumnHeadersVisible = false;
            wordsGV.Rows[0].Selected = true;
        }

        private void loadWordsBTN_Click(object sender, EventArgs e)
        {
            int docId = Convert.ToInt32(documentsGV.SelectedRows[0].Cells["Id"].Value);
            words.Merge(service.getTopFrequentWordsByDocId(words.Rows.Count - 1, 100, docId));
            //wordsGV.DataSource = words;
        }

        private void documentsGV_SelectionChanged(object sender, EventArgs e)
        {
            if (documentsGV.SelectedRows.Count != 0)
            {
                //int docId = Convert.ToInt32(documentsGV.SelectedRows[0].Cells["Id"].Value);
                //words = service.getTopFrequentWordsByDocId(0, 100, docId);
                //wordsGV.DataSource = words;
                if (selectedWordRB.Checked)
                {
                    searchWordTB_TextChanged(null, null);
                    //wordsGV.Select();
                }
                if (lineColRB.Checked)
                {
                    lineTB_TextChanged_1(null, null);
                }
                if (sentWordRB.Checked)
                {
                    sentenceTB_TextChanged(null, null);
                }
            }
        }

        private void wordsGV_SelectionChanged(object sender, EventArgs e)
        {
            if (selectedWordRB.Checked && wordsGV.SelectedRows.Count!=0 && documentsGV.SelectedRows.Count!=0)
            {
                currentContext = 0;
                int docId = Convert.ToInt32(documentsGV.SelectedRows[0].Cells["Id"].Value);
                int wordId = Convert.ToInt32(wordsGV.SelectedRows[0].Cells["Id"].Value);
                DataTable wordIndexesbyWord = service.getWordIndexesByWordId(wordId, docId, 100);// docId can be -1
                allWordIndexesToDisplay = wordIndexesbyWord.Select();
                populateContext(true);
            }
        }

        private void selectedWordRB_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedWordRB.Checked)
            {
                currentContext = 0;
                lineTB.ReadOnly = true;
                columnTB.ReadOnly = true;
                sentenceTB.ReadOnly = true;
                wordTB.ReadOnly = true;

                wordsGV.Select();
            }
        }

        private void lineColRB_CheckedChanged(object sender, EventArgs e)
        {
            if (lineColRB.Checked)
            {
                currentContext = 0;
                lineTB.ReadOnly = false;
                columnTB.ReadOnly = true;
                sentenceTB.ReadOnly = true;
                wordTB.ReadOnly = true;
                lineTB_TextChanged_1(null, null);
            }
        }
        private void sentWordRB_CheckedChanged(object sender, EventArgs e)
        {
            if (sentWordRB.Checked)
            {
                currentContext = 0;
                lineTB.ReadOnly = true;
                columnTB.ReadOnly = true;
                sentenceTB.ReadOnly = false;
                wordTB.ReadOnly = true;
                sentenceTB_TextChanged(null, null);
            }
        }

        private void populateContext(bool highlight)
        {
            if (currentContext < allWordIndexesToDisplay.Length && currentContext >= 0)
            {
                int line = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["line"]);
                int column = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["column"]);
                int wordLength = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["length"]);
                int docId = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["docId"]);
                
                DataTable linesWI = service.getContextLinesAroundLine(3, line, docId);
                Dictionary<int, string> contextLines = parser.deparseWordIndexDT(linesWI);
                if (highlight)
                {
                    writeToTBandHighlight(contextLines, line, column, wordLength);
                }
                else
                {
                    contextTB.Lines = contextLines.Values.ToArray();
                    contextTB.Text = contextTB.Text.Replace("\\n", "  ");
                }

                //update document name and chapter
                docNameLBL.Text = documents.Select("Id=" + docId.ToString())[0]["name"].ToString();
                chapterLBL.Text = allWordIndexesToDisplay[currentContext]["chapter"].ToString();
                //update index textboxes
                if (selectedWordRB.Checked)
                {
                    //update line, col, sentence, wordOrdinal
                    lineTB.Text = allWordIndexesToDisplay[currentContext]["line"].ToString();
                    columnTB.Text = allWordIndexesToDisplay[currentContext]["column"].ToString();
                    sentenceTB.Text = allWordIndexesToDisplay[currentContext]["sentence"].ToString();
                    wordTB.Text = allWordIndexesToDisplay[currentContext]["wordOrdinal"].ToString();
                }
                else if (lineColRB.Checked)
                {
                    sentenceTB.Text = allWordIndexesToDisplay[currentContext]["sentence"].ToString();
                    wordTB.Text = allWordIndexesToDisplay[currentContext]["wordOrdinal"].ToString();
                }
                else if (sentWordRB.Checked)
                {
                    lineTB.Text = allWordIndexesToDisplay[currentContext]["line"].ToString();
                    columnTB.Text = allWordIndexesToDisplay[currentContext]["column"].ToString();
                }
            }
            enableDisableContextBtns();
        }

        private void writeToTBandHighlight(Dictionary<int,string> contextLines, int line, int column, int wordLength)
        {
            contextLines[line] = contextLines[line].Insert(column, "<--");
            contextLines[line] = contextLines[line].Insert(column + 3 + wordLength, "-->");
            contextTB.Lines = contextLines.Values.ToArray();
            int startIndex = contextTB.Find("<--");
            contextTB.Text = contextTB.Text.Replace("<--", "").Replace("-->", "");
            contextTB.Text = contextTB.Text.Replace("\\n", "  ");
            contextTB.SelectionStart = startIndex;
            contextTB.SelectionLength = wordLength;
            contextTB.SelectionBackColor = Color.Yellow;
        }

        private List<DataTable> divideDataTableByLineValue(DataTable dt)
        {
            List<DataTable> result = dt.AsEnumerable()
                                        .GroupBy(row => new { Field1 = row.Field<int>("line"), Field2 = row.Field<int>("docId") })
                                        .Select(g => g.CopyToDataTable())
                                        .ToList();
            return result;
        }
        
        private void columnTB_TextChanged_1(object sender, EventArgs e)
        {
            if (lineColRB.Checked)
            {
                if (columnTB.Text != "" && columnTB.Text.All(c => char.IsDigit(c)))
                {
                    currentContext = 0;
                    allWordIndexesToDisplay = wordsOfLine.Select("column=" + columnTB.Text);
                    if (allWordIndexesToDisplay.Length == 0)
                    {
                        wordExistsErrorLBL.Text = "No word starts at this column.";
                        contextTB.SelectedText = "";
                    }
                    else
                    {
                        wordExistsErrorLBL.Text = "";
                        populateContext(true);
                    }
                    
                }
                else if (columnTB.Text != "")
                {
                    columnTB.Text = "";
                }
            }
        }

        private void lineTB_TextChanged_1(object sender, EventArgs e)
        {
            if (lineColRB.Checked)
            {
                if (lineTB.Text != "" && lineTB.Text.All(c => char.IsDigit(c)))
                {
                    currentContext = 0;
                    allWordIndexesToDisplay = new DataRow[0];
                    contextTB.Text = "";
                    columnTB.Text = "";
                    
                    int line = Convert.ToInt32(lineTB.Text);
                    int docId = Convert.ToInt32(documentsGV.SelectedRows[0].Cells["Id"].Value);
                    wordsOfLine = service.getWordIndexOfLineByDocId(line, docId);//docId can be -1

                    if (wordsOfLine.Rows.Count == 0)
                    {
                        wordExistsErrorLBL.Text = "No such line or line is empty.";
                        columnTB.ReadOnly = true;
                    }
                    else
                    {
                        wordExistsErrorLBL.Text = "";
                        allWordIndexesToDisplay = wordsOfLine.Select();
                        populateContext(false);
                        columnTB.ReadOnly = false;
                        //make autocomplete for column textbox
                        AutoCompleteStringCollection autoCollection = new AutoCompleteStringCollection();
                        autoCollection.AddRange(getColumnDataCollection(wordsOfLine, "column"));
                        columnTB.AutoCompleteCustomSource = autoCollection;
                    }
                }
                else if (lineTB.Text != "")
                {
                    lineTB.Text = "";
                }
            }
        }

        private void sentenceTB_TextChanged(object sender, EventArgs e)
        {
            if (sentWordRB.Checked)
            {
                if (sentenceTB.Text != "" && sentenceTB.Text.All(c => char.IsDigit(c)))
                {
                    currentContext = 0;
                    allWordIndexesToDisplay = new DataRow[0];
                    contextTB.Text = "";
                    wordTB.Text = "";
                    
                    int sentence = Convert.ToInt32(sentenceTB.Text);
                    int docId = Convert.ToInt32(documentsGV.SelectedRows[0].Cells["Id"].Value);
                    wordsOfSentence = service.getWordIndexOfSentenceByDocId(sentence, docId);//docId can be -1
                    if (wordsOfSentence.Rows.Count == 0)
                    {
                        wordExistsErrorLBL.Text = "No Such Sentence.";
                        wordTB.ReadOnly = true;
                    }
                    else
                    {
                        wordExistsErrorLBL.Text = "";
                        allWordIndexesToDisplay = wordsOfSentence.Select();
                        populateContext(false);
                        wordTB.ReadOnly = false;
                    }
                }
                else if (sentenceTB.Text != "")
                {
                    sentenceTB.Text = "";
                }
            }
        }

        private void wordTB_TextChanged(object sender, EventArgs e)
        {
            if (sentWordRB.Checked)
            {
                if (wordTB.Text != "" && wordTB.Text.All(c => char.IsDigit(c)))
                {
                    currentContext = 0;
                    allWordIndexesToDisplay = wordsOfSentence.Select("sentence = " + sentenceTB.Text + " and wordOrdinal=" + wordTB.Text);
                    if (allWordIndexesToDisplay.Length == 0)
                    {
                        wordExistsErrorLBL.Text = "No word exists at this ordinal.";
                    }
                    else
                    {
                        wordExistsErrorLBL.Text = "";
                        populateContext(true);
                    }
                    currentContext = 0;
                }
                else if (wordTB.Text != "")
                {
                    wordTB.Text = "";
                }
            }
        }

        private string[] getColumnDataCollection(DataTable dt, string columnName)
        {
            string[] cols = new string[dt.Rows.Count];
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                cols[i] = row[columnName].ToString();
                i++;
            }
            return cols;
        }

        private void nextContext_Click(object sender, EventArgs e)
        {
            currentContext++;
            populateContext(true);
        }

        private void prevContextBTN_Click(object sender, EventArgs e)
        {
            currentContext--;
            populateContext(true);
        }

        private void enableDisableContextBtns()
        {
            if (lineColRB.Checked || sentWordRB.Checked)
            {
                nextContext.Enabled = false;
                prevContextBTN.Enabled = false;
            }
            else
            {
                if (currentContext == 0)
                {
                    prevContextBTN.Enabled = false;
                }
                else
                {
                    prevContextBTN.Enabled = true;
                }
                if (currentContext == allWordIndexesToDisplay.Length - 1)
                {
                    nextContext.Enabled = false;
                }
                else
                {
                    nextContext.Enabled = true;
                }
            }
        }

        private void openDoc_Click(object sender, EventArgs e)
        {
            string docId = allWordIndexesToDisplay[currentContext]["docId"].ToString();
            string fileLocation = LUAttributes.filesPathFromRoot+ documents.Select("Id="+docId)[0]["fileName"];
            Process.Start(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"), fileLocation));
        }

        private void searchWordTB_TextChanged(object sender, EventArgs e)
        {
            string text = searchWordTB.Text;
            if (text.Length != 0 && documentsGV.SelectedRows.Count>0)
            {
                int docId = Convert.ToInt32(documentsGV.SelectedRows[0].Cells["Id"].Value);
                words = service.getAutoCompleteWords(text, 30, docId);
                wordsGV.DataSource = words;
            }
            else
            {
                words = topFreqWords;
                wordsGV.DataSource = words;
            }
        }
    }
}
