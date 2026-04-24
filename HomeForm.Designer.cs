namespace StretchApp
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            Dashboard = new TabControl();
            Workload = new TabPage();
            ReadingLog = new TabPage();
            ReadingLButton = new Button();
            TimerButton = new Button();
            wrkLoadButton = new Button();
            HomeButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            Dashboard.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(ReadingLButton);
            splitContainer1.Panel2.Controls.Add(TimerButton);
            splitContainer1.Panel2.Controls.Add(wrkLoadButton);
            splitContainer1.Panel2.Controls.Add(HomeButton);
            splitContainer1.Size = new Size(682, 973);
            splitContainer1.SplitterDistance = 900;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(label1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(Dashboard);
            splitContainer2.Size = new Size(682, 900);
            splitContainer2.SplitterDistance = 205;
            splitContainer2.TabIndex = 0;
            // 
            // Dashboard
            // 
            Dashboard.Controls.Add(Workload);
            Dashboard.Controls.Add(ReadingLog);
            Dashboard.Location = new Point(12, 67);
            Dashboard.Name = "Dashboard";
            Dashboard.SelectedIndex = 0;
            Dashboard.Size = new Size(658, 608);
            Dashboard.TabIndex = 0;
            // 
            // Workload
            // 
            Workload.Location = new Point(4, 29);
            Workload.Name = "Workload";
            Workload.Padding = new Padding(3);
            Workload.Size = new Size(650, 575);
            Workload.TabIndex = 0;
            Workload.Text = "Workload";
            Workload.UseVisualStyleBackColor = true;
            // 
            // ReadingLog
            // 
            ReadingLog.Location = new Point(4, 29);
            ReadingLog.Name = "ReadingLog";
            ReadingLog.Padding = new Padding(3);
            ReadingLog.Size = new Size(650, 611);
            ReadingLog.TabIndex = 1;
            ReadingLog.Text = "Reading Log";
            ReadingLog.UseVisualStyleBackColor = true;
            // 
            // ReadingLButton
            // 
            ReadingLButton.Image = (Image)resources.GetObject("ReadingLButton.Image");
            ReadingLButton.Location = new Point(553, 11);
            ReadingLButton.Name = "ReadingLButton";
            ReadingLButton.Size = new Size(49, 40);
            ReadingLButton.TabIndex = 3;
            ReadingLButton.UseVisualStyleBackColor = true;
            // 
            // TimerButton
            // 
            TimerButton.Image = (Image)resources.GetObject("TimerButton.Image");
            TimerButton.Location = new Point(396, 10);
            TimerButton.Name = "TimerButton";
            TimerButton.Size = new Size(49, 42);
            TimerButton.TabIndex = 2;
            TimerButton.UseVisualStyleBackColor = true;
            // 
            // wrkLoadButton
            // 
            wrkLoadButton.Image = (Image)resources.GetObject("wrkLoadButton.Image");
            wrkLoadButton.Location = new Point(239, 10);
            wrkLoadButton.Name = "wrkLoadButton";
            wrkLoadButton.Size = new Size(49, 43);
            wrkLoadButton.TabIndex = 1;
            wrkLoadButton.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            HomeButton.BackColor = Color.Transparent;
            HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
            HomeButton.Location = new Point(82, 10);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(49, 43);
            HomeButton.TabIndex = 0;
            HomeButton.TextImageRelation = TextImageRelation.ImageAboveText;
            HomeButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell Condensed", 30F);
            label1.Location = new Point(269, 87);
            label1.Name = "label1";
            label1.Size = new Size(116, 59);
            label1.TabIndex = 0;
            label1.Text = "Timer";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 973);
            Controls.Add(splitContainer1);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HomeForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Stretch";
            Load += HomeForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            Dashboard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button ReadingLButton;
        private Button TimerButton;
        private Button wrkLoadButton;
        private Button HomeButton;
        private TabControl Dashboard;
        private TabPage Workload;
        private TabPage ReadingLog;
        private Label label1;
    }
}