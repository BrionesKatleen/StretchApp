namespace Dashboard
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtSearch = new TextBox();
            btnAll = new Button();
            btnHigh = new Button();
            btnMedium = new Button();
            btnLow = new Button();
            btnAddTask = new Button();
            panel2 = new Panel();
            dgvTasks = new DataGridView();
            vScrollBar1 = new VScrollBar();
            panel1 = new Panel();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.SandyBrown;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(txtSearch);
            flowLayoutPanel1.Controls.Add(btnAll);
            flowLayoutPanel1.Controls.Add(btnHigh);
            flowLayoutPanel1.Controls.Add(btnMedium);
            flowLayoutPanel1.Controls.Add(btnLow);
            flowLayoutPanel1.Controls.Add(btnAddTask);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(668, 37);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(3, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 0;
            txtSearch.Text = "Search Task...";
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.SteelBlue;
            btnAll.Location = new Point(134, 3);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(56, 29);
            btnAll.TabIndex = 1;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            // 
            // btnHigh
            // 
            btnHigh.Location = new Point(196, 3);
            btnHigh.Name = "btnHigh";
            btnHigh.Size = new Size(94, 29);
            btnHigh.TabIndex = 2;
            btnHigh.Text = "High";
            btnHigh.UseVisualStyleBackColor = true;
            // 
            // btnMedium
            // 
            btnMedium.Location = new Point(296, 3);
            btnMedium.Name = "btnMedium";
            btnMedium.Size = new Size(94, 29);
            btnMedium.TabIndex = 3;
            btnMedium.Text = "Medium";
            btnMedium.UseVisualStyleBackColor = true;
            // 
            // btnLow
            // 
            btnLow.Location = new Point(396, 3);
            btnLow.Name = "btnLow";
            btnLow.Size = new Size(94, 29);
            btnLow.TabIndex = 4;
            btnLow.Text = "Low";
            btnLow.UseVisualStyleBackColor = true;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.Yellow;
            btnAddTask.ForeColor = Color.Black;
            btnAddTask.Location = new Point(496, 3);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(131, 29);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = " +  Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SandyBrown;
            panel2.Controls.Add(dgvTasks);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(668, 370);
            panel2.TabIndex = 1;
            // 
            // dgvTasks
            // 
            dgvTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvTasks.BackgroundColor = Color.White;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(0, 0);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(668, 370);
            dgvTasks.TabIndex = 0;
            dgvTasks.CellContentClick += dgvTasks_CellContentClick;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(658, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(10, 217);
            vScrollBar1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PeachPuff;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(vScrollBar1);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(672, 374);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            ClientSize = new Size(696, 415);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox txtSearch;
        private Button btnAll;
        private Button btnHigh;
        private Button btnMedium;
        private Button btnLow;
        private Button btnAddTask;
        private Panel panel2;
        private DataGridView dgvTasks;
        private VScrollBar vScrollBar1;
        private Panel panel1;
    }
}
