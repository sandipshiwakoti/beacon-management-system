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
    public partial class clicks : Form
    {
        public clicks()
        {
            InitializeComponent();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Ads' Name";
            txtSearch.Select(txtSearch.TextLength, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            clickform ss = new clickform();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard myDashboard = new Dashboard();
            myDashboard.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void clicks_Load(object sender, EventArgs e)
        {

            try
            {
              string MyConnection2 = "server=localhost;uid=root;" + "pwd=;database=beacon_management_tool";
              string Query ="select clicks.id,clicks.datetime,ads.title as ad_title from clicks join ads on clicks.ad_id=ads.id;";
              MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
              MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
              MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
              MyAdapter.SelectCommand = MyCommand2;
              DataTable dTable = new DataTable();
              MyAdapter.Fill(dTable);
              dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void clicks_Enter(object sender, EventArgs e)
        {
            
        }

        private void clicks_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string MyConnection2 = "server=localhost;uid=root;" + "pwd=;database=beacon_management_tool";
                string Query = "select clicks.id,clicks.datetime,ads.title as ad_title from clicks join ads on clicks.ad_id=ads.id where ads.title like('" + txtSearch.Text + "%');";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
