using System;
class DoubleAndstring 
{
	public static void Main(string[] args) 
	{
		double d ; string s;

		//doubleת��string�ļ��ַ���
		d=3.14159;
		s = "" + d;
		s = d.ToString();
		s = string.Format( "{0}", d );
		s = Convert.ToString( d );

		// stringת��double�ļ��ַ���
		s = "3.14159";
		try{
			d = Double.Parse( s );
			d = Convert.ToDouble( s );
		}
		catch(FormatException )
		{
		}
	}
}
