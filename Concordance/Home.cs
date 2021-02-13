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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addDocBTN_Click(object sender, EventArgs e)
        {
            AddDocument ad = new AddDocument();
            ad.Show();
        }

        private void wordIndexSearchBTN_Click(object sender, EventArgs e)
        {
            WordIndex wi = new WordIndex();
            wi.Show();
        }

        private void statisticsBTN_Click(object sender, EventArgs e)
        {
            Statistics s = new Statistics();
            s.Show();
        }

        private void addGroupPhraseBTN_Click(object sender, EventArgs e)
        {
            AddGroupPhrase agp = new AddGroupPhrase(-1, LUAttributes.groupPhrase.None);
            agp.Show();
        }

        private void editGroupPhrase_Click(object sender, EventArgs e)
        {
            EditGroupPhrase egp = new EditGroupPhrase();
            egp.Show();
        }

        private void searchGroupPhrase_Click(object sender, EventArgs e)
        {
            SearchGroupPhrase sgp = new SearchGroupPhrase();
            sgp.Show();
        }

        private void searchInflectionsBtn_Click(object sender, EventArgs e)
        {
            SearchByInflection sbi = new SearchByInflection();
            sbi.Show();
        }

        private void searchDocsBtn_Click(object sender, EventArgs e)
        {
            SearchDocuments sd = new SearchDocuments();
            sd.Show();
        }
    }
}
