using StretchApp.src.views;


namespace StretchApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            int screenwidth = Screen.PrimaryScreen.Bounds.Width;
            int formwidth = this.Width;

            this.Location = new Point(screenwidth - formwidth, 0);

            ShowHomePage();
        }

        private void LoadPage(UserControl page)
        {
            page.Dock = DockStyle.Fill;

            MainSection.Controls.Clear();
            MainSection.Controls.Add(page);
        }

        private void ShowHomePage()
        {
            LoadPage(new HomeView());
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void TimerPageButton_Click(object sender, EventArgs e)
        {
            LoadPage(new StretchApp.src.views.TimerView());
        }

        private void TaskPageButton_Click(object sender, EventArgs e)
        {
            LoadPage(new TaskBoardView());
        }

        private void LogPageButton_Click(object sender, EventArgs e)
        {
            // Future Log Page
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
        }
    }
}