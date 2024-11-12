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
    public partial class DeleteItem : Form
    {
        public DeleteItem()
        {
            InitializeComponent();
        }

        //Creates the connection to the database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KASSIMS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //Defines a variable to be used later
        public static string idDelete = "";

        private void DeleteItem_Load(object sender, EventArgs e)
        {

        }


        //If the user confirms deletion, it will delete the item from the database
        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            if (txtDeleteID.Text != "")
            {
                DialogResult dialog = MessageBox.Show("Are You Sure?", "Delete Item with ID '" + idDelete + "'?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    con.Open();
                    string del = "DELETE from tblFurniture WHERE furniture_id = " + idDelete + ";";
                    cmd = new OleDbCommand(del, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted!", "Item Was Successfully Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error", "Make Sure To Fill The Field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Updates the variable whenever the text box is changed
        private void txtDeleteID_TextChanged(object sender, EventArgs e)
        {
            idDelete = txtDeleteID.Text;
        }
    }
}
