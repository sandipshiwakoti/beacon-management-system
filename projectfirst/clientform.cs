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
    public partial class clientform : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        public clientform()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {

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
            string Query = "INSERT INTO clients(name,email,description,address,dob) VALUES ('"+this.name.Text+"'," +
                "'"+this.email.Text+"','"+this.desc.Text+"','"+this.address.Text+"','"+this.dob.Text+"');";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Data is saved");
        }

        private bool ValidateData()
        {          
            if (name.Text == "" || email.Text == "" || address.Text == ""|| desc.Text == "" || dob.Text =="")
            {
                MessageBox.Show("Please fill up the form completely !", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;   //ForDataValidation 
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            clients myclients = new clients();
            myclients.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void clientform_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
