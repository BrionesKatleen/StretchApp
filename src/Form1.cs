using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblCreatedAt.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || cmbPriority.SelectedIndex == -1 || cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=StretchDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "INSERT INTO Task (title, priority, status, deadline, created_at, notes) " +
                               "VALUES (@title, @priority, @status, @deadline, @created_at, @notes)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                cmd.Parameters.AddWithValue("@priority", cmbPriority.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem?.ToString());
                cmd.Parameters.AddWithValue("@deadline", dtpDeadline.Value);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                cmd.Parameters.AddWithValue("@notes", txtNotes.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Task Created Successfully!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtTitle.Clear();
            cmbPriority.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            dtpDeadline.Value = DateTime.Now;
            txtNotes.Clear();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
