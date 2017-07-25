using System;
public class CheckedTest 
{
	public static void Main() 
	{
		byte a,b,result;
		a = 255;
		b = 3;
		try
		{
			unchecked
			{

				// ��unchecked������, �����쳣����������ᱻ�ض�,���Ϊ2
				result = (byte) (a + b); 
				Console.WriteLine( "Unchecked result: " + result );

				// ��checked ���ʽ��Ҫ���������飬���ܷ����쳣
				result = checked( (byte)(a + b) );
				Console.WriteLine( "Checked result: " +  result );
			}
		}
		catch( OverflowException e )
		{
			Console.WriteLine( e);
		}
	}
}
