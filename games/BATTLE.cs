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

namespace games
{
    public partial class BATTLE : Form
    {

        public BATTLE()
        {
            InitializeComponent();

        }

        private void BATTLE_Load(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Fight fight = new Fight();
            fight.Show();
            fight.SetLabelText(textBox1.Text);
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
