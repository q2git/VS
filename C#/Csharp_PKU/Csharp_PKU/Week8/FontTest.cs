using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Csharp_PKU.Week8
{
    class FontTest : Form
    {
        public FontTest()
        {
            this.Paint += FontTest_Paint;
        }

        private void FontTest_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            FontFamily[] families = FontFamily.GetFamilies(e.Graphics);
            Font font;
            string familyString;
            float spacing = 0;
            foreach (FontFamily family in families)
            {
                try
                {
                    font = new Font(family, 16, FontStyle.Bold);
                    familyString = "This is the " + family.Name + "family.";
                    e.Graphics.DrawString(
                    familyString,
                    font,
                    Brushes.Black,
                    new PointF(0, spacing));
                    spacing += font.Height + 5;
                }
                catch
                { }
            }
        }
    }
}
