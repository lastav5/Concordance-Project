namespace Concordance
{
    partial class SearchGroupPhrase
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
            this.groupPhraseGV = new System.Windows.Forms.DataGridView();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.groupRB = new System.Windows.Forms.RadioButton();
            this.phraseRB = new System.Windows.Forms.RadioButton();
            this.contextTB = new System.Windows.Forms.RichTextBox();
            this.prevBTN = new System.Windows.Forms.Button();
            this.nextBTN = new System.Windows.Forms.Button();
            this.docNameLBL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chapterLBL = new System.Windows.Forms.Label();
            this.openDoc = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupPhraseGV)).BeginInit();
            this.searchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPhraseGV
            // 
            this.groupPhraseGV.AllowUserToAddRows = false;
            this.groupPhraseGV.AllowUserToDeleteRows = false;
            this.groupPhraseGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupPhraseGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.groupPhraseGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupPhraseGV.Location = new System.Drawing.Point(424, 84);
            this.groupPhraseGV.Name = "groupPhraseGV";
            this.groupPhraseGV.ReadOnly = true;
            this.groupPhraseGV.RowHeadersVisible = false;
            this.groupPhraseGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupPhraseGV.Size = new System.Drawing.Size(258, 283);
            this.groupPhraseGV.TabIndex = 0;
            this.groupPhraseGV.SelectionChanged += new System.EventHandler(this.groupPhraseGV_SelectionChanged);
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.groupRB);
            this.searchBox.Controls.Add(this.phraseRB);
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(424, 12);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(258, 66);
            this.searchBox.TabIndex = 1;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "search";
            // 
            // groupRB
            // 
            this.groupRB.AutoSize = true;
            this.groupRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupRB.Location = new System.Drawing.Point(147, 31);
            this.groupRB.Name = "groupRB";
            this.groupRB.Size = new System.Drawing.Size(77, 24);
            this.groupRB.TabIndex = 1;
            this.groupRB.TabStop = true;
            this.groupRB.Text = "Group";
            this.groupRB.UseVisualStyleBackColor = true;
            this.groupRB.CheckedChanged += new System.EventHandler(this.groupRB_CheckedChanged);
            // 
            // phraseRB
            // 
            this.phraseRB.AutoSize = true;
            this.phraseRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phraseRB.Location = new System.Drawing.Point(21, 31);
            this.phraseRB.Name = "phraseRB";
            this.phraseRB.Size = new System.Drawing.Size(83, 24);
            this.phraseRB.TabIndex = 0;
            this.phraseRB.TabStop = true;
            this.phraseRB.Text = "Phrase";
            this.phraseRB.UseVisualStyleBackColor = true;
            this.phraseRB.CheckedChanged += new System.EventHandler(this.phraseRB_CheckedChanged);
            // 
            // contextTB
            // 
            this.contextTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextTB.Location = new System.Drawing.Point(84, 435);
            this.contextTB.Name = "contextTB";
            this.contextTB.Size = new System.Drawing.Size(944, 189);
            this.contextTB.TabIndex = 2;
            this.contextTB.Text = "";
            // 
            // prevBTN
            // 
            this.prevBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevBTN.Location = new System.Drawing.Point(28, 505);
            this.prevBTN.Name = "prevBTN";
            this.prevBTN.Size = new System.Drawing.Size(50, 55);
            this.prevBTN.TabIndex = 3;
            this.prevBTN.Text = "<";
            this.prevBTN.UseVisualStyleBackColor = true;
            this.prevBTN.Click += new System.EventHandler(this.prevBTN_Click);
            // 
            // nextBTN
            // 
            this.nextBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBTN.Location = new System.Drawing.Point(1034, 505);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(50, 55);
            this.nextBTN.TabIndex = 4;
            this.nextBTN.Text = ">";
            this.nextBTN.UseVisualStyleBackColor = true;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            // 
            // docNameLBL
            // 
            this.docNameLBL.AutoSize = true;
            this.docNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.docNameLBL.Location = new System.Drawing.Point(500, 398);
            this.docNameLBL.Name = "docNameLBL";
            this.docNameLBL.Size = new System.Drawing.Size(102, 24);
            this.docNameLBL.TabIndex = 20;
            this.docNameLBL.Text = "DocName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(81, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Chapter:";
            // 
            // chapterLBL
            // 
            this.chapterLBL.AutoSize = true;
            this.chapterLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterLBL.Location = new System.Drawing.Point(151, 398);
            this.chapterLBL.Name = "chapterLBL";
            this.chapterLBL.Size = new System.Drawing.Size(21, 24);
            this.chapterLBL.TabIndex = 22;
            this.chapterLBL.Text = "0";
            // 
            // openDoc
            // 
            this.openDoc.Location = new System.Drawing.Point(953, 401);
            this.openDoc.Name = "openDoc";
            this.openDoc.Size = new System.Drawing.Size(75, 23);
            this.openDoc.TabIndex = 23;
            this.openDoc.Text = "Open Doc...";
            this.openDoc.UseVisualStyleBackColor = true;
            this.openDoc.Click += new System.EventHandler(this.openDoc_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(953, 363);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 24;
            this.exportBtn.Text = "Export to file";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Visible = false;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // SearchGroupPhrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 651);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.openDoc);
            this.Controls.Add(this.chapterLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.docNameLBL);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.prevBTN);
            this.Controls.Add(this.contextTB);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.groupPhraseGV);
            this.Name = "SearchGroupPhrase";
            this.Text = "Search Group or Phrase";
            ((System.ComponentModel.ISupportInitialize)(this.groupPhraseGV)).EndInit();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView groupPhraseGV;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.RadioButton groupRB;
        private System.Windows.Forms.RadioButton phraseRB;
        private System.Windows.Forms.RichTextBox contextTB;
        private System.Windows.Forms.Button prevBTN;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Label docNameLBL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label chapterLBL;
        private System.Windows.Forms.Button openDoc;
        private System.Windows.Forms.Button exportBtn;
    }
}