using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace games
{

    public partial class Fight : Form
    {
        private Random random;

        public Fight()
        {
            InitializeComponent();
            random = new Random();
        }

        public void SetLabelText(string text)
        {
            label1.Text = "Name: " + text;
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            //player
            int randomDamagePlayer = random.Next(10, 20);
            int randomHpPlayer = random.Next(50, 100);
            int randomArmorPlayer = random.Next(10, 60);
            int randomSwordPlayer = random.Next(1, 10);
            int randomMoneyPlayer = random.Next(1, 30);
            label4.Text = "Damage: " + randomDamagePlayer.ToString();
            label6.Text = "HP: " + randomHpPlayer.ToString();
            label5.Text = "Armor: " + randomArmorPlayer.ToString();
            label3.Text = "Sword: " + randomSwordPlayer.ToString();
            label2.Text = "Money: " + randomMoneyPlayer.ToString();
            //enemy
            int randomDamageEnemy = random.Next(10, 15);
            int randomHpEnemy = random.Next(20, 60);
            int randomArmorEnemy = random.Next(10, 30);
            int randomSwordEnemy = random.Next(1, 5);
            label15.Text = "Damage: " + randomDamageEnemy.ToString();
            label14.Text = "HP: " + randomHpEnemy.ToString();
            label13.Text = "Armor: " + randomArmorEnemy.ToString();
            label10.Text = "Sword: " + randomSwordEnemy.ToString();
            if (randomDamagePlayer > randomHpEnemy
                || randomDamagePlayer > randomArmorEnemy
                || randomArmorPlayer > randomDamageEnemy
                || randomSwordPlayer > randomSwordEnemy
                || randomHpPlayer > randomDamageEnemy)
            {
                MessageBox.Show("Win Player!!!");
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Win Enemy!!!");
                form1.Show();
                this.Hide();
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
