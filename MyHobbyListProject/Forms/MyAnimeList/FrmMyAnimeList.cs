using MyHobbyListProject.Entities;
using MyHobbyListProject.Forms.MenuList;
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
    public partial class FrmMyAnimeList : Form
    {
        public FrmMyAnimeList()
        {
            InitializeComponent();
        }

        public FrmMyAnimeList(string email)
        {
            InitializeComponent();

            User user = new User();

            /*listViewAnimes = (ListView)user.GetAnimes(email);*/ // Não sei se vai funcionar, testar depois.

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMenuHobbysList frmMenuHobbysList = new FrmMenuHobbysList();
            frmMenuHobbysList.Show();
            Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddNewAnime frmAddNewAnime = new FrmAddNewAnime();
            frmAddNewAnime.Show();
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmEditOrRemoveAnime frmEditOrRemoveAnime = new FrmEditOrRemoveAnime();
            frmEditOrRemoveAnime.Show();
            Close();
        }

 
    }
}
