using System;
public class MainApp
{
	public static void Main()
	{
		int x = Div( 8 ,3 ); //�˾��ڱ����л����������Ϣ
		int y = Div2( 8, 3 ); //�������Div���°�
	}

	[Obsolete("Div�ѷ���������� Div2")]
	public static int Div( int a, int b)
	{
		return (a/b);
	}
   
	public static int Div2( int a, int b)
	{
		return b==0? 0 : a/b;
	}
}
