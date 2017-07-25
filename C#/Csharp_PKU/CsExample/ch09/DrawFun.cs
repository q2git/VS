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
			// TODO: �� InitializeComponent ���ú�����κι��캯������
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

			PointF [] cur1 = new PointF[ 150 ];
			for( int i=0; i<cur1.Length; i++ )
			{
				double x = (double)i/5;
				double y = Math.Sin(x) * 3 + Math.Cos( 3*x );
				cur1[i] = new PointF( (float)i, (float)( y*10+100 ));
			}
			g.DrawLines( Pens.Blue, cur1 );

			PointF [] cur2 = new PointF[ 100 ];
			for( int i=0; i<cur2.Length; i++ )
			{
				double theta = Math.PI/50 * i;
				double r = Math.Cos( theta * 16 );
				cur2[i] = new PointF(
					(float)( r * Math.Cos( theta ) *50 + 230 ),
					(float)( r * Math.Sin( theta ) *50 + 100 ) );
			}
			g.DrawLines( Pens.Blue, cur2 );
		}

	}
}
