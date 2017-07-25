using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace AutoScore
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblOp;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lblEq;
		private System.Windows.Forms.TextBox txtAnswer;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnJudge;
		private System.Windows.Forms.ListBox lstDisp;
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
			this.lblA = new System.Windows.Forms.Label();
			this.lblOp = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblEq = new System.Windows.Forms.Label();
			this.txtAnswer = new System.Windows.Forms.TextBox();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnJudge = new System.Windows.Forms.Button();
			this.lstDisp = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.Location = new System.Drawing.Point(24, 32);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(32, 23);
			this.lblA.TabIndex = 0;
			// 
			// lblOp
			// 
			this.lblOp.Location = new System.Drawing.Point(72, 32);
			this.lblOp.Name = "lblOp";
			this.lblOp.Size = new System.Drawing.Size(32, 23);
			this.lblOp.TabIndex = 0;
			// 
			// lblB
			// 
			this.lblB.Location = new System.Drawing.Point(120, 32);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(32, 23);
			this.lblB.TabIndex = 0;
			// 
			// lblEq
			// 
			this.lblEq.Location = new System.Drawing.Point(160, 32);
			this.lblEq.Name = "lblEq";
			this.lblEq.Size = new System.Drawing.Size(32, 23);
			this.lblEq.TabIndex = 0;
			this.lblEq.Text = "=";
			// 
			// txtAnswer
			// 
			this.txtAnswer.Location = new System.Drawing.Point(200, 32);
			this.txtAnswer.Name = "txtAnswer";
			this.txtAnswer.TabIndex = 1;
			this.txtAnswer.Text = "textBox1";
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(56, 88);
			this.btnNew.Name = "btnNew";
			this.btnNew.TabIndex = 2;
			this.btnNew.Text = "����";
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnJudge
			// 
			this.btnJudge.Location = new System.Drawing.Point(160, 88);
			this.btnJudge.Name = "btnJudge";
			this.btnJudge.TabIndex = 2;
			this.btnJudge.Text = "�з�";
			this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
			// 
			// lstDisp
			// 
			this.lstDisp.ItemHeight = 12;
			this.lstDisp.Location = new System.Drawing.Point(24, 136);
			this.lstDisp.Name = "lstDisp";
			this.lstDisp.Size = new System.Drawing.Size(248, 124);
			this.lstDisp.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lstDisp,
																		  this.btnNew,
																		  this.txtAnswer,
																		  this.lblA,
																		  this.lblOp,
																		  this.lblB,
																		  this.lblEq,
																		  this.btnJudge});
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

		int a, b;
		string op;
		int result;

		private void btnNew_Click(object sender, System.EventArgs e)
		{
			Random rnd = new Random();
			a = rnd.Next( 9 ) + 1;
			b = rnd.Next( 9 ) + 1;
			int c = rnd.Next( 4 );
			switch( c )
			{
				case 0: op="+"; result=a+b; break;
				case 1: op="-"; result=a-b; break;
				case 2: op="*"; result=a*b; break;
				case 3: op="/"; result=a/b; break;
			}
			lblA.Text=(""+a);
			lblB.Text=(""+b);
			lblOp.Text=(""+op);
			txtAnswer.Text=("");

		}

		private void btnJudge_Click(object sender, System.EventArgs e)
		{
			// to do: code goes here.
			string str = txtAnswer.Text;
			double d = Double.Parse( str );
			string disp = "" + a + op + b+"="+ str +" ";
			if( d == result ) 
				disp += "��";
			else 
				disp += "�w";
		
			lstDisp.Items.Add( disp );

		}
	}
}
