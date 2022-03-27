using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyHobbyListProject.Forms.MenuList;

namespace MyHobbyListProject.Forms.ProfileUser
{
    public partial class FrmProfileUser : Form
    {
        public FrmProfileUser()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMenuHobbysList frmMenuHobbysList = new FrmMenuHobbysList();
            frmMenuHobbysList.Show();
            Close();
        }
    }
}
