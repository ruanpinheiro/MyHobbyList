namespace MyHobbyListProject.Forms.MenuList
{
    partial class FrmMenuHobbysList
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
            this.btnMyAnimeList = new System.Windows.Forms.Button();
            this.btnMyFilmList = new System.Windows.Forms.Button();
            this.btnMySerieList = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMyAnimeList
            // 
            this.btnMyAnimeList.Location = new System.Drawing.Point(63, 110);
            this.btnMyAnimeList.Name = "btnMyAnimeList";
            this.btnMyAnimeList.Size = new System.Drawing.Size(336, 114);
            this.btnMyAnimeList.TabIndex = 0;
            this.btnMyAnimeList.Text = "MyAnimeList";
            this.btnMyAnimeList.UseVisualStyleBackColor = true;
            this.btnMyAnimeList.Click += new System.EventHandler(this.btnMyAnimeList_Click);
            // 
            // btnMyFilmList
            // 
            this.btnMyFilmList.Location = new System.Drawing.Point(61, 245);
            this.btnMyFilmList.Name = "btnMyFilmList";
            this.btnMyFilmList.Size = new System.Drawing.Size(336, 114);
            this.btnMyFilmList.TabIndex = 1;
            this.btnMyFilmList.Text = "MyFilmList";
            this.btnMyFilmList.UseVisualStyleBackColor = true;
            this.btnMyFilmList.Click += new System.EventHandler(this.btnMyFilmList_Click);
            // 
            // btnMySerieList
            // 
            this.btnMySerieList.Location = new System.Drawing.Point(63, 382);
            this.btnMySerieList.Name = "btnMySerieList";
            this.btnMySerieList.Size = new System.Drawing.Size(336, 114);
            this.btnMySerieList.TabIndex = 2;
            this.btnMySerieList.Text = "MySerieList";
            this.btnMySerieList.UseVisualStyleBackColor = true;
            this.btnMySerieList.Click += new System.EventHandler(this.btnMySerieList_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(226, 525);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 32);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Back";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(337, 525);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(105, 32);
            this.btnProfile.TabIndex = 26;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(42, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 63);
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuHobbysList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnMySerieList);
            this.Controls.Add(this.btnMyFilmList);
            this.Controls.Add(this.btnMyAnimeList);
            this.Name = "FrmMenuHobbysList";
            this.Text = "FrmListHobbys";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMyAnimeList;
        private System.Windows.Forms.Button btnMyFilmList;
        private System.Windows.Forms.Button btnMySerieList;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}