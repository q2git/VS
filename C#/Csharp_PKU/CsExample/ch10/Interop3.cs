using System;
class Test
{
	static void Main()
	{
		Console.Write( "������һ�����ʽ��");
		string exp = Console.ReadLine();
		string result = "";
		Interop2.JSExpressObj obj = new Interop2.JSExpressObj();
		try
		{
			result = obj.Eval( exp );		
		}
		catch{}
		Module1.Msg( result );
	}
}