using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Concordance
{
    public partial class AddDocument : Form
    {
        public AddDocument()
        {
            InitializeComponent();
            
        }

        private void browseBTN_Click(object sender, EventArgs e)
        {
            if (openFileCTRL.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileCTRL.FileName;
                filepathTB.Text = fileName;
                string text="";
                try
                {
                    text = File.ReadAllText(fileName);
                }
                catch
                {

                }
                fileTextTB.Text = text;
            }
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if (filepathTB.Text != "")
            {
                try
                {
                    //File.Copy(filepathTB.Text, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Data\\files\\"));
                    File.Copy(filepathTB.Text, "D: \\Uni\\DBworkshop\\concordance project\\Concordance\\Concordance\\Data\\files\\"+Path.GetFileName(filepathTB.Text), true);
                    ArrayList parsedDoc = Parser.parse(Path.GetFileName(filepathTB.Text));
                    Services ser = new Services();
                    ser.insertParsedDocToDB((Document)parsedDoc[0], (DataTable)parsedDoc[1]);
                    successLBL.Text = "Added Successfully";
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }
    }
}
