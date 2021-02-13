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
    public partial class AddGroupPhrase : Form
    {
        DataTable listedWords;
        DataTable selectedWords;
        DataTable topFreqWords;
        Services service;
        LUAttributes.groupPhrase toEdit;
        int idToEdit = -1;
        public AddGroupPhrase(int id, LUAttributes.groupPhrase c)
        {
            InitializeComponent();
            service = new Services();

            topFreqWords = service.getTopFrequentWordsByDocId(0, 300,-1);
            listedWords = topFreqWords;
            listedWordsGV.DataSource = listedWords;
            listedWordsGV.Columns["Id"].Visible = false;
            listedWordsGV.Columns["occurrences"].Visible = false;
            listedWordsGV.ColumnHeadersVisible = false;
            phraseRB.Checked = true;

            if (c == LUAttributes.groupPhrase.None)
            {
                toEdit = LUAttributes.groupPhrase.None;
                selectedWords = new DataTable();
                selectedWords.Columns.Add("Id");
                selectedWords.Columns.Add("value");
                selectedWordsGV.DataSource = selectedWords;
                selectedWordsGV.Columns["Id"].Visible = false;
                selectedWordsGV.ColumnHeadersVisible = false;
            }
            else
            {
                toEdit = c;
                idToEdit = id;
                this.Text = "Edit " + toEdit.ToString();
                addBTN.Text = "Save";
                
                //populate selected words
                if (toEdit == LUAttributes.groupPhrase.Phrase)
                {
                    phraseRB.Checked = true;
                    phraseRB.Enabled = false;
                    selectedWords = service.getPhraseWordsById(idToEdit);
                }
                else if(toEdit == LUAttributes.groupPhrase.Group)
                {
                    groupRB.Checked = true;
                    groupRB.Enabled = false;
                    groupNameTB.Text = service.getGroupName(idToEdit);
                    selectedWords = service.getGroupWordsById(idToEdit);
                    groupNameTB.ReadOnly = true;
                }
                selectedWordsGV.DataSource = selectedWords;
                selectedWordsGV.Columns["Id"].Visible = false;
                selectedWordsGV.ColumnHeadersVisible = false;
                radioBox.Visible = false;
            }
        }

        private void AddGroupPhrase_Load(object sender, EventArgs e)
        {

        }
        
        private void searchWordTB_TextChanged(object sender, EventArgs e)
        {
            string text = searchWordTB.Text;
            if(text.Length != 0)
            {
                listedWords = service.getAutoCompleteWords(text, 30,-1);
                listedWordsGV.DataSource = listedWords;
            }
            else
            {
                listedWords = topFreqWords;
                listedWordsGV.DataSource = listedWords;
            }
        }
        
        private void listedWordsGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //add to selectedWords
            DataRow row = selectedWords.NewRow();
            row[0] = listedWordsGV.Rows[e.RowIndex].Cells["Id"].Value;
            row[1] = listedWordsGV.Rows[e.RowIndex].Cells["value"].Value;
            selectedWords.Rows.Add(row);
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

        private void phraseRB_CheckedChanged(object sender, EventArgs e)
        {
            if (phraseRB.Checked)
            {
                groupNameLBL.Visible = false;
                groupNameTB.Visible = false;
            }
        }

        private void groupRB_CheckedChanged(object sender, EventArgs e)
        {
            if(groupRB.Checked)
            {
                //group checked
                groupNameTB.Visible = true;
                groupNameLBL.Visible = true;
                if(toEdit == LUAttributes.groupPhrase.Group)
                {
                    groupNameTB.ReadOnly = true;
                }
            }
                
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (groupRB.Checked)
            {
                if (groupNameTB.Text != "" && char.IsLetter(groupNameTB.Text[0]))
                {
                    try
                    {
                        if (toEdit == LUAttributes.groupPhrase.Group)
                        {
                            service.updateGroup(idToEdit, groupNameTB.Text, convertToGroupDT(selectedWords));
                            msgLBL.Text = "Updated Successfully.";
                        }
                        else
                        {
                            service.InsertGroupToDB(groupNameTB.Text, convertToGroupDT(selectedWords));
                            msgLBL.Text = "Added Successfully.";
                        }
                        errorLBL.Text = "";
                    }
                    catch { errorLBL.Text = "Failed."; }
                }
                else
                {
                    errorLBL.Text = "*Group Name must begin with a letter.";
                }
            }
            else if (phraseRB.Checked)
            {
                try
                {
                    DataTable phraseDT = convertToPhraseDT(selectedWords);
                    if (toEdit == LUAttributes.groupPhrase.Phrase)
                    {
                        service.updatePhrase(idToEdit, concatPhrase(selectedWords), phraseDT);
                        msgLBL.Text = "Updated Successfully.";
                    }
                    else
                    {
                        service.InsertPhraseToDB(concatPhrase(selectedWords), phraseDT);
                        msgLBL.Text = "Added Successfully.";
                    }
                }
                catch(Exception ex) { errorLBL.Text = "Failed."; }
            }
        }

        private string concatPhrase(DataTable phraseWordsDT)
        {
            //DataRow[] rows = phraseWordsDT.AsEnumerable().OrderBy(x => x.Field<int>("wordOrdinal")).ToArray();
            string phrase = "";
            foreach(DataRow r in phraseWordsDT.Rows)
            {
                phrase += r["value"].ToString() + " ";
            }
            return phrase.Trim();
        }

        private static DataTable convertToPhraseDT(DataTable dt)
        {
            DataTable newDT = new DataTable();
            newDT.Columns.Add(new DataColumn("wordId", typeof(int)));
            newDT.Columns.Add(new DataColumn("wordOrdinal", typeof(int)));
            DataRow newRow;
            int ordinal = 0;
            foreach (DataRow row in dt.Rows)
            {
                newRow = newDT.NewRow();
                newRow["wordId"] = Convert.ToInt32(row["Id"]);
                newRow["wordOrdinal"] = ordinal;
                newDT.Rows.Add(newRow);
                ordinal++;
            }
            return newDT;
        }

        private static DataTable convertToGroupDT(DataTable dt)
        {
            DataTable newDT = new DataTable();
            newDT.Columns.Add(new DataColumn("wordId", typeof(int)));
            DataRow newRow;
            foreach (DataRow row in dt.Rows)
            {
                newRow = newDT.NewRow();
                newRow["wordId"] = Convert.ToInt32(row["Id"]);
                newDT.Rows.Add(newRow);
            }
            return newDT;
        }
    }

}
