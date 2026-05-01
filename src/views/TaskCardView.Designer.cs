namespace StretchApp.src.views;

partial class TaskCardView
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
        chkCompleted = new CheckBox();
        lblTitle = new Label();
        lblPriority = new Label();
        lblDeadline = new Label();
        lblNotes = new Label();
        btnEdit = new Button();
        btnDelete = new Button();
        SuspendLayout();
        // 
        // chkCompleted
        // 
        chkCompleted.AutoSize = true;
        chkCompleted.Location = new Point(15, 18);
        chkCompleted.Name = "chkCompleted";
        chkCompleted.Size = new Size(18, 17);
        chkCompleted.TabIndex = 0;
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        lblTitle.ForeColor = Color.FromArgb(40, 40, 40);
        lblTitle.Location = new Point(45, 14);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(141, 25);
        lblTitle.TabIndex = 1;
        lblTitle.Text = "Task Title Here";
        // 
        // lblPriority
        // 
        lblPriority.BackColor = Color.IndianRed;
        lblPriority.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
        lblPriority.ForeColor = Color.White;
        lblPriority.Location = new Point(45, 48);
        lblPriority.Name = "lblPriority";
        lblPriority.Size = new Size(95, 24);
        lblPriority.TabIndex = 2;
        lblPriority.Text = "High Priority";
        lblPriority.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblDeadline
        // 
        lblDeadline.AutoSize = true;
        lblDeadline.Font = new Font("Segoe UI", 8.5F);
        lblDeadline.ForeColor = Color.DimGray;
        lblDeadline.Location = new Point(150, 51);
        lblDeadline.Name = "lblDeadline";
        lblDeadline.Size = new Size(84, 20);
        lblDeadline.TabIndex = 3;
        lblDeadline.Text = "Apr 4, 2026";
        // 
        // lblNotes
        // 
        lblNotes.AutoSize = true;
        lblNotes.Font = new Font("Segoe UI", 8.5F);
        lblNotes.ForeColor = Color.FromArgb(90, 90, 90);
        lblNotes.Location = new Point(45, 82);
        lblNotes.Name = "lblNotes";
        lblNotes.Size = new Size(226, 20);
        lblNotes.TabIndex = 5;
        lblNotes.Text = "Include notes or description here";
        // 
        // btnEdit
        // 
        btnEdit.BackColor = Color.Transparent;
        btnEdit.Cursor = Cursors.Hand;
        btnEdit.FlatAppearance.BorderSize = 0;
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnEdit.ForeColor = Color.RoyalBlue;
        btnEdit.Location = new Point(585, 14);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(32, 32);
        btnEdit.TabIndex = 6;
        btnEdit.Text = "✎";
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnDelete
        // 
        btnDelete.BackColor = Color.Transparent;
        btnDelete.Cursor = Cursors.Hand;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnDelete.ForeColor = Color.IndianRed;
        btnDelete.Location = new Point(623, 14);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(32, 32);
        btnDelete.TabIndex = 7;
        btnDelete.Text = "🗑";
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // TaskCardView
        // 
        BackColor = Color.FromArgb(245, 236, 227);
        Controls.Add(chkCompleted);
        Controls.Add(lblTitle);
        Controls.Add(lblPriority);
        Controls.Add(lblDeadline);
        Controls.Add(lblNotes);
        Controls.Add(btnEdit);
        Controls.Add(btnDelete);
        Font = new Font("Microsoft Sans Serif", 9F);
        Margin = new Padding(8);
        Name = "TaskCardView";
        Padding = new Padding(15);
        Size = new Size(670, 115);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckBox chkCompleted;
    public Label lblTitle;
    public Label lblPriority;
    public Label lblDeadline;
    public Label lblNotes;
    public Button btnEdit;
    public Button btnDelete;
}
