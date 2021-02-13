using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concordance
{
    public partial class Statistics : Form
    {
        Services service;
        DataTable occurrences;
        public Statistics()
        {
            InitializeComponent();
            service = new Services();
            DataTable stats = service.getStatistics();
            charsInWord.Text = stats.Rows[0]["charsInWordAVG"].ToString();
            charsInSentence.Text = stats.Rows[0]["charsInSentenceAVG"].ToString();
            charsInChapter.Text = stats.Rows[0]["charsInChapterAVG"].ToString();
            charsInDocument.Text = stats.Rows[0]["charsInDocAVG"].ToString();
            wordsInChapter.Text = stats.Rows[0]["wordsInChapterAVG"].ToString();
            wordsInSentence.Text = stats.Rows[0]["wordsInSentenceAVG"].ToString();
            wordInDocument.Text = stats.Rows[0]["wordsInDocAVG"].ToString();
            wordsTotal.Text = stats.Rows[0]["wordsTotal"].ToString();
            
            occurrences = service.getTopFrequentWordsByDocId(0, 70, -1);
            occurrencesGV.DataSource = occurrences;
            occurrencesGV.Columns["Id"].Visible = false;
        }

        private void occurrencesGV_SelectionChanged(object sender, EventArgs e)
        {
            occurrencesGV.ClearSelection();
        }
    }
}
