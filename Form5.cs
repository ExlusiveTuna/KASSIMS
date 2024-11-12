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
    public partial class DeleteReminder : Form
    {
        public DeleteReminder()
        {
            InitializeComponent();
        }

        //Variables for connection to the database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KASSIMS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        //Empty string
        public static string idDelete = "";

        private void btnConfirmDelete_Click(object sender, EventArgs e)
        {
            //If there is an ID to delete
            if (idDelete != "")
            {
                //Confirmation message to confirm deletion
                DialogResult dialog = MessageBox.Show("Are You Sure?", "Delete Item with ID '" + idDelete + "'?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    //Executes deletion command
                    con.Open();
                    string del = "DELETE from tblReminders WHERE reminder_id = " + idDelete + ";";
                    cmd = new OleDbCommand(del, con);
                    cmd.ExecuteNonQuery();
                    //Shows output to the user of successful deletion
                    MessageBox.Show("Successfully Deleted!", "Item Was Successfully Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error", "Make Sure To Fill The Field!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Updates the variable when the text is changed
        private void txtDeleteID_TextChanged(object sender, EventArgs e)
        {
            idDelete = txtDeleteID.Text;
        }
    }
}
