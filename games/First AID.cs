using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games
{
    public partial class First_AID : Form
    {
        public First_AID()
        {
            InitializeComponent();
        }

        private void First_AID_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 10 HP");
            this.Hide();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 20 HP");
            this.Hide();
            form1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 30 HP");
                this.Hide();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 40 HP");
                this.Hide();
            form1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 50 HP");
            this.Hide();
            form1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 60 HP");
            this.Hide();
            form1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 70 HP");
                this.Hide();
            form1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 80 HP");
            this.Hide();
            form1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 90 HP");
                this.Hide();
            form1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            MessageBox.Show("вы востоновили здоровье на 100 HP");
            this.Hide();
            form1.Show();
        }
    }
}
