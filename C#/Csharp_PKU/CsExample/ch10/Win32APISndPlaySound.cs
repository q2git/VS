using System;
using System.Runtime.InteropServices;
class Test
{
	// ���� Windows PlaySound() ����
	[DllImport("winmm.dll")]
	public static extern bool PlaySound(
		string pszSound,
		int hmod,
		int fdwSound);

	// ����PlaySound()Ҫʹ�õĳ���
	public const int SND_FILENAME = 0x00020000;
	public const int SND_ASYNC = 0x0001;

	static void Main(string[] args)
	{
		// ���������ļ�
		PlaySound(
			@"c:\winnt\media\chimes.wav",
			0,
			SND_FILENAME | SND_ASYNC);
		Console.ReadLine();
	}
}
