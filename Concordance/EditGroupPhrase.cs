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
    public partial class EditGroupPhrase : Form
    {
        Services service;
        public EditGroupPhrase()
        {
            InitializeComponent();
            service = new Services();
            groupRB.Checked = true;
        }

        private void populateTables()
        {
            if (groupRB.Checked)
            {
                groupPhraseGV.DataSource = service.getAllGroupNames();
                
            }
            else if (phraseRB.Checked)
            {
                groupPhraseGV.DataSource = service.getAllPhraseNames();
            }
            groupPhraseGV.Columns["Id"].Visible = false;
        }

        private void groupRB_CheckedChanged(object sender, EventArgs e)
        {
            if (groupRB.Checked)
            {
                populateTables();
            }
        }

        private void phraseRB_CheckedChanged(object sender, EventArgs e)
        {
            if (phraseRB.Checked)
            {
                populateTables();
            }
        }

        private void changeBTN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(groupPhraseGV.SelectedRows[0].Cells["Id"].Value);
            if (groupRB.Checked)
            {
                AddGroupPhrase agf = new AddGroupPhrase(id, LUAttributes.groupPhrase.Group);
                agf.Show();
                this.Close();
            }
            else if (phraseRB.Checked)
            {
                AddGroupPhrase agf = new AddGroupPhrase(id, LUAttributes.groupPhrase.Phrase);
                agf.Show();
                this.Close();
            }
            
        }
        
    }
}
