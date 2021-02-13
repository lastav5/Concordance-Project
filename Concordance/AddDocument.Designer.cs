namespace Concordance
{
    partial class AddDocument
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileCTRL = new System.Windows.Forms.OpenFileDialog();
            this.filepathTB = new System.Windows.Forms.TextBox();
            this.browseBTN = new System.Windows.Forms.Button();
            this.addBTN = new System.Windows.Forms.Button();
            this.fileTextTB = new System.Windows.Forms.TextBox();
            this.successLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileCTRL
            // 
            this.openFileCTRL.Filter = "Text files (*.txt)|*.txt";
            // 
            // filepathTB
            // 
            this.filepathTB.Location = new System.Drawing.Point(32, 101);
            this.filepathTB.Name = "filepathTB";
            this.filepathTB.Size = new System.Drawing.Size(188, 20);
            this.filepathTB.TabIndex = 0;
            // 
            // browseBTN
            // 
            this.browseBTN.Location = new System.Drawing.Point(226, 99);
            this.browseBTN.Name = "browseBTN";
            this.browseBTN.Size = new System.Drawing.Size(75, 23);
            this.browseBTN.TabIndex = 1;
            this.browseBTN.Text = "browse";
            this.browseBTN.UseVisualStyleBackColor = true;
            this.browseBTN.Click += new System.EventHandler(this.browseBTN_Click);
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(106, 146);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(132, 23);
            this.addBTN.TabIndex = 2;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // fileTextTB
            // 
            this.fileTextTB.BackColor = System.Drawing.Color.White;
            this.fileTextTB.Location = new System.Drawing.Point(383, 38);
            this.fileTextTB.Multiline = true;
            this.fileTextTB.Name = "fileTextTB";
            this.fileTextTB.ReadOnly = true;
            this.fileTextTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.fileTextTB.Size = new System.Drawing.Size(524, 314);
            this.fileTextTB.TabIndex = 3;
            // 
            // successLBL
            // 
            this.successLBL.AutoSize = true;
            this.successLBL.Location = new System.Drawing.Point(75, 214);
            this.successLBL.Name = "successLBL";
            this.successLBL.Size = new System.Drawing.Size(0, 13);
            this.successLBL.TabIndex = 4;
            // 
            // AddDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 395);
            this.Controls.Add(this.successLBL);
            this.Controls.Add(this.fileTextTB);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.browseBTN);
            this.Controls.Add(this.filepathTB);
            this.Name = "AddDocument";
            this.Text = "Add Document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileCTRL;
        private System.Windows.Forms.TextBox filepathTB;
        private System.Windows.Forms.Button browseBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox fileTextTB;
        private System.Windows.Forms.Label successLBL;
    }
}