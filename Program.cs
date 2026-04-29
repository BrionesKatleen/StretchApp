using System;
using System.Windows.Forms;

namespace StretchApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShellForm());
        }
    }
    public class ShellForm : Form
    {
        public ShellForm()
        {
            Text = "Pomodoro Timer";
            MinimumSize = new System.Drawing.Size(480, 680);
            ClientSize = new System.Drawing.Size(700, 620);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.Sizable;

            var ctrl = new PomodoroControl
            {
                Dock = DockStyle.Fill
            };
            Controls.Add(ctrl);
        }
    }
}
