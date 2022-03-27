using MyHobbyListProject.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHobbyListProject.Forms.MyAnimeList
{
    public partial class FrmAddNewAnime : Form
    {
        public FrmAddNewAnime()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            cmbScore.Items.AddRange(Enum.GetNames(typeof(EnumScore)));
            cmbClassification.Items.AddRange(Enum.GetNames(typeof(EnumClassificationAnimes)));
            cmbStatus.Items.AddRange(Enum.GetNames(typeof(EnumStatus)));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string animeName = txtAnimeName.Text;         
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMyAnimeList frmMyAnimeList = new FrmMyAnimeList();
            frmMyAnimeList.Show();
            Close();
        }
    }
}
