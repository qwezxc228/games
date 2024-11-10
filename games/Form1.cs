namespace games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//BATTLE
        {
            BATTLE bATTLE = new BATTLE();
           bATTLE.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//First AID
        {
            First_AID first_AID = new First_AID();
            first_AID.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)//Work
        {
            Work work = new Work();
            work.Show();
                this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)//Shop
        {
            Shop shop = new Shop();
            shop.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)//Adventure
        {
            Adventure adventure = new Adventure();
            adventure.Show();
                this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)//Exit
        {
            this.Hide();
        }
    }
}