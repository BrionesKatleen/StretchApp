namespace StretchApp.src.views;

partial class TaskBoardView
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    private void InitializeComponent()
    {
        lblHeader = new Label();
        lblSubHeader = new Label();
        txtSearch = new TextBox();
        btnAll = new Button();
        btnHigh = new Button();
        btnMedium = new Button();
        btnLow = new Button();
        btnAddTask = new Button();
        flowTasks = new FlowLayoutPanel();
        SuspendLayout();
        // 
        // lblHeader
        // 
        lblHeader.AutoSize = true;
        lblHeader.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
        lblHeader.ForeColor = Color.FromArgb(40, 40, 40);
        lblHeader.Location = new Point(15, 15);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new Size(234, 26);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "Workload Dashboard";
        // 
        // lblSubHeader
        // 
        lblSubHeader.AutoSize = true;
        lblSubHeader.Font = new Font("Microsoft Sans Serif", 9F);
        lblSubHeader.ForeColor = Color.DimGray;
        lblSubHeader.Location = new Point(17, 45);
        lblSubHeader.Name = "lblSubHeader";
        lblSubHeader.Size = new Size(318, 18);
        lblSubHeader.TabIndex = 1;
        lblSubHeader.Text = "Manage your academic tasks and assignments";
        // 
        // txtSearch
        // 
        txtSearch.Font = new Font("Microsoft Sans Serif", 9F);
        txtSearch.Location = new Point(15, 85);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search tasks...";
        txtSearch.Size = new Size(210, 24);
        txtSearch.TabIndex = 2;
        // 
        // btnAll
        // 
        btnAll.BackColor = Color.FromArgb(117, 86, 84);
        btnAll.FlatAppearance.BorderSize = 0;
        btnAll.FlatStyle = FlatStyle.Flat;
        btnAll.ForeColor = Color.White;
        btnAll.Location = new Point(235, 85);
        btnAll.Name = "btnAll";
        btnAll.Size = new Size(55, 30);
        btnAll.TabIndex = 3;
        btnAll.Text = "All";
        btnAll.UseVisualStyleBackColor = false;
        // 
        // btnHigh
        // 
        btnHigh.BackColor = Color.White;
        btnHigh.FlatAppearance.BorderSize = 0;
        btnHigh.FlatStyle = FlatStyle.Flat;
        btnHigh.Location = new Point(300, 85);
        btnHigh.Name = "btnHigh";
        btnHigh.Size = new Size(70, 30);
        btnHigh.TabIndex = 4;
        btnHigh.Text = "High";
        btnHigh.UseVisualStyleBackColor = false;
        // 
        // btnMedium
        // 
        btnMedium.BackColor = Color.White;
        btnMedium.FlatAppearance.BorderSize = 0;
        btnMedium.FlatStyle = FlatStyle.Flat;
        btnMedium.Location = new Point(380, 85);
        btnMedium.Name = "btnMedium";
        btnMedium.Size = new Size(85, 30);
        btnMedium.TabIndex = 5;
        btnMedium.Text = "Medium";
        btnMedium.UseVisualStyleBackColor = false;
        // 
        // btnLow
        // 
        btnLow.BackColor = Color.White;
        btnLow.FlatAppearance.BorderSize = 0;
        btnLow.FlatStyle = FlatStyle.Flat;
        btnLow.Location = new Point(475, 85);
        btnLow.Name = "btnLow";
        btnLow.Size = new Size(70, 30);
        btnLow.TabIndex = 6;
        btnLow.Text = "Low";
        btnLow.UseVisualStyleBackColor = false;
        // 
        // btnAddTask
        // 
        btnAddTask.BackColor = Color.FromArgb(117, 86, 84);
        btnAddTask.FlatAppearance.BorderSize = 0;
        btnAddTask.FlatStyle = FlatStyle.Flat;
        btnAddTask.ForeColor = Color.White;
        btnAddTask.Location = new Point(555, 85);
        btnAddTask.Name = "btnAddTask";
        btnAddTask.Size = new Size(120, 30);
        btnAddTask.TabIndex = 7;
        btnAddTask.Text = "+ Add Task";
        btnAddTask.UseVisualStyleBackColor = false;
        // 
        // flowTasks
        // 
        flowTasks.AutoScroll = true;
        flowTasks.FlowDirection = FlowDirection.TopDown;
        flowTasks.Location = new Point(15, 135);
        flowTasks.Name = "flowTasks";
        flowTasks.Size = new Size(660, 760);
        flowTasks.TabIndex = 8;
        flowTasks.WrapContents = false;
        // 
        // TaskBoardView
        // 
        BackColor = Color.FromArgb(232, 214, 192);
        Controls.Add(lblHeader);
        Controls.Add(lblSubHeader);
        Controls.Add(txtSearch);
        Controls.Add(btnAll);
        Controls.Add(btnHigh);
        Controls.Add(btnMedium);
        Controls.Add(btnLow);
        Controls.Add(btnAddTask);
        Controls.Add(flowTasks);
        Font = new Font("Microsoft Sans Serif", 9F);
        Name = "TaskBoardView";
        Size = new Size(700, 920);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblHeader;
    private Label lblSubHeader;

    private TextBox txtSearch;

    private Button btnAll;
    private Button btnHigh;
    private Button btnMedium;
    private Button btnLow;
    private Button btnAddTask;

    private FlowLayoutPanel flowTasks;
}
