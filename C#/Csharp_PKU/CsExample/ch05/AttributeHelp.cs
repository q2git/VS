using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class
	 | AttributeTargets.Method , 
	 AllowMultiple = true)]
public class HelpAttribute : System.Attribute 
{
	public readonly string Url;
	private string topic;
	public string Topic      // ���� Topic ����������
	{
		get 
		{ 
			return topic; 
		}
		set 
		{ 
			topic = value; 
		}
	}
	public HelpAttribute(string url)  // url ��λ�ò���
	{
		this.Url = url;
	}
}

[HelpAttribute("http://msvc/MyClassInfo", Topic="Test"), 
Help("http://my.com/about/class")]
class MyClass 
{
	[Help("http;//my.com/about/method")]
	public void MyMethod(int i)
	{
		return;
	}
}

public class MemberInfo_GetCustomAttributes
{
	public static void Main()
	{
			Type myType = typeof(MyClass);

			object[] attributes = myType.GetCustomAttributes(false);
			for (int i = 0; i < attributes.Length; i ++)
			{
				PrintAttributeInfo(attributes[i]);
			}

			MemberInfo[] myMembers = myType.GetMembers();
			for(int i = 0; i < myMembers.Length; i++)
			{
				Console.WriteLine("\nNumber {0}: ", myMembers[i]);
				Object[] myAttributes = myMembers[i].GetCustomAttributes(false);
					for(int j = 0; j < myAttributes.Length; j++)
					{
						PrintAttributeInfo( myAttributes[j] );
					}
			}
	}

	static void PrintAttributeInfo( object attr )
	{
		if( attr is HelpAttribute )
		{
			HelpAttribute attrh = (HelpAttribute) attr;
			Console.WriteLine( "----Url: " + attrh.Url + "  Topic: " + attrh.Topic );
		}
	}
}
