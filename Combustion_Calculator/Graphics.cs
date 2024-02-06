using System.Drawing.Drawing2D;

namespace Combustion_Calculator
{
    internal class Graphics
    {
        public static void DrawRoundedCorners(Control control, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(new Rectangle(0, 0, radius * 2, radius * 2), 180, 90);
                path.AddArc(new Rectangle(control.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
                path.AddArc(new Rectangle(control.Width - radius * 2, control.Height - radius * 2, radius * 2, radius * 2), 0, 90);
                path.AddArc(new Rectangle(0, control.Height - radius * 2, radius * 2, radius * 2), 90, 90);
                path.CloseFigure();
                control.Region = new Region(path);
            }
        }

        public static void DrawRoundedCorners(Form form, int radius)
        {
            form.FormBorderStyle = FormBorderStyle.None; //It Is Necessary//
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(new Rectangle(0, 0, radius * 2, radius * 2), 180, 90);
                path.AddArc(new Rectangle(form.Width - radius * 2, 0, radius * 2, radius * 2), 270, 90);
                path.AddArc(new Rectangle(form.Width - radius * 2, form.Height - radius * 2, radius * 2, radius * 2), 0, 90);
                path.AddArc(new Rectangle(0, form.Height - radius * 2, radius * 2, radius * 2), 90, 90);
                path.CloseFigure();
                form.Region = new Region(path);
            }
        }

    }
}
