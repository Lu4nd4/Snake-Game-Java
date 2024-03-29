namespace Luanda_Nuredini_SnakeGame
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            snakeBoard = new PictureBox();
            myScore = new Label();
            highScore = new Label();
            restart = new Button();
            quit = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)snakeBoard).BeginInit();
            SuspendLayout();
            // 
            // snakeBoard
            // 
            snakeBoard.BackColor = Color.FromArgb(12, 15, 33);
            snakeBoard.BorderStyle = BorderStyle.Fixed3D;
            snakeBoard.Location = new Point(37, 34);
            snakeBoard.Name = "snakeBoard";
            snakeBoard.Size = new Size(458, 602);
            snakeBoard.TabIndex = 0;
            snakeBoard.TabStop = false;
            snakeBoard.Paint += upDateSnake;
            // 
            // myScore
            // 
            myScore.BackColor = Color.FromArgb(46, 80, 80);
            myScore.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            myScore.ForeColor = Color.FromArgb(104, 231, 10);
            myScore.Location = new Point(57, 659);
            myScore.Name = "myScore";
            myScore.Size = new Size(175, 37);
            myScore.TabIndex = 1;
            myScore.Text = "Score: ";
            // 
            // highScore
            // 
            highScore.BackColor = Color.FromArgb(46, 80, 80);
            highScore.Font = new Font("Cascadia Mono", 10F, FontStyle.Regular, GraphicsUnit.Point);
            highScore.ForeColor = Color.FromArgb(104, 231, 10);
            highScore.Location = new Point(301, 659);
            highScore.Name = "highScore";
            highScore.Size = new Size(175, 37);
            highScore.TabIndex = 2;
            highScore.Text = "High Score: ";
            // 
            // restart
            // 
            restart.BackColor = Color.FromArgb(12, 15, 33);
            restart.FlatStyle = FlatStyle.Popup;
            restart.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            restart.ForeColor = SystemColors.Control;
            restart.Location = new Point(57, 724);
            restart.Name = "restart";
            restart.Size = new Size(175, 38);
            restart.TabIndex = 3;
            restart.Text = "Restart";
            restart.UseVisualStyleBackColor = false;
            restart.Click += restart_Click;
            // 
            // quit
            // 
            quit.BackColor = Color.FromArgb(12, 15, 33);
            quit.FlatStyle = FlatStyle.Popup;
            quit.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            quit.ForeColor = SystemColors.Control;
            quit.Location = new Point(301, 724);
            quit.Name = "quit";
            quit.Size = new Size(175, 38);
            quit.TabIndex = 4;
            quit.Text = "Quit";
            quit.UseVisualStyleBackColor = false;
            quit.Click += quit_Click;
            // 
            // timer1
            // 
            timer1.Tick += gameTimerEvent;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 80, 80);
            ClientSize = new Size(530, 807);
            Controls.Add(quit);
            Controls.Add(restart);
            Controls.Add(highScore);
            Controls.Add(myScore);
            Controls.Add(snakeBoard);
            Name = "Form2";
            StartPosition = FormStartPosition.Manual;
            Text = "Snake Game (Classic)";
            Load += Form2_Load;
            KeyDown += KeyDownEvent;
            KeyUp += KeyUpEvent;
            ((System.ComponentModel.ISupportInitialize)snakeBoard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox snakeBoard;
        private Label myScore;
        private Label highScore;
        private Button restart;
        private Button quit;
        private System.Windows.Forms.Timer timer1;
    }
}