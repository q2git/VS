using System;
using Env = System.Environment;
class Test
{
	static void Main()
	{
		string s = "";
		s += "\n��ǰ������:\t" 
			+ Env.GetCommandLineArgs()[0];
		s += "\n��ǰĿ¼:\t" 
			+ Env.CurrentDirectory;
		s += "\nWin����ϵͳ:\t" 
			+ (Env.OSVersion.Platform == PlatformID.Win32NT);
		s += "\n��������Temp:\t"  
			+ Env.GetEnvironmentVariable( "temp" );

		Console.WriteLine( s );
	}
}

