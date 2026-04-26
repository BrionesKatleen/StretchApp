namespace StretchApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            NavBar = new Panel();
            LogPageButton = new Button();
            TimerPageButton = new Button();
            TaskPageButton = new Button();
            Home = new Button();
            panel1 = new Panel();
            MainSection = new Panel();
            SearchButton = new Button();
            AddButton = new Button();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            NavBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // NavBar
            // 
            NavBar.BackColor = Color.White;
            NavBar.Controls.Add(LogPageButton);
            NavBar.Controls.Add(TimerPageButton);
            NavBar.Controls.Add(TaskPageButton);
            NavBar.Controls.Add(Home);
            NavBar.Location = new Point(3, 902);
            NavBar.Name = "NavBar";
            NavBar.Size = new Size(682, 73);
            NavBar.TabIndex = 0;
            // 
            // LogPageButton
            // 
            LogPageButton.BackColor = Color.Transparent;
            LogPageButton.BackgroundImage = Properties.Resources.Log;
            LogPageButton.BackgroundImageLayout = ImageLayout.Center;
            LogPageButton.Location = new Point(586, 15);
            LogPageButton.Name = "LogPageButton";
            LogPageButton.Size = new Size(40, 40);
            LogPageButton.TabIndex = 3;
            LogPageButton.UseVisualStyleBackColor = false;
            LogPageButton.Click += LogPageButton_Click;
            // 
            // TimerPageButton
            // 
            TimerPageButton.BackColor = Color.Transparent;
            TimerPageButton.BackgroundImage = Properties.Resources.Timer;
            TimerPageButton.BackgroundImageLayout = ImageLayout.Center;
            TimerPageButton.Location = new Point(415, 15);
            TimerPageButton.Name = "TimerPageButton";
            TimerPageButton.Size = new Size(40, 40);
            TimerPageButton.TabIndex = 2;
            TimerPageButton.UseVisualStyleBackColor = false;
            TimerPageButton.Click += TimerPageButton_Click;
            // 
            // TaskPageButton
            // 
            TaskPageButton.BackColor = Color.Transparent;
            TaskPageButton.BackgroundImage = Properties.Resources.Task;
            TaskPageButton.BackgroundImageLayout = ImageLayout.Center;
            TaskPageButton.Location = new Point(244, 15);
            TaskPageButton.Name = "TaskPageButton";
            TaskPageButton.Size = new Size(40, 40);
            TaskPageButton.TabIndex = 1;
            TaskPageButton.UseVisualStyleBackColor = false;
            TaskPageButton.Click += TaskPageButton_Click;
            // 
            // Home
            // 
            Home.BackColor = Color.Transparent;
            Home.BackgroundImage = Properties.Resources.Home;
            Home.BackgroundImageLayout = ImageLayout.Center;
            Home.Location = new Point(73, 15);
            Home.Name = "Home";
            Home.Size = new Size(40, 40);
            Home.TabIndex = 0;
            Home.UseVisualStyleBackColor = false;
            Home.Click += Home_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(SearchButton);
            panel1.Controls.Add(AddButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 73);
            panel1.TabIndex = 1;
            // 
            // MainSection
            // 
            MainSection.Location = new Point(3, 82);
            MainSection.Name = "MainSection";
            MainSection.Size = new Size(682, 814);
            MainSection.TabIndex = 2;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.Transparent;
            SearchButton.BackgroundImage = Properties.Resources.Search;
            SearchButton.BackgroundImageLayout = ImageLayout.Center;
            SearchButton.Location = new Point(614, 16);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(40, 40);
            SearchButton.TabIndex = 2;
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.Transparent;
            AddButton.BackgroundImage = Properties.Resources.Add;
            AddButton.BackgroundImageLayout = ImageLayout.Center;
            AddButton.Location = new Point(557, 16);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(40, 40);
            AddButton.TabIndex = 1;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Logo;
            pictureBox1.Location = new Point(3, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 56);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(MainSection);
            flowLayoutPanel1.Controls.Add(NavBar);
            flowLayoutPanel1.Location = new Point(-3, -2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(685, 975);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 214, 192);
            ClientSize = new Size(682, 973);
            Controls.Add(flowLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Stretch";
            Load += MainForm_Load;
            NavBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel NavBar;
        private Button LogPageButton;
        private Button TimerPageButton;
        private Button TaskPageButton;
        private Button Home;
        private Panel panel1;
        private Button AddButton;
        private PictureBox pictureBox1;
        private Button SearchButton;
        private Panel MainSection;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}