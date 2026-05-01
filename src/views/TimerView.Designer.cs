namespace StretchApp.src.views
{
    partial class TimerView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            RestartButton = new Button();
            SessionTypeLabel = new Label();
            TimerOpt3Btn = new Button();
            TimerOpt2Btn = new Button();
            TimerOpt1Btn = new Button();
            StartButton = new Button();
            TimerLabel = new Label();
            PomodoroTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(RestartButton);
            panel1.Controls.Add(SessionTypeLabel);
            panel1.Controls.Add(TimerOpt3Btn);
            panel1.Controls.Add(TimerOpt2Btn);
            panel1.Controls.Add(TimerOpt1Btn);
            panel1.Controls.Add(StartButton);
            panel1.Controls.Add(TimerLabel);
            panel1.Location = new Point(24, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(613, 214);
            panel1.TabIndex = 0;
            // 
            // RestartButton
            // 
            RestartButton.BackColor = Color.FromArgb(245, 236, 227);
            RestartButton.BackgroundImageLayout = ImageLayout.Center;
            RestartButton.Font = new Font("Segoe UI", 15F);
            RestartButton.ForeColor = Color.FromArgb(117, 86, 84);
            RestartButton.Location = new Point(311, 98);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(61, 50);
            RestartButton.TabIndex = 7;
            RestartButton.Text = " ⟲";
            RestartButton.UseVisualStyleBackColor = false;
            // 
            // SessionTypeLabel
            // 
            SessionTypeLabel.AutoSize = true;
            SessionTypeLabel.Font = new Font("Gadugi", 7.20000029F, FontStyle.Underline, GraphicsUnit.Point, 0);
            SessionTypeLabel.ForeColor = Color.FromArgb(117, 86, 84);
            SessionTypeLabel.Location = new Point(269, 70);
            SessionTypeLabel.Name = "SessionTypeLabel";
            SessionTypeLabel.Size = new Size(76, 16);
            SessionTypeLabel.TabIndex = 6;
            SessionTypeLabel.Text = " Focus Time";
            // 
            // TimerOpt3Btn
            // 
            TimerOpt3Btn.BackColor = Color.FromArgb(117, 86, 84);
            TimerOpt3Btn.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerOpt3Btn.ForeColor = Color.White;
            TimerOpt3Btn.Location = new Point(417, 161);
            TimerOpt3Btn.Name = "TimerOpt3Btn";
            TimerOpt3Btn.Size = new Size(161, 38);
            TimerOpt3Btn.TabIndex = 5;
            TimerOpt3Btn.Text = "25 mins";
            TimerOpt3Btn.TextImageRelation = TextImageRelation.TextAboveImage;
            TimerOpt3Btn.UseVisualStyleBackColor = false;
            TimerOpt3Btn.Click += TimerOpt3Btn_Click;
            // 
            // TimerOpt2Btn
            // 
            TimerOpt2Btn.BackColor = Color.FromArgb(245, 236, 227);
            TimerOpt2Btn.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerOpt2Btn.ForeColor = Color.FromArgb(117, 86, 84);
            TimerOpt2Btn.Location = new Point(222, 161);
            TimerOpt2Btn.Name = "TimerOpt2Btn";
            TimerOpt2Btn.Size = new Size(161, 38);
            TimerOpt2Btn.TabIndex = 4;
            TimerOpt2Btn.Text = "15 mins";
            TimerOpt2Btn.UseVisualStyleBackColor = false;
            TimerOpt2Btn.Click += TimerOpt2Btn_Click;
            // 
            // TimerOpt1Btn
            // 
            TimerOpt1Btn.BackColor = Color.FromArgb(245, 236, 227);
            TimerOpt1Btn.Font = new Font("Franklin Gothic Medium Cond", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerOpt1Btn.ForeColor = Color.FromArgb(117, 86, 84);
            TimerOpt1Btn.Location = new Point(27, 161);
            TimerOpt1Btn.Name = "TimerOpt1Btn";
            TimerOpt1Btn.Size = new Size(161, 38);
            TimerOpt1Btn.TabIndex = 3;
            TimerOpt1Btn.Text = "5 mins";
            TimerOpt1Btn.UseVisualStyleBackColor = false;
            TimerOpt1Btn.Click += TimerOpt1Btn_Click;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.FromArgb(245, 236, 227);
            StartButton.BackgroundImageLayout = ImageLayout.Center;
            StartButton.Font = new Font("Segoe UI", 10F);
            StartButton.ForeColor = Color.FromArgb(117, 86, 84);
            StartButton.Location = new Point(232, 98);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(61, 50);
            StartButton.TabIndex = 1;
            StartButton.Text = "  ▶";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartButton_Click;
            // 
            // TimerLabel
            // 
            TimerLabel.AutoSize = true;
            TimerLabel.Font = new Font("Franklin Gothic Medium Cond", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TimerLabel.ForeColor = Color.FromArgb(119, 84, 84);
            TimerLabel.Location = new Point(264, 25);
            TimerLabel.Name = "TimerLabel";
            TimerLabel.Size = new Size(98, 39);
            TimerLabel.TabIndex = 0;
            TimerLabel.Text = "25:00";
            // 
            // PomodoroTimer
            // 
            PomodoroTimer.Interval = 1000;
            // 
            // TimerView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 63, 64);
            Controls.Add(panel1);
            Name = "TimerView";
            Size = new Size(664, 267);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button StartButton;
        private Label TimerLabel;
        private Button TimerOpt1Btn;
        private Button TimerOpt3Btn;
        private Button TimerOpt2Btn;
        private Label SessionTypeLabel;
        private System.Windows.Forms.Timer PomodoroTimer;
        private Button RestartButton;
    }
}
