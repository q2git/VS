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
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox3;
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Items.AddRange(new object[] {
														   "Windows",
														   "OS/2",
														   "Unix",
														   "Linux",
														   "Macintosh"});
			this.comboBox1.Location = new System.Drawing.Point(24, 48);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 20);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "comboBox1";
			// 
			// comboBox2
			// 
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
			this.comboBox2.Items.AddRange(new object[] {
														   "Windows",
														   "OS/2",
														   "Unix",
														   "Linux",
														   "Macintosh"});
			this.comboBox2.Location = new System.Drawing.Point(160, 48);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 150);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.Text = "comboBox2";
			// 
			// comboBox3
			// 
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Items.AddRange(new object[] {
														   "Windows",
														   "OS/2",
														   "Unix",
														   "Linux",
														   "Macintosh"});
			this.comboBox3.Location = new System.Drawing.Point(288, 48);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 20);
			this.comboBox3.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(424, 221);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.comboBox3,
																		  this.comboBox2,
																		  this.comboBox1});
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
