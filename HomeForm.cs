using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StretchApp
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            int screenwidth = Screen.PrimaryScreen.Bounds.Width;
            int formwidth = this.Width;
            this.Location = new Point(screenwidth - formwidth, 0);

            //var timer = new TimerControl();
            //splitContainer2.Panel1.Controls.Add(timer);
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            Dashboard.SelectTab(0);
        }

        private void wrkLoadButton_Click(object sender, EventArgs e)
        {
            Dashboard.SelectTab(1);
        }

        private void TimerButton_Click(object sender, EventArgs e)
        {
            TimerForm timer = new TimerForm();

            timer.Show();   // open Timer
            this.Hide();    // hide current form

            timer.FormClosed += (s, args) => this.Close();
        }

        private void ReadingLButton_Click(object sender, EventArgs e)
        {
            Dashboard.SelectTab(3);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Workload_Click(object sender, EventArgs e)
        {
        }

        private void ReadingLog_Click(object sender, EventArgs e)
        {
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

    }
}
