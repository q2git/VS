// XMLsample.cs
// ����ʱ������: /doc:XMLsample.xml
using System;

/// <summary>
/// �������д�й����ע��.</summary>
/// <remarks>
/// һЩ��������ϸ��ע�ͣ� 
/// ����ͨ��remarks�������ʾ</remarks>
public class SomeClass
{
	/// <summary>
	/// ��������</summary>
	private string myName = null;

	/// <summary>
	/// ���췽�� </summary>
	public SomeClass()
	{
		 // TODO: ��Ӵ���
	}
	
	/// <summary>
	/// �������� Name </summary>
	/// <value>
	/// value ���������������ֵ</value>
	public string Name
	{
		get 
		{
			if ( myName == null )
			{
				throw new Exception("Name is null");
			}
				 
			return myName;
		}
	}

	/// <summary>
	/// �� SomeMethod ������ע��.</summary>
	/// <param name="s"> ���� s ������������</param>
	/// <seealso cref="String">
	/// �� cref ���Ա����μ��������� 
	/// ���������Զ������ص������Ƿ����. </seealso>
	public void SomeMethod(string s)
	{
	}

	/// <summary>
	/// ��������. </summary>
	/// <returns>
	/// �� returns ��ǿ��Ա�������ֵ.</returns>
	/// <seealso cref="SomeMethod(string)">
	/// ������ cref ��ʾ�ο���ص�һ������ </seealso>
	public int SomeOtherMethod()
	{
		return 0;
	}

	/// <summary>
	/// Ӧ�ó�������
	/// </summary>
	/// <param name="args"> �����в��� </param>
	public static int Main(String[] args)
	{
		// TODO: ��Ӵ���

		 return 0;
	}
}
