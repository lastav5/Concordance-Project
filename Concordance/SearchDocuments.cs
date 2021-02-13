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
    public partial class SearchDocuments : Form
    {
        DataTable listedWords;
        DataTable selectedWords;
        DataTable Documents;
        Services service;
        public SearchDocuments()
        {
            InitializeComponent();
            service = new Services();

            Documents = new DataTable();
            Documents.Columns.Add("docId");
            documentsGV.DataSource = Documents;
            documentsGV.Columns["docId"].Visible = false;

            selectedWords = new DataTable();
            selectedWords.Columns.Add("Id", typeof(int));
            selectedWords.Columns.Add("wordValue", typeof(string));
            selectedWordsGV.DataSource = selectedWords;
            selectedWordsGV.Columns["Id"].Visible = false;

            listedWords = new DataTable();
            listedWords.Columns.Add("Id");
            listedWords.Columns.Add("value");
            listedWordsGV.DataSource = listedWords;
            listedWordsGV.Columns["Id"].Visible = false;
            
        }

        private void searchAnyTB_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void searchWordTB_TextChanged(object sender, EventArgs e)
        {
            string text = searchWordTB.Text;
            if (text.Length != 0)
            {
                listedWords = service.getAutoCompleteWords(text, 30, -1);
                listedWordsGV.DataSource = listedWords;
            }
            else
            {
                listedWordsGV.DataSource = null;
            }
        }

        private void listedWordsGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //add to selectedWords
            int id = Convert.ToInt32(listedWordsGV.Rows[e.RowIndex].Cells["Id"].Value);
            if (selectedWords.Select("Id=" + id.ToString()).Length == 0) {
                DataRow row = selectedWords.NewRow();
                row["Id"] = id;
                row["wordValue"] = listedWordsGV.Rows[e.RowIndex].Cells["value"].Value;
                selectedWords.Rows.Add(row);
            }
        }

        private void selectedWordsGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //remove from selectedWords
            DataRow dr;
            int id = Convert.ToInt32(selectedWordsGV.Rows[e.RowIndex].Cells["Id"].Value);
            for (int i = selectedWords.Rows.Count - 1; i >= 0; i--)
            {
                dr = selectedWords.Rows[i];
                if (Convert.ToInt32(dr["Id"]) == id)
                {
                    dr.Delete();
                    break;
                }
            }
            selectedWords.AcceptChanges();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            documentsGV.DataSource = service.getDocsByFieldAndWords(searchAnyTB.Text.Trim(),selectedWords);
        }

        private void openDoc_Click(object sender, EventArgs e)
        {
            if (documentsGV.SelectedRows.Count != 0)
            {
                string fileName = documentsGV.SelectedRows[0].Cells["fileName"].Value.ToString();
                Process.Start(Path.Combine(LUAttributes.pathToFilesFolder, fileName));
            }
        }
    }
}
