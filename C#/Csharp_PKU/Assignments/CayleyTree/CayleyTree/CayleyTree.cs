using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

//Cayley树
namespace CayleyTree
{
    public class CayleyTree : Form

    {
        private Graphics graphics;
        
        Random rnd = new Random();

        public CayleyTree()

        {
            this.DoubleBuffered = true;
            this.Text = "Cayley Tree";
            this.WindowState = FormWindowState.Maximized;
            this.Paint += new PaintEventHandler(this.Form_Paint);
            this.Click += new EventHandler(this.Redraw);
        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            graphics = e.Graphics;
            int x = this.Width / 2;
            int y = this.Height;

            drawTree(TS.Branch_Num, x, y, TS.Trunk_Length, -Math.PI / 2, TS.Trunk_Size);
        }

        private void Redraw(object sender, EventArgs e)
        {
            this.DoubleBuffered = TS. Branch_Num > 15 ? true : false;
            this.Invalidate();
        }

        double rand()
        {
            if (TS.Random)
                return rnd.NextDouble();

            return 0.5;
        }

        void drawTree(int n, double x0, double y0, double leng, double th, float width)
        {
            double th1 = TS.Branch_Angle; 
            double th2 = TS.Branch_Angle * TS.Coff_Ang;

            double per1 = TS.Coff_SubT;
            double per2 = TS.Coff_SubT * TS.Coff_Len; 

            if (n == 0) return; 

            double x1 = x0 + leng * Math.Cos(th);
            double x2 = x0 + leng * TS.Coff_Pos * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double y2 = y0 + leng * TS.Coff_Pos * Math.Sin(th);

            width -= TS.Trunk_Size / TS.Branch_Num; //树枝宽度递减
            Color c = TS.Color;
            switch (TS.Color_Mode)
            {
                case 1:
                    c = Color.FromArgb(
                        TS.Color_R / (TS.R ? 1 : n), 
                        TS.Color_G / (TS.G ? 1 : n), 
                        TS.Color_B / (TS.B ? 1 : n)
                        );
                    break;
                case 2:
                    c = Color.FromArgb(
                        rnd.Next(!TS.R ? TS.Color_R:255), 
                        rnd.Next(!TS.R ? TS.Color_G:255), 
                        rnd.Next(!TS.R ? TS.Color_B:255)
                        );
                    break;
            }

            drawLine(x0, y0, x2, y2, c, width);


            drawTree(n - 1, x1, y1, per1 * leng * (0.5 + rand()), th + th1 * (0.5 + rand()), width);
            
            drawTree(n - 1, x2, y2, per2 * leng * (0.5 + rand()), th - th2 * (0.5 + rand()), width);

            if (rand() > 0.6)

                drawTree(n - 1, (x1+x2)/2, (y1+y2)/2, per2 * leng * (0.5 + rand()), 
                    th - th2 * (0.5 + rand()), width);

        }

        void drawLine(double x0, double y0, double x1, double y1, Color color, float width)
        {     
            graphics.DrawLine(
                new Pen(color, width),

                (int)x0, (int)y0, (int)x1, (int)y1
                );
        }


    }

}
