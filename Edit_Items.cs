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
    public partial class Edit_Items : Form
    {
        public Edit_Items()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\COMPUTER SCIENCE PROJECT - Copy\\KASSIMS\\bin\\Debug\\KASSIMS.mdb\\");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //Initiates the function to edit data in the database
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPrice.Text != "" && txtSellLocation.Text != "" && txtBuyPrice.Text != "" && txtBuyLocation.Text != "" && txtBuyDate.Text != "")
            {
                string query = "UPDATE tblFurniture " +
            "SET furniture_name=@name,furniture_price=@price,furniture_buylocation=@buylocation,furniture_buyprice=@buyprice,furniture_sellinglocation=@sellinglocation,furniture_buydate=@buydate " +
            "WHERE furniture_id=@id"; //SQL
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text); //@name stores the value in txtName
                cmd.Parameters.AddWithValue("@price", txtPrice.Text); //@price stores the value in txtPrice
                cmd.Parameters.AddWithValue("@buylocation", txtBuyLocation.Text); //Alike above
                cmd.Parameters.AddWithValue("@buyprice", txtBuyPrice.Text); //Alike above
                cmd.Parameters.AddWithValue("@sellinglocation", txtSellLocation.Text); //Alike above
                cmd.Parameters.AddWithValue("@buydate", txtBuyDate.Text); //Alike above
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text)); //Alike above
                con.Open(); //Opens the connection
                cmd.ExecuteNonQuery();
                con.Close(); //Closes the connection
                MessageBox.Show("Data Successfully Updated!", "Refresh Database To View Update", MessageBoxButtons.OK, MessageBoxIcon.Information); //Displays messasge of completion
                this.Close();
            }
            else
            {
                //Reports error if every field is not full
                MessageBox.Show("Missing Data", "Make sure every field is full", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            //Closes window
            this.Close();
        }
    }
}
