using System.Drawing.Drawing2D;

namespace StretchApp.src.views
{
    public class Helper
    {
        // Rounded corners for panels/buttons/etc.
        public static void SetRoundness(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = radius * 2;

            Rectangle bounds = new Rectangle(0, 0, control.Width, control.Height);

            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            control.Region = new Region(path);
        }

        // Circular shape for buttons/icons.
        public static void MakeCircular(Control control)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, control.Width, control.Height);

            control.Region = new Region(path);
        }

        // Flat style for buttons to better fit the modern UI design.
        public static void StyleRoundedButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
            btn.UseVisualStyleBackColor = false;
        }
    }
}
