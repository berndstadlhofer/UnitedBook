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

    public partial class Userverwaltung : Form
    {
        NewUser frm_user = new NewUser();

        public Userverwaltung()
        {
            InitializeComponent();
        }

        private void Userverwaltung_Load(object sender, EventArgs e)
        {
            lstUser.DataSource = Form1.userService.getUsers();
        }

        private void lstUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = lstUser.SelectedItem as User;
            if (user != null)
            {
                lblID.Text = user.Id.ToString();
                lblBenutzername.Text = user.Username.ToString();
                lblNachname.Text = user.Lastname.ToString();
                lblVorname.Text = user.Firstname.ToString();
                lblRolle.Text = user.Role.Name.ToString();
            }
        }

        private void cmdNeu_Click(object sender, EventArgs e)
        {
            frm_user.ShowDialog();
            lstUser.DataSource = Form1.userService.getUsers();
        }

        private void cmdBearbeiten_Click(object sender, EventArgs e)
        {

        }

        private void cmdLoeschen_Click(object sender, EventArgs e)
        {
            User ausgewählterUser = lstUser.SelectedItem as User;
            if (ausgewählterUser != null)
            {
                if (ausgewählterUser.Id == Form1.meinUser.Id)
                {
                    MessageBox.Show("Löschen des angemeldeten Users nicht erlaubt!");
                    return;
                }

                DialogResult result = MessageBox.Show("Wollen Sie den User wirklich löschen?", "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //User an UserService übergeben zum Löschen
                    bool success = Form1.userService.deleteUser(ausgewählterUser);
                    if (!success)
                    {
                        MessageBox.Show("Löschen fehlgeschlagen!");
                    }
                    else
                    {
                        lstUser.DataSource = Form1.userService.getUsers();
                    }
                }
            }
        }
    }
}
