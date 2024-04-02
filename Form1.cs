using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datvetau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        Button x = null;
        private void button1_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;

                if (x!=null)
                {
                    x.BackColor = Color.Transparent;
                }
                
                if (bt.BackColor== Color.Transparent)
                {
                    bt.BackColor = Color.Orange;
                    x = bt;
                }
                
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control bt in tableLayoutPanel1.Controls)
            {
                if (bt is Button)
                {
                    bt.Click += button1_Click;
                }

            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            int tong =50000;
            if (numericUpDown1.Value >= 50)
            {
                tong = int.Parse(tb_dongia.Text) * 50 / 100;
            }
            else if(numericUpDown1.Value < 18)
            {
                tong = int.Parse(tb_dongia.Text) * 80 / 100;

            }


            dataGridView1.Rows.Add(x.Text, tb_hoten.Text, numericUpDown1.Value, tong);
            x.BackColor = Color.Red;
            x.Enabled = false;
            x = null;
            tb_hoten.Text = "";
            numericUpDown1.Value = 0;

        }
    }
}
