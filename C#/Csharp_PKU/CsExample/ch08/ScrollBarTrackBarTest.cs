using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestWin
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.HScrollBar hScrollBar1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.TrackBar trackBar3;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			this.SuspendLayout();
			// 
			// hScrollBar1
			// 
			this.hScrollBar1.Location = new System.Drawing.Point(32, 56);
			this.hScrollBar1.Name = "hScrollBar1";
			this.hScrollBar1.TabIndex = 0;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(160, 32);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.TabIndex = 1;
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(216, 16);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.TabIndex = 2;
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(216, 88);
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.TabIndex = 2;
			this.trackBar2.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
			// 
			// trackBar3
			// 
			this.trackBar3.Location = new System.Drawing.Point(216, 48);
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.TabIndex = 2;
			this.trackBar3.TickStyle = System.Windows.Forms.TickStyle.Both;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(352, 149);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.trackBar1,
																		  this.vScrollBar1,
																		  this.hScrollBar1,
																		  this.trackBar2,
																		  this.trackBar3});
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			this.ResumeLayout(false);

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


	}
}
