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
    public partial class Furniture : Form
    {
        //Sets the text in the search bar to default to "Search"
        public Furniture()
        {
            InitializeComponent();
            textSearch.Text = "Search";
        }

        //Sets default options of variables
        private string multipleChoice = "furniture_id";
        private string search = "Search";
        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Fills up table on launch of this screen
        private void Furniture_Load(object sender, EventArgs e)
        {
            furnitureDataGridView.DataSource = GetFurnitureList();
        }


        //Function to retrieve data from the database
        private DataTable GetFurnitureList()
        {
            DataTable dtFurniture = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["KASSIMS.Properties.Settings.KASSIMSConnectionString"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblFurniture ORDER BY furniture_id;", con))
                {
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtFurniture.Load(reader);

                    con.Close();
                }
            }

            return dtFurniture;
        }

        //Function to allow user to search database using specified conditions
        private DataTable SearchFurnitureList(string condition, string name)
        {
            DataTable dtFurniture = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["KASSIMS.Properties.Settings.KASSIMSConnectionString"].ConnectionString;

            using (OleDbConnection con = new OleDbConnection(connString))
            {
                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM tblFurniture WHERE " + name  + " LIKE '%" + condition + "%' ORDER BY furniture_id;" , con))
                {
                    con.Open();

                    OleDbDataReader reader = cmd.ExecuteReader();

                    dtFurniture.Load(reader);

                    con.Close();
                }
            }

            return dtFurniture;
        }


        //Returns the user to the home screen when clicked
        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().ShowDialog();
        }

        //Searches and returns database for user's query
        private void button6_Click_1(object sender, EventArgs e)
        {
            furnitureDataGridView.DataSource = SearchFurnitureList(search, multipleChoice);
        }

        //Allows user to select what field they want to search for
        private void comboSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboSearchBy.Text == "ID")
            {
                multipleChoice = "furniture_id";
            }
            else if (comboSearchBy.Text == "Price")
            {
                multipleChoice = "furniture_price";
            }
            else
            {
                multipleChoice = "furniture_name";
            }
        }

        //When the user types in the search bar, it will store the data in variable "search"
        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            search = textSearch.Text;
        }

        //Opens the add furniture window
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            new AddFurnitureWindow().ShowDialog();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void furnitureDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Calls the function to refresh the table
            furnitureDataGridView.DataSource = GetFurnitureList();
        }

        //Opens the delete item window
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            new DeleteItem().ShowDialog();
        }

        //Opens the reminders window
        private void buttonReminders_Click(object sender, EventArgs e)
        {
            new Reminders().Show();
            this.Close();
        }

        //Opens the settings window
        private void buttonSettings_Click(object sender, EventArgs e)
        {
            this.Close();
            new Settings().ShowDialog();
        }

        //Opens the edit item window
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            new Edit_Items().Show();
        }
    }
}
