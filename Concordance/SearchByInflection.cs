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
    public partial class SearchByInflection : Form
    {
        Services service;
        Parser parser;
        DataTable words;
        DataTable inflections;
        DataRow[] allWordIndexesToDisplay;
        int currentContext = 0;
        public SearchByInflection()
        {
            InitializeComponent();
            service = new Services();
            parser = new Parser();
            words = new DataTable();
            words.Columns.Add("Id");
            words.Columns.Add("value");
            wordsGV.DataSource = words;
            wordsGV.Columns["Id"].Visible = false;

            inflections = new DataTable();
            inflections.Columns.Add("length");
            inflections.Columns.Add("value");
            inflections.Columns.Add("lemmaId");
            inflectionsGV.DataSource = inflections;
            inflectionsGV.Columns["lemmaId"].Visible = false;
            inflectionsGV.Columns["length"].Visible = false;
        }

        private void searchWordTB_TextChanged(object sender, EventArgs e)
        {
            string text = searchWordTB.Text;
            if (text.Length != 0 )
            {
                words = service.getAutoCompleteWords(text, 30, -1);
                wordsGV.DataSource = words;
            }
            else
            {
                words = null;
                wordsGV.DataSource = words;
                inflections = null;
                inflectionsGV.DataSource = null;
            }
        }

        private void wordsGV_SelectionChanged(object sender, EventArgs e)
        {
            if (wordsGV.SelectedRows.Count > 0)
            {
                int wordId = Convert.ToInt32(wordsGV.SelectedRows[0].Cells["Id"].Value);
                inflections = service.getInflectionsByWordId(wordId);
                inflectionsGV.DataSource = inflections;
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (inflections.Rows.Count > 0)
            {
                currentContext = 0;
                int wordId = Convert.ToInt32(wordsGV.SelectedRows[0].Cells["Id"].Value);
                allWordIndexesToDisplay = service.getInflectedWordIndexesBywordId(wordId).Select();
                populateContext(true);
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
                docNameLBL.Text = allWordIndexesToDisplay[currentContext]["name"].ToString();
                chapterLBL.Text = allWordIndexesToDisplay[currentContext]["chapter"].ToString();
            }
            enableDisableContextBtns();
        }

        private void writeToTBandHighlight(Dictionary<int, string> contextLines, int line, int column, int wordLength)
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
        private void enableDisableContextBtns()
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

        private void openDoc_Click(object sender, EventArgs e)
        {
            string docId = allWordIndexesToDisplay[currentContext]["docId"].ToString();
            string fileLocation = LUAttributes.filesPathFromRoot + allWordIndexesToDisplay[currentContext]["fileName"].ToString();
            Process.Start(Path.Combine(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\"), fileLocation));
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

        private void inflectionsGV_SelectionChanged(object sender, EventArgs e)
        {
            inflectionsGV.ClearSelection();
        }
    }
}
