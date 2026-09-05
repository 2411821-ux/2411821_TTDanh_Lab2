using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2411821_TTDanh_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (checkBox1.Checked) 
                s += int.Parse(label6.Text.Split('.')[0]);
            if (checkBox2.Checked) 
                s += int.Parse(label7.Text.Split('.')[0]);
            if (checkBox3.Checked)
                s += int.Parse(label9.Text.Split('.')[0]);
            if (checkBox4.Checked)
                s += int.Parse(label8.Text.Split('.')[0]);
            this.textBox2.Text = s + ".000 đồng";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reset()
        {
            this.comboBox1.Text = "";
            this.textBox1.Text = "";
            this.dateTimePicker1.Value = DateTime.Now;
            this.checkBox1.Checked = false;
            this.checkBox2.Checked = false;
            this.checkBox3.Checked = false;
            this.checkBox4.Checked = false;
            this.textBox2.Text = "";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.reset();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

