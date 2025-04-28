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
    public partial class Login : Form
    {
        public bool ok = false;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text.Length == 0 || txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Bitte Benutzername und Passwort ausfüllen!");
            }
            else
            {
                ok = true;
                Hide();
            }            
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            ok = false;
            Hide();
        }
    }
}
