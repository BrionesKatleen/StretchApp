using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
        }
        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void TaskPageButton_Click(object sender, EventArgs e)
        {
        }

        private void TimerPageButton_Click(object sender, EventArgs e)
        {

        }

        private void LogPageButton_Click(object sender, EventArgs e)
        {

        }
    }
}