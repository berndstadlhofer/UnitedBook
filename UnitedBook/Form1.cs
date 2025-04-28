using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitedBook
{
    public partial class Form1 : Form
    {
        Login frmLogin = new Login();
        Userverwaltung frmUserverwaltung = new Userverwaltung();
        
        public static User meinUser = null;
        public static IUserService userService = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string userServiceClass = ConfigurationManager.AppSettings["userService"];
            userService = (IUserService)Activator.CreateInstance(Type.GetType(userServiceClass));

            do
            {
                frmLogin.ok = false;
                frmLogin.ShowDialog();
                String username = frmLogin.txtUsername.Text;
                String password = frmLogin.txtPassword.Text;
                meinUser = userService.login(username, password);
                if (meinUser == null)
                {
                    MessageBox.Show("Benutzername oder Passwort falsch!");
                    frmLogin.txtPassword.ResetText();
                }
                else
                {
                    lblUsername.Text = meinUser.Username;
                    lblRole.Text = meinUser.Role.ToString();
                }


            } while (meinUser == null && frmLogin.ok == true);

            if (meinUser != null)
            {
                //hier bin ich erfolgreich angemeldet worden
                manageMenuItems(true);               

            }
        }

        private void anmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void abmeldenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            meinUser = null;
            lblUsername.Text = "-";
            lblRole.Text = "-";

            frmLogin.txtPassword.ResetText();
            frmLogin.txtUsername.ResetText();

            manageMenuItems(false);
        }


        private void manageMenuItems(bool loggedIn)
        {
            if(!loggedIn)
            {
                anmeldenToolStripMenuItem.Visible = true;
                abmeldenToolStripMenuItem.Visible = false;
                userverwaltungToolStripMenuItem.Visible = false;
            }
            else
            {
                abmeldenToolStripMenuItem.Visible = true;
                anmeldenToolStripMenuItem.Visible = false;

                //Menüpunkte abhängig von Rolle aktivieren
                if (meinUser.Role.Id == 1)
                {
                    userverwaltungToolStripMenuItem.Visible = true;
                }
            }
        }

        private void userverwaltungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserverwaltung.ShowDialog();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
