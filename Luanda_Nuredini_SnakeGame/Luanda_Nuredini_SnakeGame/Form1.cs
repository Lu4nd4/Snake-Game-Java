using System.Windows.Forms;

namespace Luanda_Nuredini_SnakeGame
{
    public partial class Form1 : Form

    {
        private int interval;
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            interval = 130;
            form2 = new Form2(interval);
            this.Hide();
            form2.ShowDialog();
        }

        private void Medium_Click(object sender, EventArgs e)
        {
            interval = 100;
            form2 = new Form2(interval);
            this.Hide();
            form2.ShowDialog();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            interval = 70;
            form2 = new Form2(interval);
            this.Hide();
            form2.ShowDialog();
        }

        private void Expert_Click(object sender, EventArgs e)
        {
            interval = 40;
            form2 = new Form2(interval);
            this.Hide();
            form2.ShowDialog();
        }


        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
        }

        private void Score_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}