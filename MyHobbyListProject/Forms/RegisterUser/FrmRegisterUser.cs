using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MyHobbyListProject.Entities;

namespace MyHobbyListProject.Forms.ProfileUser
{
    public partial class FrmRegisterUser : Form
    {
        FrmInitial frmInitial = new FrmInitial();

        public FrmRegisterUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtFirstName.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
          
            
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = maskedConfirmEmail.Text;
            DateTime birthday = Convert.ToDateTime(maskedBirthday.Text);
            string password = txtConfirmPassword.Text;

            User user = new User();
            user.RegisterNewUser(firstName, lastName, birthday, email, password);

            MessageBox.Show("Cadastro realizado com sucesso!!!");

            frmInitial.Show();
            Visible = true;
            Close();
        }


        private void btnExit_Click(object sender, EventArgs e)
        {    
            frmInitial.Show();
            Visible = true;
            Close();
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        /* private void txtFirstName_Validating(object sender, CancelEventArgs e)
         {
             if (string.IsNullOrEmpty(txtFirstName.Text))
             {
                 e.Cancel = true;
                 txtFirstName.Focus();
                 errorFirstName.SetError(txtFirstName, "Please enter your fist name");
             }
             else
             {
                 e.Cancel = true;
                 errorFirstName.SetError(txtFirstName, null);
             }


         }

         private void txtLastName_Validating(object sender, CancelEventArgs e)
         {
             if (string.IsNullOrEmpty(txtLastName.Text))
             {
                 e.Cancel = true;
                 txtLastName.Focus();
                 errorLastName.SetError(txtLastName, "Please enter your last name");
             }
             else
             {
                 e.Cancel = true;
                 errorLastName.SetError(txtLastName, null);
             }

         }

         private void maskedBirthday_Validating(object sender, CancelEventArgs e)
         {
             if (string.IsNullOrEmpty(maskedBirthday.Text))
             {
                 e.Cancel = true;
                 maskedBirthday.Focus();
                 errorBirthday.SetError(maskedBirthday, "Please enter your birthday");
             }
             else
             {
                 e.Cancel = true;
                 errorBirthday.SetError(maskedBirthday, null);
             }

         }*/
    }
}
