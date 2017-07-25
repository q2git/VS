using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace TestWin
{
	/// <summary>
	/// Form1 ��ժҪ˵����
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnGetMail;
		private System.Windows.Forms.TextBox txtServer;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMsg;
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
			this.btnGetMail = new System.Windows.Forms.Button();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtMsg = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGetMail
			// 
			this.btnGetMail.Location = new System.Drawing.Point(160, 128);
			this.btnGetMail.Name = "btnGetMail";
			this.btnGetMail.Size = new System.Drawing.Size(104, 23);
			this.btnGetMail.TabIndex = 0;
			this.btnGetMail.Text = "��ȡemail";
			this.btnGetMail.Click += new System.EventHandler(this.btnGetMail_Click);
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(192, 24);
			this.txtServer.Name = "txtServer";
			this.txtServer.TabIndex = 1;
			this.txtServer.Text = "pop3.263.net";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(192, 56);
			this.txtUser.Name = "txtUser";
			this.txtUser.TabIndex = 2;
			this.txtUser.Text = "dstang2000";
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(192, 88);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.TabIndex = 3;
			this.txtPass.Text = "textBox3";
			// 
			// txtMsg
			// 
			this.txtMsg.Location = new System.Drawing.Point(32, 160);
			this.txtMsg.Multiline = true;
			this.txtMsg.Name = "txtMsg";
			this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtMsg.Size = new System.Drawing.Size(368, 192);
			this.txtMsg.TabIndex = 4;
			this.txtMsg.Text = "";
			this.txtMsg.WordWrap = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(104, 56);
			this.label1.Name = "label1";
			this.label1.TabIndex = 5;
			this.label1.Text = "�û���";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 88);
			this.label2.Name = "label2";
			this.label2.TabIndex = 6;
			this.label2.Text = "����";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(104, 24);
			this.label3.Name = "label3";
			this.label3.TabIndex = 7;
			this.label3.Text = "������";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(424, 365);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.txtPass,
																		  this.txtUser,
																		  this.txtServer,
																		  this.label3,
																		  this.label2,
																		  this.label1,
																		  this.txtMsg,
																		  this.btnGetMail});
			this.Name = "Form1";
			this.Text = "GetMail";
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

		private void btnGetMail_Click(object sender, System.EventArgs e)
		{
			const int nPort = 110;
			string sHostName = txtServer.Text;
			StringBuilder txtReply = new StringBuilder();
			string sReply;
			TcpClient client = new TcpClient(); 
			try 
			{

				//���ӷ�����
				client.Connect( sHostName, nPort );  
				NetworkStream stream = client.GetStream();
				sReply = ReadFromStream( stream ); //�õ��ظ�
				CheckError( sReply );
				txtReply.Append( sReply+"\n" );
				
				//�û���
				WriteToStream( stream, "USER " + this.txtUser.Text );
				sReply=ReadFromStream( stream );
				CheckError(sReply);
				txtReply.Append( sReply+"\n" );

				//����
				WriteToStream( stream, "PASS " + this.txtPass.Text );
				sReply=ReadFromStream( stream );
				CheckError(sReply);
				txtReply.Append( sReply+"\n" );

				//�˳�
				WriteToStream( stream, "QUIT ");
				sReply=ReadFromStream( stream );
				CheckError(sReply);
				txtReply.Append( sReply+"\n" );

				stream.Close();
				client.Close();
			} 
			catch (Exception ex) 
			{
				txtReply.Append( ex.ToString() );
			}
			txtMsg.Text = txtReply.ToString();

		}

		private void WriteToStream( NetworkStream stream, string Command)
		{
			string stringToSend = Command + "\r\n";

			Byte[] arrayToSend = Encoding.ASCII.GetBytes(stringToSend.ToCharArray());
			stream.Write(arrayToSend, 0, arrayToSend.Length);
		}

		private String ReadFromStream( NetworkStream stream)
		{
			StringBuilder strReceived= new StringBuilder();
			StreamReader sr= new StreamReader(stream);
			string strLine = sr.ReadLine();

			while(strLine==null || strLine.Length==0)
			{
				strLine = sr.ReadLine();
			}
			strReceived.Append(strLine);

			if(sr.Peek()!=-1)
			{
				while ((strLine=sr.ReadLine())!=null) 
				{	
					strReceived.Append(strLine);
				}
			}
			return strReceived.ToString();
		}

		private void CheckError(string strMessage)
		{
			if (strMessage.IndexOf("+OK") < 0 )
				throw new Exception("ERROR - . Recieved: " + strMessage);
		}

	}
}
