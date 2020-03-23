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
    public partial class beaconform : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString; 
        public beaconform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            beacons mybeacons = new beacons();
            mybeacons.ShowDialog();
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
                MessageBox.Show("Connected successfully");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string Query = "INSERT INTO beacons(name, uuid, mfd_date, mfd_company, description, proximity, area_id, client_id)"+
                " VALUES ('" + this.name.Text + "','"+this.uuid.Text+"','"+this.mfd_date.Text+"','"+this.mfd_company.Text+"',"+
                "'" + this.description.Text + "','"+this.proximity.Text+"','" + this.area_id.Text + "','" + this.client_id.Text 
                + "');";
            MySqlCommand MyCommand2 = new MySqlCommand(Query, conn);
            MySqlDataReader MyReader2;
            MyReader2 = MyCommand2.ExecuteReader();
            MessageBox.Show("Data is saved");
        }

        private bool ValidateData()
        {
            if (name.Text == "" || uuid.Text == "" || uuid.Text == "" || mfd_date.Text == "" || mfd_company.Text == "" 
                || description.Text == "" || proximity.Text == "" || area_id.Text == "" || client_id.Text == "")
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void beaconform_Load(object sender, EventArgs e)
        {

        }
    }
}
