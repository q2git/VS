using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace Csharp_PKU.Week8
{
    class BrushTest : Form
    {

        public BrushTest()
        {
            this.Paint += BrushTest_Paint;
        }

        private void BrushTest_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point point = new Point(10, 10);
            Rectangle rect = new Rectangle(10, 10, 20, 150);
            Point off = new Point(30, 0);
            Brush brush;
            brush = Brushes.Azure;
            rect.Offset(off); g.FillRectangle(brush, rect);
            brush = SystemBrushes.Desktop;
            rect.Offset(off); g.FillRectangle(brush, rect);
            brush = new SolidBrush(Color.FromArgb(100, 255, 0, 0));
            rect.Offset(off); g.FillRectangle(brush, rect);
            Image bm = Bitmap.FromFile(@"Week7\folder.bmp");
            brush = new TextureBrush(bm);
            rect.Offset(off); g.FillRectangle(brush, rect);
            brush = new HatchBrush(
            HatchStyle.Vertical,
            Color.ForestGreen,
            Color.Honeydew);
            rect.Offset(off); g.FillRectangle(brush, rect);
            brush = new LinearGradientBrush(
            new PointF(50, 50), new PointF(200, 200),
            Color.Red, Color.Yellow);
            rect.Offset(off); g.FillRectangle(brush, rect);
        }
    }
}
