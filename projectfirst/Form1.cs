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
    public partial class Form1 : Form
    {

        MySql.Data.MySqlClient.MySqlConnection conn;
        string MyConnectionString;
        public Form1()
        {
            MyConnectionString = "server=localhost;uid=root;" + "pwd=;database=beacon_management_tool";
            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(MyConnectionString);
                conn.Open();
                // MessageBox.Show("connected successfully");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) {
                MessageBox.Show(ex.Message);
            }
            InitializeComponent();


        }
 

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard ss = new Dashboard();
            ss.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (ValidateData() != true)
                return;
            string name = username.Text;
            MyConnectionString = "server=localhost;uid=root;pwd=;database=beacon_management_tool;";
            conn = new MySqlConnection(MyConnectionString);
            conn.Open();
            String Query = "select * from admins where name = @name and password= @password;";
            MySqlCommand command = new MySqlCommand(Query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            command.Parameters.AddWithValue("@name", username.Text);
            command.Parameters.AddWithValue("@password", password.Text);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show(name + "! Welcome to ISMT BEACON!" );
                this.Hide();
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }


        }
        private bool ValidateData()
        {
            if (username.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill up the form completely !", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;   //ForDataValidation 
            }
            return true;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button7_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                button7_MouseClick(sender, null);
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
