namespace Concordance
{
    partial class SearchDocuments
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
            this.listedWordsGV = new System.Windows.Forms.DataGridView();
            this.searchWordTB = new System.Windows.Forms.TextBox();
            this.selectedWordsGV = new System.Windows.Forms.DataGridView();
            this.searchAnyTB = new System.Windows.Forms.TextBox();
            this.searchAnyLBL = new System.Windows.Forms.Label();
            this.wordsContainLBL = new System.Windows.Forms.Label();
            this.documentsGV = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.openDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listedWordsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedWordsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // listedWordsGV
            // 
            this.listedWordsGV.AllowUserToAddRows = false;
            this.listedWordsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listedWordsGV.BackgroundColor = System.Drawing.Color.White;
            this.listedWordsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listedWordsGV.ColumnHeadersVisible = false;
            this.listedWordsGV.EnableHeadersVisualStyles = false;
            this.listedWordsGV.GridColor = System.Drawing.Color.DarkGray;
            this.listedWordsGV.Location = new System.Drawing.Point(292, 123);
            this.listedWordsGV.Name = "listedWordsGV";
            this.listedWordsGV.ReadOnly = true;
            this.listedWordsGV.RowHeadersVisible = false;
            this.listedWordsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listedWordsGV.Size = new System.Drawing.Size(186, 232);
            this.listedWordsGV.TabIndex = 4;
            this.listedWordsGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listedWordsGV_CellDoubleClick);
            // 
            // searchWordTB
            // 
            this.searchWordTB.Location = new System.Drawing.Point(292, 83);
            this.searchWordTB.Name = "searchWordTB";
            this.searchWordTB.Size = new System.Drawing.Size(185, 20);
            this.searchWordTB.TabIndex = 5;
            this.searchWordTB.TextChanged += new System.EventHandler(this.searchWordTB_TextChanged);
            // 
            // selectedWordsGV
            // 
            this.selectedWordsGV.AllowUserToAddRows = false;
            this.selectedWordsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedWordsGV.BackgroundColor = System.Drawing.Color.White;
            this.selectedWordsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedWordsGV.ColumnHeadersVisible = false;
            this.selectedWordsGV.Location = new System.Drawing.Point(527, 83);
            this.selectedWordsGV.Name = "selectedWordsGV";
            this.selectedWordsGV.ReadOnly = true;
            this.selectedWordsGV.RowHeadersVisible = false;
            this.selectedWordsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedWordsGV.Size = new System.Drawing.Size(181, 272);
            this.selectedWordsGV.TabIndex = 6;
            this.selectedWordsGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectedWordsGV_CellDoubleClick);
            // 
            // searchAnyTB
            // 
            this.searchAnyTB.Location = new System.Drawing.Point(48, 83);
            this.searchAnyTB.Name = "searchAnyTB";
            this.searchAnyTB.Size = new System.Drawing.Size(185, 20);
            this.searchAnyTB.TabIndex = 7;
            this.searchAnyTB.TextChanged += new System.EventHandler(this.searchAnyTB_TextChanged);
            // 
            // searchAnyLBL
            // 
            this.searchAnyLBL.AutoSize = true;
            this.searchAnyLBL.Location = new System.Drawing.Point(45, 50);
            this.searchAnyLBL.Name = "searchAnyLBL";
            this.searchAnyLBL.Size = new System.Drawing.Size(90, 13);
            this.searchAnyLBL.TabIndex = 8;
            this.searchAnyLBL.Text = "Search Any Field:";
            // 
            // wordsContainLBL
            // 
            this.wordsContainLBL.AutoSize = true;
            this.wordsContainLBL.Location = new System.Drawing.Point(289, 50);
            this.wordsContainLBL.Name = "wordsContainLBL";
            this.wordsContainLBL.Size = new System.Drawing.Size(102, 13);
            this.wordsContainLBL.TabIndex = 9;
            this.wordsContainLBL.Text = "Must contain words:";
            // 
            // documentsGV
            // 
            this.documentsGV.AllowUserToAddRows = false;
            this.documentsGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.documentsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.documentsGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.documentsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documentsGV.Location = new System.Drawing.Point(48, 420);
            this.documentsGV.Name = "documentsGV";
            this.documentsGV.ReadOnly = true;
            this.documentsGV.RowHeadersVisible = false;
            this.documentsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.documentsGV.Size = new System.Drawing.Size(660, 135);
            this.documentsGV.TabIndex = 10;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(48, 320);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(134, 35);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // openDoc
            // 
            this.openDoc.Location = new System.Drawing.Point(633, 561);
            this.openDoc.Name = "openDoc";
            this.openDoc.Size = new System.Drawing.Size(75, 23);
            this.openDoc.TabIndex = 23;
            this.openDoc.Text = "Open Doc...";
            this.openDoc.UseVisualStyleBackColor = true;
            this.openDoc.Click += new System.EventHandler(this.openDoc_Click);
            // 
            // SearchDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 608);
            this.Controls.Add(this.openDoc);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.documentsGV);
            this.Controls.Add(this.wordsContainLBL);
            this.Controls.Add(this.searchAnyLBL);
            this.Controls.Add(this.searchAnyTB);
            this.Controls.Add(this.selectedWordsGV);
            this.Controls.Add(this.searchWordTB);
            this.Controls.Add(this.listedWordsGV);
            this.Name = "SearchDocuments";
            this.Text = "SearchDocuments";
            ((System.ComponentModel.ISupportInitialize)(this.listedWordsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedWordsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listedWordsGV;
        private System.Windows.Forms.TextBox searchWordTB;
        private System.Windows.Forms.DataGridView selectedWordsGV;
        private System.Windows.Forms.TextBox searchAnyTB;
        private System.Windows.Forms.Label searchAnyLBL;
        private System.Windows.Forms.Label wordsContainLBL;
        private System.Windows.Forms.DataGridView documentsGV;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button openDoc;
    }
}