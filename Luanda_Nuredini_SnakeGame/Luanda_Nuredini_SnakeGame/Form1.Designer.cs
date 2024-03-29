namespace Luanda_Nuredini_SnakeGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            Easy = new Button();
            Medium = new Button();
            Hard = new Button();
            Expert = new Button();
            Score = new Button();
            Settings = new Button();
            closebtn = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(253, 100, 1);
            label1.Location = new Point(77, 112);
            label1.Name = "label1";
            label1.Size = new Size(383, 78);
            label1.TabIndex = 0;
            label1.Text = "Snake Game";
            // 
            // Easy
            // 
            Easy.BackColor = Color.FromArgb(12, 15, 33);
            Easy.FlatStyle = FlatStyle.Popup;
            Easy.ForeColor = Color.FromArgb(104, 231, 10);
            Easy.Location = new Point(180, 266);
            Easy.Name = "Easy";
            Easy.Size = new Size(175, 38);
            Easy.TabIndex = 1;
            Easy.Text = "Easy";
            Easy.UseVisualStyleBackColor = false;
            Easy.Click += Easy_Click;
            // 
            // Medium
            // 
            Medium.BackColor = Color.FromArgb(12, 15, 33);
            Medium.FlatStyle = FlatStyle.Popup;
            Medium.ForeColor = Color.FromArgb(104, 231, 10);
            Medium.Location = new Point(180, 335);
            Medium.Name = "Medium";
            Medium.Size = new Size(175, 38);
            Medium.TabIndex = 2;
            Medium.Text = "Medium";
            Medium.UseVisualStyleBackColor = false;
            Medium.Click += Medium_Click;
            // 
            // Hard
            // 
            Hard.BackColor = Color.FromArgb(12, 15, 33);
            Hard.FlatStyle = FlatStyle.Popup;
            Hard.ForeColor = Color.FromArgb(104, 231, 10);
            Hard.Location = new Point(180, 401);
            Hard.Name = "Hard";
            Hard.Size = new Size(175, 38);
            Hard.TabIndex = 3;
            Hard.Text = "Hard";
            Hard.UseVisualStyleBackColor = false;
            Hard.Click += Hard_Click;
            // 
            // Expert
            // 
            Expert.BackColor = Color.FromArgb(12, 15, 33);
            Expert.FlatStyle = FlatStyle.Popup;
            Expert.ForeColor = Color.FromArgb(104, 231, 10);
            Expert.Location = new Point(180, 471);
            Expert.Name = "Expert";
            Expert.Size = new Size(175, 38);
            Expert.TabIndex = 4;
            Expert.Text = "Expert";
            Expert.UseVisualStyleBackColor = false;
            Expert.Click += Expert_Click;
            // 
            // Score
            // 
            Score.BackColor = Color.FromArgb(12, 15, 33);
            Score.FlatStyle = FlatStyle.Popup;
            Score.ForeColor = Color.FromArgb(104, 231, 10);
            Score.Location = new Point(180, 571);
            Score.Name = "Score";
            Score.Size = new Size(175, 38);
            Score.TabIndex = 5;
            Score.Text = "Score Board";
            Score.UseVisualStyleBackColor = false;
            Score.Click += Score_Click;
            // 
            // Settings
            // 
            Settings.BackColor = Color.FromArgb(12, 15, 33);
            Settings.FlatStyle = FlatStyle.Flat;
            Settings.ForeColor = SystemColors.Control;
            Settings.Location = new Point(38, 736);
            Settings.Name = "Settings";
            Settings.Size = new Size(175, 38);
            Settings.TabIndex = 6;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = false;
            Settings.Click += Settings_Click;
            // 
            // closebtn
            // 
            closebtn.BackColor = Color.FromArgb(12, 15, 33);
            closebtn.FlatStyle = FlatStyle.Flat;
            closebtn.ForeColor = SystemColors.Control;
            closebtn.Location = new Point(323, 736);
            closebtn.Name = "closebtn";
            closebtn.Size = new Size(175, 38);
            closebtn.TabIndex = 7;
            closebtn.Text = "Close";
            closebtn.UseVisualStyleBackColor = false;
            closebtn.Click += closebtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 80, 80);
            ClientSize = new Size(530, 807);
            Controls.Add(closebtn);
            Controls.Add(Settings);
            Controls.Add(Score);
            Controls.Add(Expert);
            Controls.Add(Hard);
            Controls.Add(Medium);
            Controls.Add(Easy);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Snake Game (Classic)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Easy;
        private Button Medium;
        private Button Hard;
        private Button Expert;
        private Button Score;
        private Button Settings;
        private Button closebtn;
        private System.Windows.Forms.Timer timer1;
    }
}