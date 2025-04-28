using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitedBook
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void NewUser_Load(object sender, EventArgs e)
        {
            cmbRole.DataSource = Form1.userService.getRoles();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPassword.Clear();
            txtPassword2.Clear();
            txtUsername.Clear();
            cmbRole.SelectedIndex = 0;

            Hide();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text == String.Empty || txtLastname.Text == String.Empty
                || txtPassword.Text == String.Empty || txtPassword2.Text == String.Empty || txtUsername.Text == String.Empty)
            {
                MessageBox.Show("Bitte alle Felder ausfüllen!");
            }
            else
            {
                if (txtPassword.Text != txtPassword2.Text)
                {
                    MessageBox.Show("Passwörter nicht ident!");
                }
                else
                {
                    User user = new User();
                    user.Firstname = txtFirstname.Text;
                    user.Lastname = txtLastname.Text;
                    user.Password = txtPassword.Text;
                    user.Username = txtUsername.Text;
                    user.Role = cmbRole.SelectedItem as Role;
                    bool success = Form1.userService.createUser(user);

                    cmdCancel_Click(sender, e);
                }
            }
        }
    }
}
