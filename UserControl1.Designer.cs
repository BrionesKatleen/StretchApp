namespace StretchApp
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            label1 = new Label();
            button1 = new Button();
            ReadingLog = new TextBox();
            textBox1 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            progressBar1 = new ProgressBar();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            progressBar2 = new ProgressBar();
            label8 = new Label();
            label9 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Container;
            button1.Location = new Point(3, 92);
            button1.Name = "button1";
            button1.Size = new Size(234, 44);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ReadingLog
            // 
            ReadingLog.AccessibleRole = AccessibleRole.TitleBar;
            ReadingLog.BackColor = Color.FromArgb(232, 214, 192);
            ReadingLog.BorderStyle = BorderStyle.FixedSingle;
            ReadingLog.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReadingLog.Location = new Point(3, 17);
            ReadingLog.Margin = new Padding(0);
            ReadingLog.Name = "ReadingLog";
            ReadingLog.Size = new Size(647, 27);
            ReadingLog.TabIndex = 3;
            ReadingLog.Text = "Reading Log";
            ReadingLog.TextChanged += ReadingLog_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(3, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(647, 28);
            textBox1.TabIndex = 4;
            textBox1.Text = "Track your study materials and reading progress";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(50, 167);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 412);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(progressBar1);
            panel1.ForeColor = Color.Chartreuse;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 112);
            panel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(17, 93);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(556, 11);
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Info;
            label2.Location = new Point(17, 70);
            label2.Name = "label2";
            label2.Size = new Size(133, 20);
            label2.TabIndex = 1;
            label2.Text = "0 out of 5 chapters";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Info;
            label3.Location = new Point(17, 11);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 2;
            label3.Text = "Introduction to";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Info;
            label4.Location = new Point(17, 29);
            label4.Name = "label4";
            label4.Size = new Size(113, 17);
            label4.TabIndex = 2;
            label4.Text = "Computer Science";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SeaShell;
            pictureBox2.BackgroundImage = Properties.Resources.trash__1_2;
            pictureBox2.Location = new Point(558, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 24);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaShell;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(527, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 24);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.White;
            flowLayoutPanel2.BackgroundImageLayout = ImageLayout.Center;
            flowLayoutPanel2.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel2.Controls.Add(panel2);
            flowLayoutPanel2.Location = new Point(50, 605);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(600, 412);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SaddleBrown;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(progressBar2);
            panel2.ForeColor = Color.Chartreuse;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(595, 112);
            panel2.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.SeaShell;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(527, 29);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 24);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.SeaShell;
            pictureBox4.BackgroundImage = Properties.Resources.trash__1_2;
            pictureBox4.Location = new Point(558, 29);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 24);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Info;
            label5.Location = new Point(17, 70);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 1;
            label5.Text = "0 out of 5 chapters";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Info;
            label6.Location = new Point(17, 29);
            label6.Name = "label6";
            label6.Size = new Size(113, 17);
            label6.TabIndex = 2;
            label6.Text = "Computer Science";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Info;
            label7.Location = new Point(17, 11);
            label7.Name = "label7";
            label7.Size = new Size(120, 18);
            label7.TabIndex = 2;
            label7.Text = "Introduction to";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(17, 93);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(556, 11);
            progressBar2.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Info;
            label8.Location = new Point(544, 70);
            label8.Name = "label8";
            label8.Size = new Size(29, 20);
            label8.TabIndex = 4;
            label8.Text = "0%";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Info;
            label9.Location = new Point(544, 70);
            label9.Name = "label9";
            label9.Size = new Size(29, 20);
            label9.TabIndex = 5;
            label9.Text = "0%";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(232, 214, 192);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(textBox1);
            Controls.Add(ReadingLog);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(700, 1020);
            Load += UserControl1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox ReadingLog;
        private TextBox textBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private ProgressBar progressBar1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Label label9;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ProgressBar progressBar2;
    }
}
