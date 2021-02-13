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
    public partial class SearchGroupPhrase : Form
    {
        Services service;
        Parser parser;
        DataTable gridViewItems;
        DataRow[] allWordIndexesToDisplay;
        int currentContext = 0;
        public SearchGroupPhrase()
        {
            InitializeComponent();
            service = new Services();
            parser = new Parser();
            gridViewItems = new DataTable();
            gridViewItems.Columns.Add("Id");
            gridViewItems.Columns.Add("name");
            groupPhraseGV.DataSource = gridViewItems;
            groupPhraseGV.Columns["Id"].Visible = false;
            groupPhraseGV.ColumnHeadersVisible = false;
            //phraseRB.Checked = true;
        }
        
        private void groupPhraseGV_SelectionChanged(object sender, EventArgs e)
        {
            //populate contexts and textbox
            if (groupPhraseGV.SelectedRows.Count != 0)
            {
                currentContext = 0;
                int id = Convert.ToInt32(groupPhraseGV.SelectedRows[0].Cells["Id"].Value);
                if (phraseRB.Checked)
                {
                    allWordIndexesToDisplay = service.getWordIndexesByPhraseId(id).Select();
                }
                else if (groupRB.Checked)
                {
                    allWordIndexesToDisplay = service.getWordIndexesByGroupId(id).Select();
                }
                populateContext(true);
            }
        }

        private void populateGV()
        {
            contextTB.Text = "";
            if (groupRB.Checked)
            {
                gridViewItems = service.getAllGroupNames();
            }
            else if (phraseRB.Checked)
            {
                gridViewItems = service.getAllPhraseNames();
            }
            groupPhraseGV.DataSource = gridViewItems;
        }

        private void populateContext(bool highlight)
        {
            if (currentContext < allWordIndexesToDisplay.Length && currentContext >= 0)
            {
                docNameLBL.Text = allWordIndexesToDisplay[currentContext]["name"].ToString();
                chapterLBL.Text = allWordIndexesToDisplay[currentContext]["chapter"].ToString();
                if (phraseRB.Checked)
                {
                    if (!highlight)
                    {
                        int firstline = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["firstWordLine"]);
                        int docId = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["docId"]);
                        DataTable linesWI = service.getContextLinesAroundLine(3, firstline, docId);
                        Dictionary<int, string> contextLines = parser.deparseWordIndexDT(linesWI);
                        contextTB.Lines = contextLines.Values.ToArray();
                    }
                    else
                    {
                        int firstline = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["firstWordLine"]);
                        int firstcolumn = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["firstWordColumn"]);
                        int lastline = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["lastWordLine"]);
                        int lastcolumn = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["lastWordColumn"]);
                        int wordLength = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["lastWordLength"]);
                        int docId = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["docId"]);
                        DataTable linesWI = service.getContextLinesAroundLine(3, firstline, docId);
                        Dictionary<int, string> contextLines = parser.deparseWordIndexDT(linesWI);
                        writeToTBandHighlight(contextLines, firstline, firstcolumn, lastline, lastcolumn, wordLength);
                    }
                }
                else if (groupRB.Checked)
                {
                    if (!highlight)
                    {
                        int line = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["line"]);
                        int docId = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["docId"]);
                        DataTable linesWI = service.getContextLinesAroundLine(3, line, docId);
                        Dictionary<int, string> contextLines = parser.deparseWordIndexDT(linesWI);
                        contextTB.Lines = contextLines.Values.ToArray();
                    }
                    else
                    {
                        int line = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["line"]);
                        int column = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["column"]);
                        int wordLength = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["length"]);
                        int docId = Convert.ToInt32(allWordIndexesToDisplay[currentContext]["docId"]);
                        DataTable linesWI = service.getContextLinesAroundLine(3, line, docId);
                        Dictionary<int, string> contextLines = parser.deparseWordIndexDT(linesWI);
                        writeToTBandHighlight(contextLines, line, column, line, column, wordLength);
                    }
                 }
            }
            enableDisableContextBtns();
        }

        private void writeToTBandHighlight(Dictionary<int, string> contextLines, int firstline, int firstcolumn, int lastline, int lastcolumn, int wordLength)
        {
            contextLines[firstline] = contextLines[firstline].Insert(firstcolumn, "<--");
            contextLines[lastline] = contextLines[lastline].Insert(lastcolumn + 3 + wordLength, "-->");
            contextTB.Lines = contextLines.Values.ToArray();
            int startIndex = contextTB.Find("<--");
            int endIndex = contextTB.Find("-->")-3;
            contextTB.Text = contextTB.Text.Replace("<--", "").Replace("-->", "");
            contextTB.Text = contextTB.Text.Replace("\\n", "  ");
            contextTB.SelectionStart = startIndex;
            contextTB.SelectionLength = endIndex - startIndex;
            contextTB.SelectionBackColor = Color.Yellow;
            
        }

        private void enableDisableContextBtns()
        {
            if (currentContext == 0)
            {
                prevBTN.Enabled = false;
            }
            else
            {
                prevBTN.Enabled = true;
            }
            if (currentContext == allWordIndexesToDisplay.Length - 1)
            {
                nextBTN.Enabled = false;
            }
            else
            {
                nextBTN.Enabled = true;
            }
        }

        private void phraseRB_CheckedChanged(object sender, EventArgs e)
        {
            if (phraseRB.Checked)
            {
                exportBtn.Visible = false;
                currentContext = 0;
                allWordIndexesToDisplay = (new DataTable()).Select();
                populateGV();
            }
        }

        private void groupRB_CheckedChanged(object sender, EventArgs e)
        {
            if (groupRB.Checked)
            {
                exportBtn.Visible = true;
                currentContext = 0;
                allWordIndexesToDisplay = (new DataTable()).Select();
                populateGV();
            }
        }

        private void openDoc_Click(object sender, EventArgs e)
        {
            string docId = allWordIndexesToDisplay[currentContext]["docId"].ToString();
            string fileLocation = LUAttributes.filesPathFromRoot + allWordIndexesToDisplay[currentContext]["fileName"].ToString();
            Process.Start(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"), fileLocation));
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            if (groupPhraseGV.SelectedRows.Count > 0) {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = groupPhraseGV.SelectedRows[0].Cells["name"].Value.ToString() + " index.txt";
                DialogResult result = saveDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    String fileName = saveDialog.FileName;
                    string wordindex = groupPhraseGV.SelectedRows[0].Cells["name"].Value.ToString()+Environment.NewLine+ Environment.NewLine;
                    List<DataTable> divided = divideDataTableByWordId(allWordIndexesToDisplay);
                    foreach (DataTable wordDT in divided)
                    {
                        wordindex += "'" + wordDT.Rows[0]["value"] + "' appears in:"+Environment.NewLine;
                        foreach (DataRow row in wordDT.Rows)
                        {
                            wordindex += row["name"] + " by " + row["author"] + " in: line " + row["line"] + ", column " + row["column"] + ", sentence " + row["sentence"] + ", word-number " + row["wordOrdinal"] +Environment.NewLine;
                        }
                        wordindex += Environment.NewLine;
                    }
                    File.WriteAllText(fileName, wordindex);
                    Process.Start(fileName);
                }
            }
        }
        private List<DataTable> divideDataTableByWordId(DataRow[] rows)
        {
            List<DataTable> result = rows.AsEnumerable()
                                        .GroupBy(row => new { Field1 = row.Field<int>("wordId") })
                                        .Select(g => g.CopyToDataTable())
                                        .ToList();
            return result;
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            currentContext++;
            populateContext(true);
        }

        private void prevBTN_Click(object sender, EventArgs e)
        {
            currentContext--;
            populateContext(true);
        }
    }
}
