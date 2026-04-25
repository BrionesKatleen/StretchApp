using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Dashboard
{
    public partial class Form1 : Form
    {
        private readonly string connectionString;

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"]?.ConnectionString
                ?? string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTasks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadTasks()
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                MessageBox.Show(
                    "No database connection string found. Add a connectionStrings entry named \"DefaultConnection\" in App.config.",
                    "Configuration",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT task_id, title, priority, status, deadline FROM Task";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvTasks.DataSource = dt;
                }

                SetupDGV(); // format after loading
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void SetupDGV()
        {
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.AllowUserToAddRows = false;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.MultiSelect = false;

            // Add buttons only once
            if (!dgvTasks.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
                editBtn.Name = "Edit";
                editBtn.HeaderText = "";
                editBtn.Text = "✏";
                editBtn.UseColumnTextForButtonValue = true;
                dgvTasks.Columns.Add(editBtn);
            }

            if (!dgvTasks.Columns.Contains("Delete"))
            {
                DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
                deleteBtn.Name = "Delete";
                deleteBtn.HeaderText = "";
                deleteBtn.Text = "🗑";
                deleteBtn.UseColumnTextForButtonValue = true;
                dgvTasks.Columns.Add(deleteBtn);
            }
        }
        
    }
}
