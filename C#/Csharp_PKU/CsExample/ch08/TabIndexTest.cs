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
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 24);
			this.button1.Name = "button1";
			this.button1.TabIndex = 0;
			this.button1.Text = "button1";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 24);
			this.button2.Name = "button2";
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(32, 72);
			this.button3.Name = "button3";
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(168, 72);
			this.button4.Name = "button4";
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 128);
			this.label1.Name = "label1";
			this.label1.TabIndex = 4;
			this.label1.Text = "l&abel1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(168, 128);
			this.label2.Name = "label2";
			this.label2.TabIndex = 5;
			this.label2.Text = "la&bel2";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(32, 168);
			this.textBox1.Name = "textBox1";
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "textBox1";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(168, 168);
			this.textBox2.Name = "textBox2";
			this.textBox2.TabIndex = 7;
			this.textBox2.Text = "textBox2";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(288, 213);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.textBox2,
																		  this.textBox1,
																		  this.label2,
																		  this.label1,
																		  this.button4,
																		  this.button3,
																		  this.button2,
																		  this.button1});
			this.Name = "Form1";
			this.Text = "Form1";
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
