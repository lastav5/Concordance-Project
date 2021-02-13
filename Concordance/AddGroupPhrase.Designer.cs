namespace Concordance
{
    partial class AddGroupPhrase
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
            this.searchWordTB = new System.Windows.Forms.TextBox();
            this.listedWordsGV = new System.Windows.Forms.DataGridView();
            this.selectedWordsGV = new System.Windows.Forms.DataGridView();
            this.groupNameTB = new System.Windows.Forms.TextBox();
            this.groupRB = new System.Windows.Forms.RadioButton();
            this.phraseRB = new System.Windows.Forms.RadioButton();
            this.radioBox = new System.Windows.Forms.GroupBox();
            this.groupNameLBL = new System.Windows.Forms.Label();
            this.addBTN = new System.Windows.Forms.Button();
            this.errorLBL = new System.Windows.Forms.Label();
            this.msgLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listedWordsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedWordsGV)).BeginInit();
            this.radioBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchWordTB
            // 
            this.searchWordTB.Location = new System.Drawing.Point(83, 128);
            this.searchWordTB.Name = "searchWordTB";
            this.searchWordTB.Size = new System.Drawing.Size(185, 20);
            this.searchWordTB.TabIndex = 1;
            this.searchWordTB.TextChanged += new System.EventHandler(this.searchWordTB_TextChanged);
            // 
            // listedWordsGV
            // 
            this.listedWordsGV.AllowUserToAddRows = false;
            this.listedWordsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listedWordsGV.BackgroundColor = System.Drawing.Color.White;
            this.listedWordsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listedWordsGV.EnableHeadersVisualStyles = false;
            this.listedWordsGV.GridColor = System.Drawing.Color.DarkGray;
            this.listedWordsGV.Location = new System.Drawing.Point(83, 154);
            this.listedWordsGV.Name = "listedWordsGV";
            this.listedWordsGV.ReadOnly = true;
            this.listedWordsGV.RowHeadersVisible = false;
            this.listedWordsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listedWordsGV.Size = new System.Drawing.Size(186, 429);
            this.listedWordsGV.TabIndex = 3;
            this.listedWordsGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listedWordsGV_CellDoubleClick);
            // 
            // selectedWordsGV
            // 
            this.selectedWordsGV.AllowUserToAddRows = false;
            this.selectedWordsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedWordsGV.BackgroundColor = System.Drawing.Color.White;
            this.selectedWordsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedWordsGV.Location = new System.Drawing.Point(338, 180);
            this.selectedWordsGV.Name = "selectedWordsGV";
            this.selectedWordsGV.ReadOnly = true;
            this.selectedWordsGV.RowHeadersVisible = false;
            this.selectedWordsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedWordsGV.Size = new System.Drawing.Size(181, 260);
            this.selectedWordsGV.TabIndex = 4;
            this.selectedWordsGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedWordsGV_CellDoubleClick);
            // 
            // groupNameTB
            // 
            this.groupNameTB.Location = new System.Drawing.Point(338, 154);
            this.groupNameTB.Name = "groupNameTB";
            this.groupNameTB.Size = new System.Drawing.Size(181, 20);
            this.groupNameTB.TabIndex = 5;
            this.groupNameTB.Visible = false;
            // 
            // groupRB
            // 
            this.groupRB.AutoSize = true;
            this.groupRB.Location = new System.Drawing.Point(0, 71);
            this.groupRB.Name = "groupRB";
            this.groupRB.Size = new System.Drawing.Size(77, 24);
            this.groupRB.TabIndex = 6;
            this.groupRB.TabStop = true;
            this.groupRB.Text = "Group";
            this.groupRB.UseVisualStyleBackColor = true;
            this.groupRB.CheckedChanged += new System.EventHandler(this.groupRB_CheckedChanged);
            // 
            // phraseRB
            // 
            this.phraseRB.AutoSize = true;
            this.phraseRB.Location = new System.Drawing.Point(0, 41);
            this.phraseRB.Name = "phraseRB";
            this.phraseRB.Size = new System.Drawing.Size(83, 24);
            this.phraseRB.TabIndex = 7;
            this.phraseRB.TabStop = true;
            this.phraseRB.Text = "Phrase";
            this.phraseRB.UseVisualStyleBackColor = true;
            this.phraseRB.CheckedChanged += new System.EventHandler(this.phraseRB_CheckedChanged);
            // 
            // radioBox
            // 
            this.radioBox.Controls.Add(this.phraseRB);
            this.radioBox.Controls.Add(this.groupRB);
            this.radioBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBox.Location = new System.Drawing.Point(83, 12);
            this.radioBox.Name = "radioBox";
            this.radioBox.Size = new System.Drawing.Size(186, 110);
            this.radioBox.TabIndex = 8;
            this.radioBox.TabStop = false;
            this.radioBox.Text = "What to add?";
            // 
            // groupNameLBL
            // 
            this.groupNameLBL.AutoSize = true;
            this.groupNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNameLBL.Location = new System.Drawing.Point(335, 130);
            this.groupNameLBL.Name = "groupNameLBL";
            this.groupNameLBL.Size = new System.Drawing.Size(95, 18);
            this.groupNameLBL.TabIndex = 9;
            this.groupNameLBL.Text = "Group name:";
            // 
            // addBTN
            // 
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Location = new System.Drawing.Point(338, 489);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(181, 35);
            this.addBTN.TabIndex = 10;
            this.addBTN.Text = "Add";
            this.addBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // errorLBL
            // 
            this.errorLBL.AutoSize = true;
            this.errorLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLBL.ForeColor = System.Drawing.Color.Red;
            this.errorLBL.Location = new System.Drawing.Point(335, 83);
            this.errorLBL.Name = "errorLBL";
            this.errorLBL.Size = new System.Drawing.Size(0, 18);
            this.errorLBL.TabIndex = 11;
            // 
            // msgLBL
            // 
            this.msgLBL.AutoSize = true;
            this.msgLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLBL.Location = new System.Drawing.Point(338, 557);
            this.msgLBL.Name = "msgLBL";
            this.msgLBL.Size = new System.Drawing.Size(51, 20);
            this.msgLBL.TabIndex = 12;
            this.msgLBL.Text = "label1";
            // 
            // AddGroupPhrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 635);
            this.Controls.Add(this.msgLBL);
            this.Controls.Add(this.errorLBL);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.groupNameLBL);
            this.Controls.Add(this.radioBox);
            this.Controls.Add(this.groupNameTB);
            this.Controls.Add(this.selectedWordsGV);
            this.Controls.Add(this.listedWordsGV);
            this.Controls.Add(this.searchWordTB);
            this.Name = "AddGroupPhrase";
            this.Text = "Add Group or Phrase";
            this.Load += new System.EventHandler(this.AddGroupPhrase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listedWordsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedWordsGV)).EndInit();
            this.radioBox.ResumeLayout(false);
            this.radioBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox searchWordTB;
        private System.Windows.Forms.DataGridView listedWordsGV;
        private System.Windows.Forms.DataGridView selectedWordsGV;
        private System.Windows.Forms.TextBox groupNameTB;
        private System.Windows.Forms.RadioButton groupRB;
        private System.Windows.Forms.RadioButton phraseRB;
        private System.Windows.Forms.GroupBox radioBox;
        private System.Windows.Forms.Label groupNameLBL;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Label errorLBL;
        private System.Windows.Forms.Label msgLBL;
    }
}

