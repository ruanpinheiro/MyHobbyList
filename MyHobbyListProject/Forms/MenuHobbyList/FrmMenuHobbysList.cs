using MyHobbyListProject.Forms.MyAnimeList;
using MyHobbyListProject.Forms.MyFilmList;
using MyHobbyListProject.Forms.MySerieList;
using MyHobbyListProject.Forms.ProfileUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyHobbyListProject.Forms.MenuList
{
    public partial class FrmMenuHobbysList : Form
    {
      

        public FrmMenuHobbysList()
        {
            InitializeComponent();
           
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmInitial frmInitial = new FrmInitial();
            frmInitial.Show();
            Visible = true;
            Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmProfileUser frmProfileUser = new FrmProfileUser();
            frmProfileUser.Show();         
            Close();

        }

        private void btnMyAnimeList_Click(object sender, EventArgs e)
        {
            FrmMyAnimeList frmMyAnimeList = new FrmMyAnimeList();
            frmMyAnimeList.Show();
            Close();

        }

        private void btnMyFilmList_Click(object sender, EventArgs e)
        {
            FrmMyFilmList frmMyFilmList = new FrmMyFilmList();
            frmMyFilmList.Show();
            Close();

        }

        private void btnMySerieList_Click(object sender, EventArgs e)
        {
            FrmMySerieList frmMySerieList = new FrmMySerieList();
            frmMySerieList.Show();
            Close();
        }
    }
}
