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

			Image offscreenImage = new Bitmap( Width, Height, g );
			Graphics offsceenGraphics = Graphics.FromImage( offscreenImage );

			Random rnd = new Random();
			for( int i=0; i<1000; i++ )
			{
				Pen pen = new Pen( Color.FromArgb( rnd.Next() ) );
				offsceenGraphics.DrawLine( pen, 
					rnd.Next( Width ), rnd.Next( Height),
					rnd.Next( Width ), rnd.Next( Height));
				pen.Dispose();
			}
			
			g.DrawImage( offscreenImage, 0, 0, Width, Height );

			offsceenGraphics.Dispose();
		}

	}
}
