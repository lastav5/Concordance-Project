namespace Concordance
{
    partial class SearchByInflection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.wordsGV = new System.Windows.Forms.DataGridView();
            this.searchWordTB = new System.Windows.Forms.TextBox();
            this.inflectionsGV = new System.Windows.Forms.DataGridView();
            this.contextTB = new System.Windows.Forms.RichTextBox();
            this.docNameLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chapterLBL = new System.Windows.Forms.Label();
            this.openDoc = new System.Windows.Forms.Button();
            this.prevContextBTN = new System.Windows.Forms.Button();
            this.nextContext = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wordsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inflectionsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // wordsGV
            // 
            this.wordsGV.AllowUserToAddRows = false;
            this.wordsGV.AllowUserToDeleteRows = false;
            this.wordsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.wordsGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.wordsGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.wordsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsGV.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.wordsGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.wordsGV.Location = new System.Drawing.Point(94, 75);
            this.wordsGV.Name = "wordsGV";
            this.wordsGV.ReadOnly = true;
            this.wordsGV.RowHeadersVisible = false;
            this.wordsGV.RowTemplate.Height = 24;
            this.wordsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.wordsGV.Size = new System.Drawing.Size(178, 316);
            this.wordsGV.TabIndex = 2;
            this.wordsGV.SelectionChanged += new System.EventHandler(this.wordsGV_SelectionChanged);
            // 
            // searchWordTB
            // 
            this.searchWordTB.Location = new System.Drawing.Point(94, 49);
            this.searchWordTB.Name = "searchWordTB";
            this.searchWordTB.Size = new System.Drawing.Size(178, 20);
            this.searchWordTB.TabIndex = 24;
            this.searchWordTB.TextChanged += new System.EventHandler(this.searchWordTB_TextChanged);
            // 
            // inflectionsGV
            // 
            this.inflectionsGV.AllowUserToAddRows = false;
            this.inflectionsGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.inflectionsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.inflectionsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.inflectionsGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.inflectionsGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.inflectionsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.inflectionsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inflectionsGV.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inflectionsGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.inflectionsGV.Location = new System.Drawing.Point(362, 75);
            this.inflectionsGV.Name = "inflectionsGV";
            this.inflectionsGV.ReadOnly = true;
            this.inflectionsGV.RowHeadersVisible = false;
            this.inflectionsGV.RowTemplate.Height = 24;
            this.inflectionsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inflectionsGV.Size = new System.Drawing.Size(178, 316);
            this.inflectionsGV.TabIndex = 25;
            this.inflectionsGV.SelectionChanged += new System.EventHandler(this.inflectionsGV_SelectionChanged);
            // 
            // contextTB
            // 
            this.contextTB.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextTB.Location = new System.Drawing.Point(94, 475);
            this.contextTB.Name = "contextTB";
            this.contextTB.Size = new System.Drawing.Size(1051, 200);
            this.contextTB.TabIndex = 26;
            this.contextTB.Text = "";
            // 
            // docNameLBL
            // 
            this.docNameLBL.AutoSize = true;
            this.docNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameLBL.Location = new System.Drawing.Point(553, 435);
            this.docNameLBL.Name = "docNameLBL";
            this.docNameLBL.Size = new System.Drawing.Size(102, 24);
            this.docNameLBL.TabIndex = 27;
            this.docNameLBL.Text = "DocName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Chapter:";
            // 
            // chapterLBL
            // 
            this.chapterLBL.AutoSize = true;
            this.chapterLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterLBL.Location = new System.Drawing.Point(170, 435);
            this.chapterLBL.Name = "chapterLBL";
            this.chapterLBL.Size = new System.Drawing.Size(21, 24);
            this.chapterLBL.TabIndex = 29;
            this.chapterLBL.Text = "0";
            // 
            // openDoc
            // 
            this.openDoc.Location = new System.Drawing.Point(1070, 439);
            this.openDoc.Name = "openDoc";
            this.openDoc.Size = new System.Drawing.Size(75, 23);
            this.openDoc.TabIndex = 30;
            this.openDoc.Text = "Open Doc...";
            this.openDoc.UseVisualStyleBackColor = true;
            this.openDoc.Click += new System.EventHandler(this.openDoc_Click);
            // 
            // prevContextBTN
            // 
            this.prevContextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevContextBTN.Location = new System.Drawing.Point(29, 542);
            this.prevContextBTN.Name = "prevContextBTN";
            this.prevContextBTN.Size = new System.Drawing.Size(59, 57);
            this.prevContextBTN.TabIndex = 31;
            this.prevContextBTN.Text = "<";
            this.prevContextBTN.UseVisualStyleBackColor = true;
            this.prevContextBTN.Click += new System.EventHandler(this.prevContextBTN_Click);
            // 
            // nextContext
            // 
            this.nextContext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextContext.Location = new System.Drawing.Point(1151, 542);
            this.nextContext.Name = "nextContext";
            this.nextContext.Size = new System.Drawing.Size(59, 57);
            this.nextContext.TabIndex = 32;
            this.nextContext.Text = ">";
            this.nextContext.UseVisualStyleBackColor = true;
            this.nextContext.Click += new System.EventHandler(this.nextContext_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(606, 359);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 32);
            this.searchBtn.TabIndex = 33;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // SearchByInflection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1235, 701);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.nextContext);
            this.Controls.Add(this.prevContextBTN);
            this.Controls.Add(this.openDoc);
            this.Controls.Add(this.chapterLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docNameLBL);
            this.Controls.Add(this.contextTB);
            this.Controls.Add(this.inflectionsGV);
            this.Controls.Add(this.searchWordTB);
            this.Controls.Add(this.wordsGV);
            this.Name = "SearchByInflection";
            this.Text = "Search By Inflection";
            ((System.ComponentModel.ISupportInitialize)(this.wordsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inflectionsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView wordsGV;
        private System.Windows.Forms.TextBox searchWordTB;
        private System.Windows.Forms.DataGridView inflectionsGV;
        private System.Windows.Forms.RichTextBox contextTB;
        private System.Windows.Forms.Label docNameLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label chapterLBL;
        private System.Windows.Forms.Button openDoc;
        private System.Windows.Forms.Button prevContextBTN;
        private System.Windows.Forms.Button nextContext;
        private System.Windows.Forms.Button searchBtn;
    }
}