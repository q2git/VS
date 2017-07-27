using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;

namespace TestWin
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú������κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(304, 185);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

		}
		#endregion

		/// <summary>
		/// Ӧ�ó��������ڵ㡣
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			float x = g.VisibleClipBounds.Width;
			float y = g.VisibleClipBounds.Height;
			PointF[] pts = 
			{ 
				new PointF(0,0), new PointF(x/2,0), 
				new PointF(x/2,y/2), new PointF(0,y/2)
			};
			Pen pen = new Pen(Color.Blue, 1.0F);
			g.ScaleTransform( 0.8F, 0.8F );
			g.TranslateTransform(x/2,y/2+20);
			for( int i=0; i<36; i++)
			{
				g.DrawBeziers(pen, pts );
				g.DrawRectangle( pen, -x/12, -y/12, x/6, y/6 );
				g.DrawEllipse( pen, -x/4, -y/3, x/2, y*2/3 );
				g.RotateTransform(10);
			}
		}

	}
}