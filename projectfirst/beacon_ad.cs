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
    public partial class beacon_ad : Form
    {
        public beacon_ad()
        {
            InitializeComponent();
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Text = "Search Beacon_ad Id";
            txtSearch.Select(txtSearch.TextLength, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            beacon_adform ss = new beacon_adform();
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

        private void beacon_ad_Load(object sender, EventArgs e)
        {

         try
            {
                string MyConnection2 = "server=localhost;uid=root;" + "pwd=;database=beacon_management_tool";
                string Query = "select beacon_ad.id, ads.title as ad_title, beacons.name as beacon_name from beacon_ad join beacons on beacon_ad.beacon_id=beacons.id join ads on beacon_ad.ad_id = ads.id;";
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

        private void beacon_ad_Enter(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txtSearch.ForeColor = Color.Black;
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
                string Query = "select beacon_ad.id, ads.title as ad_title, beacons.name as beacon_name from beacon_ad join beacons on beacon_ad.beacon_id=beacons.id join ads on beacon_ad.ad_id = ads.id where beacon_ad.id like('" + txtSearch.Text + "%');";
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
