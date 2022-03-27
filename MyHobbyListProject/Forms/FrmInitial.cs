using MyHobbyListProject.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyHobbyListProject.Forms.MenuList;
using MyHobbyListProject.Forms.ProfileUser;
using MyHobbyListProject.Forms.MyAnimeList;

namespace MyHobbyListProject
{
    public partial class FrmInitial : Form
    {


        public FrmInitial()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserContext context = new UserContext();

            foreach (var user in context.Users)
            {

                if (user.Email == txtEmail.Text && user.Password == txtPassword.Text)
                {
                    FrmMenuHobbysList frmMenuHobbysList = new FrmMenuHobbysList();
                    frmMenuHobbysList.Show();
                    Visible = false;
                    break;
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha inválidos!");
                    return;
                }

            }

            FrmMyAnimeList frmMyAnimeList = new FrmMyAnimeList(txtEmail.Text);         

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegisterUser frmRegisterUser = new FrmRegisterUser();
            frmRegisterUser.Show();
            Visible = false;        
        }
    }
    }
