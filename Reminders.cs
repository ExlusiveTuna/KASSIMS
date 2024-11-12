using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace KASSIMS
{
    public partial class Reminders : Form
    {
        public Reminders()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KASSIMS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //Empty string to be changed later in the code
        private string currentDate = "";
        private string currentTime = "";

        //Populates the reminder data grid from the database
        private void Reminders_Load(object sender, EventArgs e)
        {
            reminderDataGridView.DataSource = GetReminderList();
        }

        //Retrieves all reminders from database and ooutputs them to the screen
        private DataTable GetReminderList()
        {
            DataTable dtReminders = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["KASSIMS.Properties.Settings.KASSIMSConnectionString"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblReminders ORDER BY reminder_id;", con))
                {
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtReminders.Load(reader);
                }
            }

            return dtReminders;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Retrieves and shows current time and date
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.ToLongTimeString();
            labelTime.Text = currentTime;
            currentDate = DateTime.Now.ToLongDateString();
            labelDate.Text = currentDate;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void reminderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCreateReminder_Click(object sender, EventArgs e)
        {
            if (textRemID.Text != "" &&  textReminder.Text != "" && textTime.Text != ""  && textDate.Text != "")
            {
                //Initiates connection to database
                con.Open();
                //Initiates a new SQL command
                string add = "INSERT INTO tblReminders (reminder_id, reminder_description, reminder_time, reminder_date) VALUES (@reminder_id, @reminder_description, @reminder_time, @reminder_date)";
                cmd = new OleDbCommand(add, con);
                //Sets parameters of command to the contents of the text boxes
                cmd.Parameters.AddWithValue("@reminder_id", textRemID.Text);
                cmd.Parameters.AddWithValue("@reminder_description", textReminder.Text);
                cmd.Parameters.AddWithValue("@reminder_time", textTime.Text);
                cmd.Parameters.AddWithValue("@reminder_date", textDate.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Item Has Been Added", "Reminder Successfully Added!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                reminderDataGridView.DataSource = GetReminderList();

                con.Close();
            }
            else
            {
                //Reports error if fields are empty
                MessageBox.Show("Missing fields", "Make sure no fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Opens delete reminder window
        private void button1_Click(object sender, EventArgs e)
        {
            new DeleteReminder().Show();
        }

        //Refreshes data grid
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reminderDataGridView.DataSource = GetReminderList();
        }

        //Opens the furniture window
        private void buttonFurniture_Click(object sender, EventArgs e)
        {
            new Furniture().Show();
            this.Hide();
        }

        //Opens the home window
        private void buttonHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        //Opens the settings window
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            new Settings().Show();
            this.Hide();
        }

        private void buttonGraphs_Click(object sender, EventArgs e)
        {

        }

        private void buttonReminders_Click(object sender, EventArgs e)
        {
            
        }
    }
}
