namespace StretchApp.src.views;

public partial class TaskCardView : UserControl
{
    public TaskCardView(TaskModel task)
    {
        InitializeComponent();

        lblTitle.Text = task.Title;
        lblDeadline.Text = task.Deadline.ToString("MMM d, yyyy");
        lblNotes.Text = task.Notes;
        lblPriority.Text = $"{task.Priority} Priority";

        ApplyPriorityColor(task.Priority);
    }

    private void ApplyPriorityColor(string priority)
    {
        switch (priority)
        {
            case "High":
                lblPriority.BackColor = Color.FromArgb(255, 102, 102);
                break;

            case "Medium":
                lblPriority.BackColor = Color.FromArgb(255, 204, 102);
                break;

            case "Low":
                lblPriority.BackColor = Color.FromArgb(102, 153, 255);
                break;
        }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {

    }
}