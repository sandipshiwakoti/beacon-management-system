using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectfirst
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            beacons ss = new beacons();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            admins ss = new admins();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            clients ss = new clients();
            ss.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            areas ss = new areas();
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            ads ss = new ads();
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            clicks ss = new clicks();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            impressions ss = new impressions();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            beacon_ad ss = new beacon_ad();
            ss.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 myForm1 = new Form1();
            myForm1.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button2_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button13_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Green;
        }

        private void button13_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
