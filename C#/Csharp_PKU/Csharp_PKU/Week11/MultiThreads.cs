using System;
using System.Collections;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Csharp_PKU.Week11
{
    class MultiThreads : Form
    {
        private System.ComponentModel.IContainer components;

        public MultiThreads()
        {
            //
            // Windows 窗体设计器支持所必需的
            //
            InitializeComponent();

            //
            // TODO: 在 InitializeComponent 调用后添加任何构造函数代码
            //
        }

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// 设计器支持所需的方法 - 不要使用代码编辑器修改
        /// 此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 261);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 35);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(240, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 24);
            this.button3.TabIndex = 2;
            this.button3.Text = "Resume";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(144, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "Suspend";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MultiThreads
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(344, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MultiThreads";
            this.Text = "Moving Shapes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        //[STAThread]
        //static void Main()
        //{
        //    Application.Run(new Form1());
        //}

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

        private ArrayList threads = new ArrayList();
        void AddMovingObject()
        {
            MovingShape obj = new MovingShape(this.pictureBox1);
            Thread thread = new Thread(new ThreadStart(obj.run));
            thread.IsBackground = true;
            thread.Start();
            threads.Add(thread);
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            AddMovingObject();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AddMovingObject();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            foreach (Thread thread in threads)
            {
                thread.Suspend();
            }
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            foreach (Thread thread in threads)
            {
                thread.Resume();
            }
        }

    }

    public class MovingShape
    {
        bool bContinue = false;
        private int size = 60;
        private int speed = 10;
        private Color color;
        private Brush brush;
        private Pen pen;
        private int type;
        private int x, y, w, h, dx, dy;
        protected Control app;
        Random rnd = new Random();

        public MovingShape(Control app)
        {
            this.app = app;
            x = rnd.Next(app.Width);
            y = rnd.Next(app.Height);
            w = rnd.Next(size);
            h = rnd.Next(size);
            dx = rnd.Next(speed);
            dy = rnd.Next(speed);
            color = Color.FromArgb(
                rnd.Next(128, 255),
                rnd.Next(128, 255),
                rnd.Next(128, 255));
            pen = Pens.Black;
            brush = new SolidBrush(color);
            type = rnd.Next(3);
            bContinue = true;
        }

        public void run()
        {
            while (true)
            {
                x += dx;
                y += dy;
                if (x < 0 || x + w > app.Width) dx = -dx;
                if (y < 0 || y + h > app.Height) dy = -dy;
                Graphics g = app.CreateGraphics();

                switch (type)
                {
                    case 0:
                        g.FillRectangle(brush, x, y, w, h);
                        g.DrawRectangle(pen, x, y, w, h);
                        break;
                    case 1:
                        g.FillEllipse(brush, x, y, w, h);
                        g.DrawEllipse(pen, x, y, w, h);
                        break;
                    case 2:
                        g.FillPie(brush, x, y, w, h, 0.1F, 0.9F);
                        g.DrawArc(pen, x, y, w, h, 0.1F, 0.9F);
                        break;
                }
                //Console.WriteLine(x+","+y+","+w+","+h+":"+type+","+dx+","+dy);
                Thread.Sleep(130);

            }
        }
    }

}
