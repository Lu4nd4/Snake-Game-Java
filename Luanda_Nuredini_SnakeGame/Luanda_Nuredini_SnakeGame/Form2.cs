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
    public partial class Form2 : Form
    {

        private List<SnakeDrawing> Snake = new List<SnakeDrawing>();
        private SnakeDrawing food = new SnakeDrawing();
        public List<int> highscores { get; set; }

        private int interval;

        int maxWidth;
        int maxHeight;

        int score;
        int highscore;

        Random rand = new Random();

        bool goLeft, goRight, goDown, goUp;
        public Form2(int interval)
        {
            InitializeComponent();
            highscores = new List<int>();
            this.interval = interval;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void KeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && BoardSetting.directions != "right")
            {
                goLeft = true;
                timer1.Interval = 10;
            }
            if (e.KeyCode == Keys.Right && BoardSetting.directions != "left")
            {
                goRight = true;
                timer1.Interval = 10;
            }
            if (e.KeyCode == Keys.Up && BoardSetting.directions != "down")
            {
                goUp = true;
                timer1.Interval = 10;
            }
            if (e.KeyCode == Keys.Down && BoardSetting.directions != "up")
            {
                goDown = true;
                timer1.Interval = 10;
            }
        }

        private void KeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                timer1.Interval = interval;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
                timer1.Interval = interval;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
                timer1.Interval = interval;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
                timer1.Interval = interval;
            }
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            timer1.Interval = interval;

            if (goLeft)
            {
                BoardSetting.directions = "left";
            }
            if (goRight)
            {
                BoardSetting.directions = "right";
            }
            if (goDown)
            {
                BoardSetting.directions = "down";
            }
            if (goUp)
            {
                BoardSetting.directions = "up";
            }

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {

                    switch (BoardSetting.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Snake[i].X < 0)
                    {
                        Snake[i].X = maxWidth;
                    }
                    if (Snake[i].X > maxWidth)
                    {
                        Snake[i].X = 0;
                    }
                    if (Snake[i].Y < 0)
                    {
                        Snake[i].Y = maxHeight;
                    }
                    if (Snake[i].Y > maxHeight)
                    {
                        Snake[i].Y = 0;
                    }


                    if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 1; j < Snake.Count; j++)
                    {

                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }

                    }


                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }


            snakeBoard.Invalidate();
        }


        private void EatFood()
        {
            score += 1;

            myScore.Text = "Score: " + score;

            SnakeDrawing body = new SnakeDrawing
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = new SnakeDrawing { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };


        }

        private void GameOver()
        {

            timer1.Stop();

            restart.Enabled = true;
            quit.Enabled = true;



            if (score > highscore)
            {

                highscore = score;
                HighScoreManager.AddScore(highscore);
                highScore.Text = "High Score: " + highscore;
            }
        }


        private void StartGame()
        {

            timer1.Interval = interval;

            maxWidth = snakeBoard.Width / BoardSetting.Width - 1;
            maxHeight = snakeBoard.Height / BoardSetting.Height - 1;

            Snake.Clear();
            restart.Enabled = false;
            quit.Enabled = false;


            score = 0;
            myScore.Text = "Score: " + score;

            SnakeDrawing head = new SnakeDrawing { X = 10, Y = 5 };
            Snake.Add(head); 

            for (int i = 0; i < 10; i++)
            {
                SnakeDrawing body = new SnakeDrawing();
                Snake.Add(body);
            }

            food = new SnakeDrawing { X = rand.Next(2, maxWidth), Y = rand.Next(2, maxHeight) };

            timer1.Start();
        }

        private void restart_Click(object sender, EventArgs e)
        {

            StartGame();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Close();
            this.Hide();

            form1.ShowDialog();
        }

        private void upDateSnake(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColour;
            Color foodColor = Color.FromArgb(104, 231, 10);
            Color headColor = Color.FromArgb(176, 69, 0);
            Color bodyColor = Color.FromArgb(253, 100, 10);



            for (int i = 0; i < Snake.Count; i++)
            {
                if (i == 0)
                {

                    snakeColour = new SolidBrush(headColor);
                }
                else
                {
                    snakeColour = new SolidBrush(bodyColor);
                }

                canvas.FillEllipse(snakeColour, new Rectangle
                    (
                    Snake[i].X * BoardSetting.Width,
                    Snake[i].Y * BoardSetting.Height,
                    BoardSetting.Width, BoardSetting.Height
                    ));
            }


            canvas.FillEllipse(new SolidBrush(foodColor), new Rectangle
            (
            food.X * BoardSetting.Width,
            food.Y * BoardSetting.Height,
            BoardSetting.Width, BoardSetting.Height
            ));
        }


    }
}