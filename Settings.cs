using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KASSIMS
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
        }

        private void buttonFurniture_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Furniture().ShowDialog();
        }

        private void buttonReminders_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Reminders().ShowDialog();
        }

        //Checks if the user is an admin
        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            if (Login.userPermissions == true)
            {
                //Opens the add users window
                new AddUsersWindow().ShowDialog();
            }
            else
            {
                //Shows an error saying the user is not authorised
                MessageBox.Show("You are not an authorised user!", "Get The Mod to create a new user!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
