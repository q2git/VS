using System;
using System.Text.RegularExpressions;
class Test
{
	static void  Main()
	{
		string pattern = "[Bbw]ill";
		string s = "My friend Bill will pay the bill";

		if( Regex.IsMatch( s, pattern ) )
			Console.WriteLine( s+ "��" + pattern +"��ƥ��" );
        
		Regex  rx = new Regex( pattern );
		
		MatchCollection mc = rx.Matches(s);
		Console.WriteLine("��{0}��ƥ��", mc.Count);
		foreach ( Match mt in mc )
		{
			Console.WriteLine( mt );
		}	

		Match m = rx.Match(s);
		while ( m.Success )
		{
			Console.WriteLine("��λ�� {0} ��ƥ��'{1}'", 
				m.Index, m.Value);
			m = rx.Match(s, m.Index+ m.Length);
		}

		for (m = rx.Match(s); m.Success; m = m.NextMatch()) 
		{
			Console.WriteLine("��λ�� {0} ��ƥ��'{1}'", 
				m.Index, m.Value);
		}

	}
}
