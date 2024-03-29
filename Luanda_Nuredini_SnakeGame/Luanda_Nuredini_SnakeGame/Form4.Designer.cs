namespace Luanda_Nuredini_SnakeGame
{
    partial class Form4
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
            label1 = new Label();
            snakeHeight = new TextBox();
            defaultSnake = new PictureBox();
            quit = new Button();
            ((System.ComponentModel.ISupportInitialize)defaultSnake).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(104, 231, 10);
            label1.Location = new Point(51, 673);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 1;
            label1.Text = "Change Size";
            // 
            // snakeHeight
            // 
            snakeHeight.BackColor = Color.FromArgb(46, 80, 80);
            snakeHeight.BorderStyle = BorderStyle.FixedSingle;
            snakeHeight.Location = new Point(51, 715);
            snakeHeight.Multiline = true;
            snakeHeight.Name = "snakeHeight";
            snakeHeight.Size = new Size(175, 38);
            snakeHeight.TabIndex = 2;
            snakeHeight.TextChanged += snakeHeight_TextChanged;
            // 
            // defaultSnake
            // 
            defaultSnake.BackColor = Color.FromArgb(12, 15, 33);
            defaultSnake.BorderStyle = BorderStyle.Fixed3D;
            defaultSnake.Location = new Point(38, 35);
            defaultSnake.Name = "defaultSnake";
            defaultSnake.Size = new Size(458, 602);
            defaultSnake.TabIndex = 5;
            defaultSnake.TabStop = false;
            defaultSnake.Paint += defaultSnakePaint;
            // 
            // quit
            // 
            quit.BackColor = Color.FromArgb(12, 15, 33);
            quit.FlatStyle = FlatStyle.Popup;
            quit.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point);
            quit.ForeColor = SystemColors.Control;
            quit.Location = new Point(310, 715);
            quit.Name = "quit";
            quit.Size = new Size(175, 38);
            quit.TabIndex = 6;
            quit.Text = "Back";
            quit.UseVisualStyleBackColor = false;
            quit.Click += quit_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 80, 80);
            ClientSize = new Size(530, 807);
            Controls.Add(quit);
            Controls.Add(defaultSnake);
            Controls.Add(snakeHeight);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Snake Game (Classic)";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)defaultSnake).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox snakeHeight;
        private PictureBox defaultSnake;
        private Button quit;
    }
}