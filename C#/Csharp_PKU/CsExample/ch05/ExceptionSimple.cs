using System;
class ExceptionSimple 
{
	int a = 10;
	public static void Main(string[] args) 
	{
		int a = 0;
		try
		{ 
			a= int.Parse( "2" );
			a /= (a-a);  
			// ע��: ��������0,������쳣,��0.0/0=NaN  FPN/0=������,-FPN/0=������, 
		}
		catch(System.ArithmeticException ea )
		{ Console.WriteLine("ea:" +ea); }
		catch(System.FormatException en ) 
		{ Console.WriteLine("en:" +en); }
		catch(System.NullReferenceException ep )
		{ Console.WriteLine("ep:" +ep); }
		catch(System.IndexOutOfRangeException eb )
		{ Console.WriteLine("eb:" +eb); }
		catch
		{ Console.WriteLine("Exception"); }  //��catch����Exception,��catch����
		finally
		{ Console.WriteLine("finally executed.");}
		Console.WriteLine("Program End!"+a );
	}
}
