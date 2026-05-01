using StretchApp.src.controllers;

namespace StretchApp.src.views;

public partial class TaskBoardView : UserControl
{
    private readonly TaskController _controller = new();

    private List<TaskModel> _allTasks = new();

    public TaskBoardView()
    {
        InitializeComponent();

        LoadTasks();

        txtSearch.TextChanged += TxtSearch_TextChanged;

        btnAll.Click += (_, __) => FilterTasks("All");
        btnHigh.Click += (_, __) => FilterTasks("High");
        btnMedium.Click += (_, __) => FilterTasks("Medium");
        btnLow.Click += (_, __) => FilterTasks("Low");

        btnAddTask.Click += BtnAddTask_Click;
    }

    private void LoadTasks()
    {
        _allTasks = _controller.GetTasks();
        RenderTasks(_allTasks);
    }

    private void RenderTasks(List<TaskModel> tasks)
    {
        flowTasks.Controls.Clear();

        foreach (var task in tasks)
        {
            flowTasks.Controls.Add(new TaskCardView(task));
        }
    }

    private void TxtSearch_TextChanged(object sender, EventArgs e)
    {
        string keyword = txtSearch.Text.ToLower();

        var filtered = _allTasks
            .Where(t =>
                t.Title.ToLower().Contains(keyword) ||
                t.Notes.ToLower().Contains(keyword))
            .ToList();

        RenderTasks(filtered);
    }

    private void FilterTasks(string priority)
    {
        if (priority == "All")
        {
            RenderTasks(_allTasks);
            return;
        }

        var filtered = _allTasks
            .Where(t => t.Priority == priority)
            .ToList();

        RenderTasks(filtered);
    }

    private void BtnAddTask_Click(object sender, EventArgs e)
    {
        Form modal = new Form
        {
            Size = new Size(540, 700),
            StartPosition = FormStartPosition.CenterScreen,
            FormBorderStyle = FormBorderStyle.FixedDialog
        };

        AddTaskView form = new();

        form.Dock = DockStyle.Fill;

        form.TaskAdded += () =>
        {
            LoadTasks();
            modal.Close();
        };

        form.CancelRequested += () =>
        {
            modal.Close();
        };

        modal.Controls.Add(form);
        modal.ShowDialog();
    }

}
