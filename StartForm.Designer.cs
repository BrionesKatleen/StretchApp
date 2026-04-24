namespace StretchApp;

partial class StartForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
        panel1 = new Panel();
        button1 = new Button();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = SystemColors.ButtonFace;
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label1);
        panel1.Controls.Add(pictureBox1);
        panel1.Location = new Point(10, 11);
        panel1.Name = "panel1";
        panel1.Size = new Size(660, 950);
        panel1.TabIndex = 0;
        // 
        // button1
        // 
        button1.Font = new Font("Script MT Bold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
        button1.Location = new Point(262, 580);
        button1.Name = "button1";
        button1.Size = new Size(119, 36);
        button1.TabIndex = 2;
        button1.Text = "Get started →";
        button1.TextImageRelation = TextImageRelation.ImageAboveText;
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.BackColor = Color.Transparent;
        label1.Font = new Font("Pristina", 70F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.ForeColor = SystemColors.ActiveCaptionText;
        label1.Location = new Point(100, 454);
        label1.Margin = new Padding(0);
        label1.Name = "label1";
        label1.Size = new Size(349, 107);
        label1.TabIndex = 1;
        label1.Text = "Stretch";
        label1.Click += label1_Click;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = Color.Transparent;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(348, 318);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(219, 280);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        pictureBox1.Click += pictureBox1_Click;
        // 
        // StartForm
        // 
        AutoScaleDimensions = new SizeF(7F, 18F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(682, 973);
        Controls.Add(panel1);
        Font = new Font("Pristina", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "StartForm";
        StartPosition = FormStartPosition.Manual;
        Text = "Stretch";
        Load += StartForm_Load;
        panel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private PictureBox pictureBox1;
    private Button button1;
}
