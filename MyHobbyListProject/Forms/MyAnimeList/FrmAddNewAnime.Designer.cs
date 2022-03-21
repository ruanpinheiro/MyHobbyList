namespace MyHobbyListProject.Forms.MyAnimeList
{
    partial class FrmAddNewAnime
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
            this.maskedEpisodes = new System.Windows.Forms.MaskedTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAnimeName = new System.Windows.Forms.Label();
            this.txtAnimeName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblEpisodes = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.lblResume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedEpisodes
            // 
            this.maskedEpisodes.Location = new System.Drawing.Point(16, 275);
            this.maskedEpisodes.Name = "maskedEpisodes";
            this.maskedEpisodes.Size = new System.Drawing.Size(99, 20);
            this.maskedEpisodes.TabIndex = 49;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 347);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(439, 174);
            this.richTextBox1.TabIndex = 48;
            this.richTextBox1.Text = "";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(285, 258);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 47;
            this.lblGenre.Text = "Genre";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(118, 259);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 46;
            this.lblStatus.Text = "Status";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(211, 164);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 45;
            this.lblScore.Text = "Score";
            // 
            // lblAnimeName
            // 
            this.lblAnimeName.AutoSize = true;
            this.lblAnimeName.Location = new System.Drawing.Point(13, 106);
            this.lblAnimeName.Name = "lblAnimeName";
            this.lblAnimeName.Size = new System.Drawing.Size(65, 13);
            this.lblAnimeName.TabIndex = 44;
            this.lblAnimeName.Text = "Anime name";
            // 
            // txtAnimeName
            // 
            this.txtAnimeName.Location = new System.Drawing.Point(16, 122);
            this.txtAnimeName.Name = "txtAnimeName";
            this.txtAnimeName.Size = new System.Drawing.Size(436, 20);
            this.txtAnimeName.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 63);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(236, 527);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(105, 32);
            this.btnExit.TabIndex = 41;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 32);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Location = new System.Drawing.Point(13, 259);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(50, 13);
            this.lblEpisodes.TabIndex = 52;
            this.lblEpisodes.Text = "Episodes";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(121, 275);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(161, 21);
            this.cmbStatus.TabIndex = 54;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Location = new System.Drawing.Point(288, 275);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(161, 21);
            this.cmbGenre.TabIndex = 55;
            // 
            // lblResume
            // 
            this.lblResume.AutoSize = true;
            this.lblResume.Location = new System.Drawing.Point(13, 331);
            this.lblResume.Name = "lblResume";
            this.lblResume.Size = new System.Drawing.Size(46, 13);
            this.lblResume.TabIndex = 56;
            this.lblResume.Text = "Resume";
            // 
            // FrmAddNewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 569);
            this.Controls.Add(this.lblResume);
            this.Controls.Add(this.cmbGenre);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.maskedEpisodes);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblAnimeName);
            this.Controls.Add(this.txtAnimeName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Name = "FrmAddNewAnime";
            this.Text = "FrmAddNewAnime";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedEpisodes;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAnimeName;
        private System.Windows.Forms.TextBox txtAnimeName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblEpisodes;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.Label lblResume;
    }
}