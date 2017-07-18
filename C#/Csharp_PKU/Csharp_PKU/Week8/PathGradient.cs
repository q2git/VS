using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Csharp_PKU.Week8 
{
    class PathGradient : Form
    {
        public PathGradient()
        {
            this.Paint += PathGradient_Paint;
        }

        private void PathGradient_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath gp = new GraphicsPath(FillMode.Winding);
            gp.AddString(
            "字体轮廓",
            new FontFamily("Arial"),
            (int)FontStyle.Regular,
            80,
            new PointF(10, 20),
            new StringFormat());
            Brush brush = new LinearGradientBrush(
            new PointF(0, 0), new PointF(Width, Height),
            Color.Red, Color.Yellow);
            e.Graphics.DrawPath(Pens.Black, gp);
            e.Graphics.FillPath(brush, gp);
        }

    }
}
