using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace KASSIMS
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        //Creates the connection to the database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KASSIMS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //Declares user name and permissions variables
        public static string userName = "";
        public static Boolean userPermissions = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Closes the software
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Checks if the username and password entered are blank and reports an error
            if (textUsername.Text == "" && textPassword.Text == "")
            {
                MessageBox.Show("Username and Password are empty", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Checks if the username is blank and reports an error
            else if (textUsername.Text == "")
            {
                MessageBox.Show("Username is empty", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Checks if the password is blank and reports an error
            else if (textPassword.Text == "")
            {
                MessageBox.Show("Password is empty", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Initiates connection to database
                con.Open();
                //Initiates a new SQL command
                string login = "SELECT * FROM tblUser WHERE user_username = '" + textUsername.Text + "' and user_password = '" + textPassword.Text + "'";
                cmd = new OleDbCommand(login, con);
                OleDbDataReader dr = cmd.ExecuteReader();

                //If the username and password are valid, it will display the home page
                if (dr.Read() == true)
                {
                    //Saves an SQL statement in a local variable
                    string nameGetter = "SELECT user_name FROM tblUser WHERE user_username = '" + textUsername.Text + "'";
                    //Creates a new SQL command
                    cmd = new OleDbCommand(nameGetter, con);
                    //Stores the users name from the database into the username variable
                    userName = cmd.ExecuteScalar().ToString();

                    //Saves an SQL statement in a local variable
                    string permissionGetter = "SELECT user_moduser FROM tblUser WHERE user_username = '" + textUsername.Text + "'";
                    //Creates a new SQL command
                    cmd = new OleDbCommand(permissionGetter, con);
                    //Stores the users access level in a variable to be used in other forms
                    if (cmd.ExecuteScalar().ToString() == "True")
                    {
                        userPermissions = true;
                    }


                    new Home().Show();
                    this.Hide();
                    con.Close();
                }
                //If the username or password is wrong, reports an error and resets text fields to blank
                else
                {
                    MessageBox.Show("Invalid Username or Password. Please try again", "Try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textUsername.Text = "";
                    textPassword.Text = "";
                    textUsername.Focus();
                    con.Close();
                }
            }
        }

        //If clicked, it will change between a visible password or censored password
        private void iconShowPassword_Click(object sender, EventArgs e)
        {
            if (textPassword.PasswordChar == '\0')
            {
                textPassword.PasswordChar = '*';
            }
            else
            {
                textPassword.PasswordChar = '\0';
            }
        }
    }
}
