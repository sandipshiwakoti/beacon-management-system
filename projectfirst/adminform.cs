using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projectfirst
{
    public partial class adminform : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        public adminform()
        {
            InitializeComponent();
        }

        private void adminform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            admins myadmins = new admins();
            myadmins.ShowDialog();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            myConnectionString = "server=localhost;uid=root;" + "pwd=;database=beacon_management_tool";
            if (ValidateData() != true)
                return;
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MessageBox.Show("connected successfully");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string Query = "INSERT INTO admins(name, email, password, mob_no, dob) VALUES ('" + this.name.Text + "'," +
                "'" + this.email.Text + "','" + this.pw.Text + "','" + this.mob_no.Text + "','" + this.dob.Text + "');";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Data is saved");
        }

        private bool ValidateData()
        {
            if (name.Text == "" || email.Text == "" || pw.Text == "" || mob_no.Text == "" || dob.Text == "")
            {
                MessageBox.Show("Please fill up the form completely !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;   //ForDataValidation 
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}






