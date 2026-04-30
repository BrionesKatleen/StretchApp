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
        // TaskBoardView
        //
        BackColor = Color.FromArgb(232, 214, 192);
        Size = new Size(700, 920);

        //
        // lblHeader
        //
        lblHeader.AutoSize = true;
        lblHeader.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        lblHeader.ForeColor = Color.FromArgb(40, 40, 40);
        lblHeader.Location = new Point(15, 15);
        lblHeader.Text = "Workload Dashboard";

        //
        // lblSubHeader
        //
        lblSubHeader.AutoSize = true;
        lblSubHeader.Font = new Font("Segoe UI", 9F);
        lblSubHeader.ForeColor = Color.DimGray;
        lblSubHeader.Location = new Point(17, 45);
        lblSubHeader.Text = "Manage your academic tasks and assignments";

        //
        // txtSearch
        //
        txtSearch.Location = new Point(15, 85);
        txtSearch.Size = new Size(210, 30);
        txtSearch.Font = new Font("Segoe UI", 9F);
        txtSearch.Name = "txtSearch";
        txtSearch.PlaceholderText = "Search tasks...";

        //
        // btnAll
        //
        btnAll.Location = new Point(235, 85);
        btnAll.Size = new Size(55, 30);
        btnAll.Text = "All";
        btnAll.BackColor = Color.FromArgb(117, 86, 84);
        btnAll.ForeColor = Color.White;
        btnAll.FlatStyle = FlatStyle.Flat;
        btnAll.FlatAppearance.BorderSize = 0;

        //
        // btnHigh
        //
        btnHigh.Location = new Point(300, 85);
        btnHigh.Size = new Size(70, 30);
        btnHigh.Text = "High";
        btnHigh.BackColor = Color.White;
        btnHigh.FlatStyle = FlatStyle.Flat;
        btnHigh.FlatAppearance.BorderSize = 0;

        //
        // btnMedium
        //
        btnMedium.Location = new Point(380, 85);
        btnMedium.Size = new Size(85, 30);
        btnMedium.Text = "Medium";
        btnMedium.BackColor = Color.White;
        btnMedium.FlatStyle = FlatStyle.Flat;
        btnMedium.FlatAppearance.BorderSize = 0;

        //
        // btnLow
        //
        btnLow.Location = new Point(475, 85);
        btnLow.Size = new Size(70, 30);
        btnLow.Text = "Low";
        btnLow.BackColor = Color.White;
        btnLow.FlatStyle = FlatStyle.Flat;
        btnLow.FlatAppearance.BorderSize = 0;

        //
        // btnAddTask
        //
        btnAddTask.Location = new Point(555, 85);
        btnAddTask.Size = new Size(120, 30);
        btnAddTask.Text = "+ Add Task";
        btnAddTask.BackColor = Color.FromArgb(117, 86, 84);
        btnAddTask.ForeColor = Color.White;
        btnAddTask.FlatStyle = FlatStyle.Flat;
        btnAddTask.FlatAppearance.BorderSize = 0;

        //
        // flowTasks
        //
        flowTasks.Location = new Point(15, 135);
        flowTasks.Size = new Size(660, 760);
        flowTasks.AutoScroll = true;
        flowTasks.FlowDirection = FlowDirection.TopDown;
        flowTasks.WrapContents = false;
        flowTasks.Name = "flowTasks";
        flowTasks.Padding = new Padding(0);

        //
        // Add Controls
        //
        Controls.Add(lblHeader);
        Controls.Add(lblSubHeader);
        Controls.Add(txtSearch);

        Controls.Add(btnAll);
        Controls.Add(btnHigh);
        Controls.Add(btnMedium);
        Controls.Add(btnLow);
        Controls.Add(btnAddTask);

        Controls.Add(flowTasks);

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
