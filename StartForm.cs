namespace StretchApp;

public partial class StartForm : Form
{
    public StartForm()
    {
        InitializeComponent();
    }

    private void StartForm_Load(object sender, EventArgs e)
    {
        int screenwidth = Screen.PrimaryScreen.Bounds.Width;
        int formwidth = this.Width;
        this.Location = new Point(screenwidth - formwidth, 0);
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        //HomeForm home = new HomeForm();
        MainForm main = new MainForm();
        main.Show();   // then show Form2

        this.Hide();   // hide 

        main.FormClosed += (s, args) => this.Close();
    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }
}
