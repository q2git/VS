using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace StampMaker
{
    public partial class Form1 : Form
    {
        private int _shape;
        private int _sWidth = 100;
        private int _sHeight = 100;
        private int _penSize = 1;

        public Form1()
        {
            InitializeComponent();
            formLoad();
        }

        private void formLoad()
        {
            //data bindings
            txtWidth.DataBindings.Add("Text", this, "sWidth");
            txtHeight.DataBindings.Add("Text", this, "sHeight");
            txtPenSize.DataBindings.Add("Text", this, "penSize");
            //txtHeight.DataBindings.Add("Text", trackBar2, "Value");
            trackBar1.DataBindings.Add("Value", this, "sWidth", false, DataSourceUpdateMode.OnPropertyChanged);
            trackBar2.DataBindings.Add("Value", this, "sHeight", false, DataSourceUpdateMode.OnPropertyChanged);
            trackBar3.DataBindings.Add("Value", this, "penSize", false, DataSourceUpdateMode.OnPropertyChanged);

            // get system fonts 
            InstalledFontCollection sysFonts = new InstalledFontCollection();
            cbFonts.DataSource = sysFonts.Families;
            //cbFonts.ValueMember = "Name";
            cbFonts.DisplayMember = "Name";
        }

        public int sWidth
        {
            get { return _sWidth; }
            set { _sWidth = value >= 100 && value <= 300 ? value : 150; }
        }

        public int sHeight
        {
            get { return _sHeight; }
            set { _sHeight = value >= 100 && value <= 300 ? value : 150; }
        }

        public int penSize
        {
            get { return _penSize; }
            set { _penSize = value >= 1 && value <= 50 ? value : 25; }
        }


        private void btnMake_Click(object sender, EventArgs e)
        {
            drawStamp();
        }

        private void drawStamp()
        {
            picStamp.Image = new Bitmap(400, 400);
            Graphics g = Graphics.FromImage(picStamp.Image);
            //Graphics g = picStamp.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;

            g.Clear(Color.White);

            Brush brush = new SolidBrush(Color.Red);//填充的颜色
            Pen pen = new Pen(Color.Red, Convert.ToSingle(_penSize));
            Font font = new Font(cbFonts.Text, (int)numFontSize.Value, FontStyle.Bold);

            int x = (picStamp.Width - _sWidth) / 2;
            int y = (picStamp.Height - _sHeight) / 2;

            switch (_shape)
            {
                case 1: //圆形印章
                    PointF center = new PointF(picStamp.Width/2, picStamp.Height/2);//中心点
                    float radiusX = _sWidth / 2F - penSize; //x半径
                    float radiusY = _sHeight/2F - penSize;  //y半径 
                    float angTop = (float)numAngT.Value;
                    float angBot = (float)numAngB.Value;
                    float minRotT = (float)numShiftX.Value / 100;
                    float minRotR = (float)numShiftY.Value / 100;

                    //
                    g.DrawEllipse(pen, center.X - radiusX, center.Y - radiusY, radiusX * 2, radiusY * 2);
                    //TODO: 可修改PaintOneText, 当 totalArcAng 为0时不旋转。
                    g.DrawString(txtMid.Text, new Font("LiSu", 20),
                        new SolidBrush(Color.Red),
                        picStamp.Width / 2 - 58,
                        picStamp.Height / 2 - 10);
                    PaintOneText(g, brush, font, center, radiusX, radiusY, angTop, minRotT, txtStamp.Text, true);
                    PaintOneText(g, brush, font, center, radiusX, radiusY, angBot, minRotR, txtBottom.Text, false);
                    break;

                case 2: // 矩形印章
                    int len = txtStamp.TextLength;
                    string txt = txtStamp.Text;

                    g.DrawRectangle(pen, x, y, _sWidth, _sHeight);
                    len = len > 4 ? 4 : len;

                    for (int i = 0; i < len; i++)
                    {
                        int xi = x + _sWidth / 2 * (i / 2) + (int)numShiftX.Value; 
                        int yi = y + _sHeight / 2 * (i % 2) + (int)numShiftY.Value;
                        g.DrawString(txt.Substring(i, 1), font, brush, xi, yi);
                    }  
                    break;
            }
            brush.Dispose(); font.Dispose(); pen.Dispose();g.Dispose();
        }

        #region copy from http://bbs.csdn.net/topics/390812699
        /// <summary>
        /// 
        /// </summary>
        /// <param name="g2"></param>
        /// <param name="font"></param>
        /// <param name="center"></param>
        /// <param name="radiusX"></param>
        /// <param name="radiusY"></param>
        /// <param name="totalArcAng">总的角跨度</param>
        /// <param name="minRat">从边线向中心的移动因子</param>
        /// <param name="text">字符串</param>
        /// <param name="top">是上边吗？</param>
        private void PaintOneText(Graphics g2, Brush brush, Font font, PointF center, float radiusX, float radiusY,//
            float totalArcAng, float minRat, string text, bool top)
        {
            double startAng = top ? -90F - totalArcAng / 2f : 90F - totalArcAng / 2f;
            double endAng = top ? -90f + totalArcAng / 2f : 90F + totalArcAng / 2f;
            int count = text.Length;
            double step = 0.5;
            int alCount = (int)Math.Ceiling(totalArcAng / step) + 1;
            double[] angArr = new double[alCount];
            double[] arcLenArr = new double[alCount];
            int num = 0;
            double accArcLen = 0.0;
            angArr[num] = startAng;
            arcLenArr[num] = accArcLen;
            num++;
            double angR = startAng * Math.PI / 180.0;
            double lastX = radiusX * Math.Cos(angR) + center.X;
            double laxtY = radiusY * Math.Sin(angR) + center.Y;
            for (double i = startAng + step; num < alCount; i += step)
            {
                angR = i * Math.PI / 180.0;
                double x = radiusX * Math.Cos(angR) + center.X, y = radiusY * Math.Sin(angR) + center.Y;
                accArcLen += Math.Sqrt((lastX - x) * (lastX - x) + (laxtY - y) * (laxtY - y));
                angArr[num] = i;
                arcLenArr[num] = accArcLen;
                lastX = x;
                laxtY = y;
                num++;
            }
            double arcPer = accArcLen / count;
            //
            for (int i = 0; i < count; i++)
            {
                double arcL = i * arcPer + arcPer / 2.0;
                //
                double ang = 0.0;
                for (int p = 0; p < arcLenArr.Length - 1; p++)
                {
                    if (arcLenArr[p] <= arcL && arcL <= arcLenArr[p + 1])
                    {
                        ang = (arcL >= ((arcLenArr[p] + arcLenArr[p + 1]) / 2.0)) ? angArr[p + 1] : angArr[p];
                        break;
                    }
                }
                angR = (ang * Math.PI / 180f);
                float x = radiusX * (float)Math.Cos(angR) + center.X, y = radiusY * (float)Math.Sin(angR) + center.Y;
                double qxang = Math.Atan2(radiusY * Math.Cos(angR), -radiusX * Math.Sin(angR)), fxang = qxang + Math.PI / 2.0;
                string c = text.Substring(top ? i : text.Length - 1 - i, 1);
                float w = g2.MeasureString(c, font).Width, h = g2.MeasureString(c, font).Height;
                if (top)
                {
                    x += h * minRat * (float)Math.Cos(fxang);
                    y += h * minRat * (float)Math.Sin(fxang);
                    x += -w / 2f * (float)Math.Cos(qxang);
                    y += -w / 2f * (float)Math.Sin(qxang);
                }
                else
                {
                    x += (h * minRat + h) * (float)Math.Cos(fxang);
                    y += (h * minRat + h) * (float)Math.Sin(fxang);
                    x += w / 2f * (float)Math.Cos(qxang);
                    y += w / 2f * (float)Math.Sin(qxang);
                }
                //
                Matrix mat = g2.Transform;
                g2.TranslateTransform(x, y);
                if (top)
                    g2.RotateTransform((float)(fxang * 180.0 / Math.PI - 90));
                else
                    g2.RotateTransform((float)(fxang * 180.0 / Math.PI + 180 - 90));
                g2.TranslateTransform(-x, -y);
                g2.DrawString(c, font, brush, x, y);
                g2.Transform = mat;
            }
        }
        #endregion

        private void rdbtChanged(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked) return;

            switch(((RadioButton)sender).Text.Substring(0, 2))
            {
                case "圆形":
                    _shape = 1;
                    break;
                case "矩形":
                    _shape = 2;
                    break;
            }
        }

        private void picStamp_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = string.Format("Stamp Maker ({0}, {1})", e.X.ToString(), e.Y.ToString());
        }

        private void numValueChanged(object sender, EventArgs e)
        {
            drawStamp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (_shape)
            {
                case 2:
                    txtStamp.Text = "大秦国玺";
                    trackBar1.Value = 300;
                    trackBar2.Value = 300;
                    trackBar3.Value = 28;
                    cbFonts.Text = "LiSu";
                    numFontSize.Value = 95;
                    numShiftX.Value = -10;
                    numShiftY.Value = 0;
                    break;

                case 1:
                    txtStamp.Text = "大秦帝国玉玺";
                    txtBottom.Text = "始皇帝专用";
                    txtMid.Text = "一统六国";
                    trackBar1.Value = 300;
                    trackBar2.Value = 200;
                    trackBar3.Value = 10;
                    cbFonts.Text = "LiSu";
                    numFontSize.Value = 30;
                    numAngT.Value = 160;
                    numAngB.Value = 90;
                    numShiftX.Value = 10;
                    numShiftY.Value = 0;
                    break;
            }


            drawStamp();
        }

        private void picStamp_MouseClick(object sender, MouseEventArgs e)
        {
            if (!(e.Button == MouseButtons.Right)) return;
            Clipboard.SetDataObject(picStamp.Image);
            MessageBox.Show("Image has been copied to Clipboard!");
        }
    }

 
}
