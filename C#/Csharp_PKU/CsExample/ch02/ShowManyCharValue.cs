using System;
class  ShowManyCharValue
{
	public static void Main(string[] args) 
	{
		char c;
		do
		{
			Console.WriteLine("�����ַ������س�����#����");
			c = (char)Console.Read();  //����һ���ַ�
			Console.Read();  //���Իس�����
			Console.Read();  //���Իس�����
			Console.WriteLine( c + "��AsciiֵΪ:" + (int)c );
		}
		while ( c != '#' );
	}
}
