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
using System.IO;

namespace KASSIMS
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        //Creates the connection to the database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KASSIMS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //Declares text file location and quote variables
        public static string textLocation = @"D:\COMPUTER SCIENCE PROJECT\KASSIMS\bin\Debug\motivationalquotes.txt";
        public static string textQuote = "";

        //Creates the random function
        public static Random rnd = new Random();
        private void Home_Load(object sender, EventArgs e)
        {
            //Displays the users name
            textName.Text = "Hello, " + Login.userName + "!";
            textName2.Text = Login.userName;

            //Displays the access level of the program for the current user
            if (Login.userPermissions == true)
            {
                textPermissions.Text = "User Type: The Mod";
            }
            else
            {
                textPermissions.Text = "User Type: The Furnisher";
            }

            //Reads the lines from the text file and shows a random line to the user
            string [] fileLines = File.ReadAllLines(textLocation);
            textQuote = fileLines[rnd.Next(0, 28)];
            textMotQuote.Text = textQuote;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        //Closes this form and open the furniture form.
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Furniture().ShowDialog();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {

        }

        private void buttonGraphs_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonReminders_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Reminders().ShowDialog();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Settings().ShowDialog();
        }
    }
}
