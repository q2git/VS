using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using System.Web.Services;

namespace WebService1
{
	/// <summary>
	/// Service1 ��ժҪ˵����
	/// </summary>
	[ WebService(Description="Simple Web Services",Namespace="http://www.xxxx.com/")]
	public class Service1 : System.Web.Services.WebService
	{
		public Service1()
		{
			//CODEGEN���õ����� ASP.NET Web ����������������
			InitializeComponent();
		}

		#region Component Designer generated code
		
		//Web ����������������
		private IContainer components = null;
				
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if(disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		// WEB ����ʾ��
		// HelloWorld() ʾ�����񷵻��ַ��� Hello World
		// ��Ҫ���ɣ���ȡ��ע�������У�Ȼ�󱣴沢������Ŀ
		// ��Ҫ���Դ� Web �����밴 F5 ��

		[WebMethod]
		public string HelloWorld(string name)
		{
			return "Hello"+name;
		}


	}
}
