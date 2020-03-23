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
    public partial class clickform : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        public clickform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
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
            string Query = "INSERT INTO clicks(datetime,ad_id) VALUES ('" + this.datetime.Text + "','" + this.ad_id.Text + "');";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("save data");
        }
        private bool ValidateData()
        {
            if (ad_id.Text == "" || datetime.Text == "")
            {
                MessageBox.Show("Please fill up the form completely !", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;   //ForDataValidation 
            }
            return true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            clicks myclicks = new clicks();
            myclicks.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
