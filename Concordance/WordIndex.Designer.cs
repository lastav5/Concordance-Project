namespace Concordance
{
    partial class WordIndex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.documentsGV = new System.Windows.Forms.DataGridView();
            this.wordsGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.selectedWordRB = new System.Windows.Forms.RadioButton();
            this.lineColRB = new System.Windows.Forms.RadioButton();
            this.sentWordRB = new System.Windows.Forms.RadioButton();
            this.searchByBox = new System.Windows.Forms.GroupBox();
            this.sentenceTB = new System.Windows.Forms.RichTextBox();
            this.wordTB = new System.Windows.Forms.RichTextBox();
            this.contextTB = new System.Windows.Forms.RichTextBox();
            this.prevContextBTN = new System.Windows.Forms.Button();
            this.nextContext = new System.Windows.Forms.Button();
            this.loadWordsBTN = new System.Windows.Forms.Button();
            this.wordExistsErrorLBL = new System.Windows.Forms.Label();
            this.columnTB = new System.Windows.Forms.TextBox();
            this.lineTB = new System.Windows.Forms.TextBox();
            this.docNameLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chapterLBL = new System.Windows.Forms.Label();
            this.openDoc = new System.Windows.Forms.Button();
            this.searchWordTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.documentsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsGV)).BeginInit();
            this.searchByBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // documentsGV
            // 
            this.documentsGV.AllowUserToAddRows = false;
            this.documentsGV.AllowUserToDeleteRows = false;
            this.documentsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.documentsGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.documentsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.documentsGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.documentsGV.Location = new System.Drawing.Point(137, 64);
            this.documentsGV.Name = "documentsGV";
            this.documentsGV.ReadOnly = true;
            this.documentsGV.RowHeadersVisible = false;
            this.documentsGV.RowTemplate.Height = 24;
            this.documentsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.documentsGV.Size = new System.Drawing.Size(335, 342);
            this.documentsGV.TabIndex = 0;
            this.documentsGV.SelectionChanged += new System.EventHandler(this.documentsGV_SelectionChanged);
            // 
            // wordsGV
            // 
            this.wordsGV.AllowUserToAddRows = false;
            this.wordsGV.AllowUserToDeleteRows = false;
            this.wordsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.wordsGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.wordsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.wordsGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.wordsGV.Location = new System.Drawing.Point(521, 90);
            this.wordsGV.Name = "wordsGV";
            this.wordsGV.ReadOnly = true;
            this.wordsGV.RowHeadersVisible = false;
            this.wordsGV.RowTemplate.Height = 24;
            this.wordsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wordsGV.Size = new System.Drawing.Size(178, 316);
            this.wordsGV.TabIndex = 1;
            this.wordsGV.SelectionChanged += new System.EventHandler(this.wordsGV_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Documents:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(518, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Words:";
            // 
            // selectedWordRB
            // 
            this.selectedWordRB.AutoSize = true;
            this.selectedWordRB.Location = new System.Drawing.Point(16, 53);
            this.selectedWordRB.Name = "selectedWordRB";
            this.selectedWordRB.Size = new System.Drawing.Size(145, 24);
            this.selectedWordRB.TabIndex = 4;
            this.selectedWordRB.TabStop = true;
            this.selectedWordRB.Text = "Selected Word";
            this.selectedWordRB.UseVisualStyleBackColor = true;
            this.selectedWordRB.CheckedChanged += new System.EventHandler(this.selectedWordRB_CheckedChanged);
            // 
            // lineColRB
            // 
            this.lineColRB.AutoSize = true;
            this.lineColRB.Location = new System.Drawing.Point(16, 141);
            this.lineColRB.Name = "lineColRB";
            this.lineColRB.Size = new System.Drawing.Size(131, 24);
            this.lineColRB.TabIndex = 5;
            this.lineColRB.TabStop = true;
            this.lineColRB.Text = "Line, Column";
            this.lineColRB.UseVisualStyleBackColor = true;
            this.lineColRB.CheckedChanged += new System.EventHandler(this.lineColRB_CheckedChanged);
            // 
            // sentWordRB
            // 
            this.sentWordRB.AutoSize = true;
            this.sentWordRB.Location = new System.Drawing.Point(16, 233);
            this.sentWordRB.Name = "sentWordRB";
            this.sentWordRB.Size = new System.Drawing.Size(156, 24);
            this.sentWordRB.TabIndex = 6;
            this.sentWordRB.TabStop = true;
            this.sentWordRB.Text = "Sentence, Word";
            this.sentWordRB.UseVisualStyleBackColor = true;
            this.sentWordRB.CheckedChanged += new System.EventHandler(this.sentWordRB_CheckedChanged);
            // 
            // searchByBox
            // 
            this.searchByBox.Controls.Add(this.selectedWordRB);
            this.searchByBox.Controls.Add(this.sentWordRB);
            this.searchByBox.Controls.Add(this.lineColRB);
            this.searchByBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchByBox.Location = new System.Drawing.Point(793, 102);
            this.searchByBox.Name = "searchByBox";
            this.searchByBox.Size = new System.Drawing.Size(189, 293);
            this.searchByBox.TabIndex = 7;
            this.searchByBox.TabStop = false;
            this.searchByBox.Text = "Search By";
            // 
            // sentenceTB
            // 
            this.sentenceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentenceTB.Location = new System.Drawing.Point(1001, 335);
            this.sentenceTB.Name = "sentenceTB";
            this.sentenceTB.Size = new System.Drawing.Size(63, 34);
            this.sentenceTB.TabIndex = 10;
            this.sentenceTB.Text = "";
            this.sentenceTB.TextChanged += new System.EventHandler(this.sentenceTB_TextChanged);
            // 
            // wordTB
            // 
            this.wordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordTB.Location = new System.Drawing.Point(1107, 335);
            this.wordTB.Name = "wordTB";
            this.wordTB.Size = new System.Drawing.Size(63, 34);
            this.wordTB.TabIndex = 11;
            this.wordTB.Text = "";
            this.wordTB.TextChanged += new System.EventHandler(this.wordTB_TextChanged);
            // 
            // contextTB
            // 
            this.contextTB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextTB.Location = new System.Drawing.Point(137, 470);
            this.contextTB.Name = "contextTB";
            this.contextTB.Size = new System.Drawing.Size(1051, 200);
            this.contextTB.TabIndex = 12;
            this.contextTB.Text = "";
            // 
            // prevContextBTN
            // 
            this.prevContextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevContextBTN.Location = new System.Drawing.Point(72, 548);
            this.prevContextBTN.Name = "prevContextBTN";
            this.prevContextBTN.Size = new System.Drawing.Size(59, 57);
            this.prevContextBTN.TabIndex = 13;
            this.prevContextBTN.Text = "<";
            this.prevContextBTN.UseVisualStyleBackColor = true;
            this.prevContextBTN.Click += new System.EventHandler(this.prevContextBTN_Click);
            // 
            // nextContext
            // 
            this.nextContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextContext.Location = new System.Drawing.Point(1194, 548);
            this.nextContext.Name = "nextContext";
            this.nextContext.Size = new System.Drawing.Size(59, 57);
            this.nextContext.TabIndex = 14;
            this.nextContext.Text = ">";
            this.nextContext.UseVisualStyleBackColor = true;
            this.nextContext.Click += new System.EventHandler(this.nextContext_Click);
            // 
            // loadWordsBTN
            // 
            this.loadWordsBTN.Location = new System.Drawing.Point(705, 369);
            this.loadWordsBTN.Name = "loadWordsBTN";
            this.loadWordsBTN.Size = new System.Drawing.Size(47, 37);
            this.loadWordsBTN.TabIndex = 15;
            this.loadWordsBTN.Text = "Load More";
            this.loadWordsBTN.UseVisualStyleBackColor = true;
            this.loadWordsBTN.Click += new System.EventHandler(this.loadWordsBTN_Click);
            // 
            // wordExistsErrorLBL
            // 
            this.wordExistsErrorLBL.AutoSize = true;
            this.wordExistsErrorLBL.ForeColor = System.Drawing.Color.Red;
            this.wordExistsErrorLBL.Location = new System.Drawing.Point(998, 299);
            this.wordExistsErrorLBL.Name = "wordExistsErrorLBL";
            this.wordExistsErrorLBL.Size = new System.Drawing.Size(0, 13);
            this.wordExistsErrorLBL.TabIndex = 16;
            // 
            // columnTB
            // 
            this.columnTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnTB.Location = new System.Drawing.Point(1107, 243);
            this.columnTB.Name = "columnTB";
            this.columnTB.Size = new System.Drawing.Size(63, 35);
            this.columnTB.TabIndex = 17;
            this.columnTB.TextChanged += new System.EventHandler(this.columnTB_TextChanged_1);
            // 
            // lineTB
            // 
            this.lineTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineTB.Location = new System.Drawing.Point(1001, 243);
            this.lineTB.Name = "lineTB";
            this.lineTB.Size = new System.Drawing.Size(63, 35);
            this.lineTB.TabIndex = 18;
            this.lineTB.TextChanged += new System.EventHandler(this.lineTB_TextChanged_1);
            // 
            // docNameLBL
            // 
            this.docNameLBL.AutoSize = true;
            this.docNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameLBL.Location = new System.Drawing.Point(601, 435);
            this.docNameLBL.Name = "docNameLBL";
            this.docNameLBL.Size = new System.Drawing.Size(102, 24);
            this.docNameLBL.TabIndex = 19;
            this.docNameLBL.Text = "DocName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Chapter:";
            // 
            // chapterLBL
            // 
            this.chapterLBL.AutoSize = true;
            this.chapterLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterLBL.Location = new System.Drawing.Point(207, 437);
            this.chapterLBL.Name = "chapterLBL";
            this.chapterLBL.Size = new System.Drawing.Size(21, 24);
            this.chapterLBL.TabIndex = 21;
            this.chapterLBL.Text = "0";
            // 
            // openDoc
            // 
            this.openDoc.Location = new System.Drawing.Point(1113, 438);
            this.openDoc.Name = "openDoc";
            this.openDoc.Size = new System.Drawing.Size(75, 23);
            this.openDoc.TabIndex = 22;
            this.openDoc.Text = "Open Doc...";
            this.openDoc.UseVisualStyleBackColor = true;
            this.openDoc.Click += new System.EventHandler(this.openDoc_Click);
            // 
            // searchWordTB
            // 
            this.searchWordTB.Location = new System.Drawing.Point(521, 64);
            this.searchWordTB.Name = "searchWordTB";
            this.searchWordTB.Size = new System.Drawing.Size(178, 20);
            this.searchWordTB.TabIndex = 23;
            this.searchWordTB.TextChanged += new System.EventHandler(this.searchWordTB_TextChanged);
            // 
            // WordIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 713);
            this.Controls.Add(this.searchWordTB);
            this.Controls.Add(this.openDoc);
            this.Controls.Add(this.chapterLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docNameLBL);
            this.Controls.Add(this.lineTB);
            this.Controls.Add(this.columnTB);
            this.Controls.Add(this.wordExistsErrorLBL);
            this.Controls.Add(this.loadWordsBTN);
            this.Controls.Add(this.nextContext);
            this.Controls.Add(this.prevContextBTN);
            this.Controls.Add(this.contextTB);
            this.Controls.Add(this.wordTB);
            this.Controls.Add(this.sentenceTB);
            this.Controls.Add(this.searchByBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordsGV);
            this.Controls.Add(this.documentsGV);
            this.Name = "WordIndex";
            this.Text = "WordIndex";
            ((System.ComponentModel.ISupportInitialize)(this.documentsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsGV)).EndInit();
            this.searchByBox.ResumeLayout(false);
            this.searchByBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView documentsGV;
        private System.Windows.Forms.DataGridView wordsGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton selectedWordRB;
        private System.Windows.Forms.RadioButton lineColRB;
        private System.Windows.Forms.RadioButton sentWordRB;
        private System.Windows.Forms.GroupBox searchByBox;
        private System.Windows.Forms.RichTextBox sentenceTB;
        private System.Windows.Forms.RichTextBox wordTB;
        private System.Windows.Forms.RichTextBox contextTB;
        private System.Windows.Forms.Button prevContextBTN;
        private System.Windows.Forms.Button nextContext;
        private System.Windows.Forms.Button loadWordsBTN;
        private System.Windows.Forms.Label wordExistsErrorLBL;
        private System.Windows.Forms.TextBox columnTB;
        private System.Windows.Forms.TextBox lineTB;
        private System.Windows.Forms.Label docNameLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label chapterLBL;
        private System.Windows.Forms.Button openDoc;
        private System.Windows.Forms.TextBox searchWordTB;
    }
}