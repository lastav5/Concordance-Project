namespace Concordance
{
    partial class EditGroupPhrase
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
            this.groupPhraseGV = new System.Windows.Forms.DataGridView();
            this.groupPhraseBox = new System.Windows.Forms.GroupBox();
            this.phraseRB = new System.Windows.Forms.RadioButton();
            this.groupRB = new System.Windows.Forms.RadioButton();
            this.changeBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupPhraseGV)).BeginInit();
            this.groupPhraseBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPhraseGV
            // 
            this.groupPhraseGV.AllowUserToAddRows = false;
            this.groupPhraseGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPhraseGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.groupPhraseGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.groupPhraseGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.groupPhraseGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupPhraseGV.Location = new System.Drawing.Point(64, 85);
            this.groupPhraseGV.Name = "groupPhraseGV";
            this.groupPhraseGV.ReadOnly = true;
            this.groupPhraseGV.RowHeadersVisible = false;
            this.groupPhraseGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.groupPhraseGV.Size = new System.Drawing.Size(436, 287);
            this.groupPhraseGV.TabIndex = 0;
            // 
            // groupPhraseBox
            // 
            this.groupPhraseBox.Controls.Add(this.phraseRB);
            this.groupPhraseBox.Controls.Add(this.groupRB);
            this.groupPhraseBox.Location = new System.Drawing.Point(64, 28);
            this.groupPhraseBox.Name = "groupPhraseBox";
            this.groupPhraseBox.Size = new System.Drawing.Size(436, 51);
            this.groupPhraseBox.TabIndex = 1;
            this.groupPhraseBox.TabStop = false;
            // 
            // phraseRB
            // 
            this.phraseRB.AutoSize = true;
            this.phraseRB.Location = new System.Drawing.Point(293, 20);
            this.phraseRB.Name = "phraseRB";
            this.phraseRB.Size = new System.Drawing.Size(58, 17);
            this.phraseRB.TabIndex = 1;
            this.phraseRB.TabStop = true;
            this.phraseRB.Text = "Phrase";
            this.phraseRB.UseVisualStyleBackColor = true;
            this.phraseRB.CheckedChanged += new System.EventHandler(this.phraseRB_CheckedChanged);
            // 
            // groupRB
            // 
            this.groupRB.AutoSize = true;
            this.groupRB.Location = new System.Drawing.Point(71, 20);
            this.groupRB.Name = "groupRB";
            this.groupRB.Size = new System.Drawing.Size(54, 17);
            this.groupRB.TabIndex = 0;
            this.groupRB.TabStop = true;
            this.groupRB.Text = "Group";
            this.groupRB.UseVisualStyleBackColor = true;
            this.groupRB.CheckedChanged += new System.EventHandler(this.groupRB_CheckedChanged);
            // 
            // changeBTN
            // 
            this.changeBTN.Location = new System.Drawing.Point(222, 403);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(75, 23);
            this.changeBTN.TabIndex = 2;
            this.changeBTN.Text = "Change";
            this.changeBTN.UseVisualStyleBackColor = true;
            this.changeBTN.Click += new System.EventHandler(this.changeBTN_Click);
            // 
            // EditGroupPhrase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 466);
            this.Controls.Add(this.changeBTN);
            this.Controls.Add(this.groupPhraseBox);
            this.Controls.Add(this.groupPhraseGV);
            this.Name = "EditGroupPhrase";
            this.Text = "Edit Group or Phrase";
            ((System.ComponentModel.ISupportInitialize)(this.groupPhraseGV)).EndInit();
            this.groupPhraseBox.ResumeLayout(false);
            this.groupPhraseBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groupPhraseGV;
        private System.Windows.Forms.GroupBox groupPhraseBox;
        private System.Windows.Forms.RadioButton phraseRB;
        private System.Windows.Forms.RadioButton groupRB;
        private System.Windows.Forms.Button changeBTN;
    }
}