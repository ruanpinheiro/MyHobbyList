namespace MyHobbyListProject.Forms.MyAnimeList
{
    partial class FrmMyAnimeList
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
            this.btnExportList = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewAnimes = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPlanToWatch = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnDropped = new System.Windows.Forms.Button();
            this.btnCurrentlyWatching = new System.Windows.Forms.Button();
            this.btnOnHold = new System.Windows.Forms.Button();
            this.btnAllAnime = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExportList
            // 
            this.btnExportList.Location = new System.Drawing.Point(123, 525);
            this.btnExportList.Name = "btnExportList";
            this.btnExportList.Size = new System.Drawing.Size(105, 32);
            this.btnExportList.TabIndex = 16;
            this.btnExportList.Text = "Export List";
            this.btnExportList.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(234, 525);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 32);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(345, 525);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(105, 32);
            this.btnAddNew.TabIndex = 14;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 525);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(105, 32);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listViewAnimes
            // 
            this.listViewAnimes.HideSelection = false;
            this.listViewAnimes.Location = new System.Drawing.Point(12, 155);
            this.listViewAnimes.Name = "listViewAnimes";
            this.listViewAnimes.Size = new System.Drawing.Size(437, 364);
            this.listViewAnimes.TabIndex = 20;
            this.listViewAnimes.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 63);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPlanToWatch);
            this.groupBox1.Controls.Add(this.btnCompleted);
            this.groupBox1.Controls.Add(this.btnDropped);
            this.groupBox1.Controls.Add(this.btnCurrentlyWatching);
            this.groupBox1.Controls.Add(this.btnOnHold);
            this.groupBox1.Controls.Add(this.btnAllAnime);
            this.groupBox1.Location = new System.Drawing.Point(12, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 72);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnPlanToWatch
            // 
            this.btnPlanToWatch.Location = new System.Drawing.Point(294, 48);
            this.btnPlanToWatch.Name = "btnPlanToWatch";
            this.btnPlanToWatch.Size = new System.Drawing.Size(138, 23);
            this.btnPlanToWatch.TabIndex = 5;
            this.btnPlanToWatch.Text = "Plan To Watch";
            this.btnPlanToWatch.UseVisualStyleBackColor = true;
            // 
            // btnCompleted
            // 
            this.btnCompleted.Location = new System.Drawing.Point(294, 19);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(138, 23);
            this.btnCompleted.TabIndex = 4;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            // 
            // btnDropped
            // 
            this.btnDropped.Location = new System.Drawing.Point(150, 48);
            this.btnDropped.Name = "btnDropped";
            this.btnDropped.Size = new System.Drawing.Size(138, 23);
            this.btnDropped.TabIndex = 3;
            this.btnDropped.Text = "Dropped";
            this.btnDropped.UseVisualStyleBackColor = true;
            // 
            // btnCurrentlyWatching
            // 
            this.btnCurrentlyWatching.Location = new System.Drawing.Point(150, 19);
            this.btnCurrentlyWatching.Name = "btnCurrentlyWatching";
            this.btnCurrentlyWatching.Size = new System.Drawing.Size(138, 23);
            this.btnCurrentlyWatching.TabIndex = 2;
            this.btnCurrentlyWatching.Text = "Currently Watching";
            this.btnCurrentlyWatching.UseVisualStyleBackColor = true;
            // 
            // btnOnHold
            // 
            this.btnOnHold.Location = new System.Drawing.Point(6, 48);
            this.btnOnHold.Name = "btnOnHold";
            this.btnOnHold.Size = new System.Drawing.Size(138, 23);
            this.btnOnHold.TabIndex = 1;
            this.btnOnHold.Text = "On Hold";
            this.btnOnHold.UseVisualStyleBackColor = true;
            // 
            // btnAllAnime
            // 
            this.btnAllAnime.Location = new System.Drawing.Point(6, 19);
            this.btnAllAnime.Name = "btnAllAnime";
            this.btnAllAnime.Size = new System.Drawing.Size(138, 23);
            this.btnAllAnime.TabIndex = 0;
            this.btnAllAnime.Text = "All Anime";
            this.btnAllAnime.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(428, 155);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 364);
            this.vScrollBar1.TabIndex = 23;
            // 
            // FrmMyAnimeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 569);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewAnimes);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExportList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Name = "FrmMyAnimeList";
            this.Text = "FrmMyAnimeList";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExportList;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listViewAnimes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAllAnime;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button btnPlanToWatch;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnDropped;
        private System.Windows.Forms.Button btnCurrentlyWatching;
        private System.Windows.Forms.Button btnOnHold;
    }
}