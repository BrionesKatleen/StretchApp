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
        }
    }
}
