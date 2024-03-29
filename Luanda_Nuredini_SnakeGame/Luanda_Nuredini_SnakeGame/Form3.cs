using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Luanda_Nuredini_SnakeGame
{
    public partial class Form3 : Form
    {
        private List<int> list;

        public Form3()
        {
            InitializeComponent();
            list = HighScoreManager.HighScores.ToList();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Order the highScores list in descending order
            list = list.OrderByDescending(score => score).ToList();

            // Iterate through the first 10 scores or less if the list has fewer than 10 scores
            for (int i = 0; i < Math.Min(10, list.Count); i++)
            {
                // Get the label corresponding to the index (i + 2 because labels start from index 2)
                Label label = Controls.Find($"label{i + 2}", true).FirstOrDefault() as Label;

                // Display the score on the label
                if (label != null)
                {
                    label.Text = $"{GetPlaceSuffix(i + 1)} Place: {list[i]}";
                }
            }
        }


        // Helper method to get the suffix for a number (e.g., 1st, 2nd, 3rd)
        private string GetPlaceSuffix(int place)
        {
            if (place % 100 >= 11 && place % 100 <= 13)
            {
                return place + "th";
            }

            switch (place % 10)
            {
                case 1:
                    return place + "st";
                case 2:
                    return place + "nd";
                case 3:
                    return place + "rd";
                default:
                    return place + "th";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
