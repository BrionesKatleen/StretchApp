namespace StretchApp
{
    partial class UserControl2
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
            textBox1 = new TextBox();
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            linkLabel2 = new LinkLabel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            textBox2 = new TextBox();
            label2 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            textBox3 = new TextBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            flowLayoutPanel4 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(19, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(464, 34);
            textBox1.TabIndex = 0;
            textBox1.Text = "Add Reading Material";
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(flowLayoutPanel3);
            panel1.Controls.Add(flowLayoutPanel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(19, 98);
            panel1.Name = "panel1";
            panel1.Size = new Size(464, 379);
            panel1.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.White;
            linkLabel1.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(80, 15);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(52, 18);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cancel";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLabel2);
            panel2.Controls.Add(linkLabel1);
            panel2.Controls.Add(richTextBox2);
            panel2.Controls.Add(richTextBox1);
            panel2.Location = new Point(19, 493);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 50);
            panel2.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(220, 47);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.SaddleBrown;
            richTextBox2.ForeColor = Color.SaddleBrown;
            richTextBox2.Location = new Point(244, 0);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(220, 47);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.SaddleBrown;
            linkLabel2.Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkColor = Color.White;
            linkLabel2.Location = new Point(322, 15);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(68, 18);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Add Task";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 0);
            label1.Name = "label1";
            label1.Size = new Size(123, 17);
            label1.TabIndex = 0;
            label1.Text = "Book/Material Title*";
            label1.Click += label1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.AntiqueWhite;
            flowLayoutPanel1.Controls.Add(textBox2);
            flowLayoutPanel1.Location = new Point(13, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(430, 35);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.AntiqueWhite;
            textBox2.ForeColor = Color.Tan;
            textBox2.Location = new Point(3, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 0;
            textBox2.Text = "Enter Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 86);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 2;
            label2.Text = "Subject*";
            label2.Click += label2_Click_1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.AntiqueWhite;
            flowLayoutPanel2.Controls.Add(textBox3);
            flowLayoutPanel2.Location = new Point(13, 120);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(430, 35);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.AntiqueWhite;
            textBox3.ForeColor = Color.Tan;
            textBox3.Location = new Point(3, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 27);
            textBox3.TabIndex = 0;
            textBox3.Text = "e.g. Computer Science";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = Color.AntiqueWhite;
            flowLayoutPanel3.Controls.Add(textBox4);
            flowLayoutPanel3.Location = new Point(13, 203);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(430, 35);
            flowLayoutPanel3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.AntiqueWhite;
            textBox4.ForeColor = Color.Tan;
            textBox4.Location = new Point(3, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(157, 27);
            textBox4.TabIndex = 0;
            textBox4.Text = "e.g. Computer Science";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(13, 171);
            label3.Name = "label3";
            label3.Size = new Size(133, 17);
            label3.TabIndex = 5;
            label3.Text = "Number of Chapters*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 250);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 6;
            label4.Text = "Notes*";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.AntiqueWhite;
            flowLayoutPanel4.Location = new Point(13, 270);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(430, 93);
            flowLayoutPanel4.TabIndex = 7;
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Name = "UserControl2";
            Size = new Size(512, 555);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private LinkLabel linkLabel1;
        private Panel panel2;
        private RichTextBox richTextBox2;
        private LinkLabel linkLabel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox textBox2;
        private FlowLayoutPanel flowLayoutPanel2;
        private TextBox textBox3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel3;
        private TextBox textBox4;
    }
}
