using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.OleDb;


namespace KASSIMS
{
    public partial class AddUsersWindow : Form
    {
        public AddUsersWindow()
        {
            InitializeComponent();
        }

        //Creates the connection to the database
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=KASSIMS.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void buttonCreateReminder_Click(object sender, EventArgs e)
        {
            //If fields are not empty
            if(textName.Text != "" && textUsername.Text != "" && textPassword.Text != "")
            {
                //Initiates connection to database
                con.Open();
                //Initiates a new SQL command
                string add = "INSERT INTO tblUser (user_id,user_name, user_username, user_password) VALUES (@user_id,@user_name, @user_username, @user_password)";
                cmd = new OleDbCommand(add, con);
                //Sets parameters of command to the contents of the text boxes
                cmd.Parameters.AddWithValue("@user_id", textID.Text);
                cmd.Parameters.AddWithValue("@user_name", textName.Text);
                cmd.Parameters.AddWithValue("@user_username", textUsername.Text);
                cmd.Parameters.AddWithValue("@user_password", textPassword.Text);
                cmd.ExecuteNonQuery();
                //Tells the user the data has been added
                MessageBox.Show("Success", "User has been added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Make Sure No Fields Are Empty", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
