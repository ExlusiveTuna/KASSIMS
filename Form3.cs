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
    public partial class AddFurnitureWindow : Form
    {
        public AddFurnitureWindow()
        {
            InitializeComponent();
        }

        //Creates the connection to the database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KASSIMS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Closes this window when a user clicks it
        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtPrice.Text != "" && txtSellLocation.Text != "" && txtBuyPrice.Text != "" && txtBuyLocation.Text != "" && txtBuyDate.Text != "")
            {
                //Initiates connection to database
                con.Open();
                //Initiates a new SQL command
                string add = "INSERT INTO tblFurniture (furniture_id, furniture_name, furniture_price, furniture_sellinglocation, furniture_buyprice, furniture_buylocation, furniture_buydate) VALUES (@furniture_id, @furniture_name, @furniture_price, @furniture_sellinglocation, @furniture_buyprice, @furniture_buylocation, @furniture_buydate)";
                cmd = new OleDbCommand(add, con);
                //Sets parameters of command to the contents of the text boxes
                cmd.Parameters.AddWithValue("@furniture_id", txtID.Text);
                cmd.Parameters.AddWithValue("@furniture_name", txtName.Text);
                cmd.Parameters.AddWithValue("@furniture_price", txtPrice.Text);
                cmd.Parameters.AddWithValue("@furniture_sellinglocation", txtSellLocation.Text);
                cmd.Parameters.AddWithValue("@furniture_buyprice", txtBuyPrice.Text);
                cmd.Parameters.AddWithValue("@furniture_buylocation", txtBuyLocation.Text);
                cmd.Parameters.AddWithValue("@furniture_buydate", txtBuyDate.Text);
                cmd.ExecuteNonQuery();
                //Tells the user the data has been added
                MessageBox.Show("Refresh Table To View New Data", "Data Has Been Successfully Entered!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Close();
            }
            else
            {
                //Reports error if fields are empty
                MessageBox.Show("Make Sure No Fields Are Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
