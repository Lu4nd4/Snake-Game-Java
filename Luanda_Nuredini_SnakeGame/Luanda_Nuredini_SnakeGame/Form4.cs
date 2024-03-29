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
    public partial class Form4 : Form
    {
        public static int inHeight { get; set; }


        public Form4()
        {
            InitializeComponent();
            inHeight = 16;

            this.Load += Form4_Load;
            BoardSetting.Width = inHeight;
            BoardSetting.Height = inHeight;

        }


        private void Form4_Load(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void defaultSnakePaint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;
            Color headColor = Color.FromArgb(176, 69, 0);
            Color bodyColor = Color.FromArgb(253, 100, 10);


            canvas.FillEllipse(new SolidBrush(headColor), new Rectangle
            (
                10 * BoardSetting.Width,
                10 * BoardSetting.Height,
                BoardSetting.Width,
                BoardSetting.Height
            ));
        }

        private void snakeHeight_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(snakeHeight.Text, out int result))
            {
                inHeight = result;
                BoardSetting.Height = inHeight;
                BoardSetting.Width = inHeight;

                defaultSnake.Invalidate(); // Redraw the snake
            }
            else
            {
                // Handle the case where the text is not a valid integer
                // For example, display an error message or set a default value.
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Close();
            this.Hide();
            form1.ShowDialog();
        }
    }
}
