using System;
using System.IO;
public class CopyFileAddLineNumber 
{
	public static void Main(string[] args) 
	{
		string infname = "CopyFileAddLineNumber.cs";
		string outfname = "CopyFileAddLineNumber.txt";
		if( args.Length >= 1 ) infname = args[0];
		if( args.Length >= 2 ) outfname = args[1];

		try 
		{
			FileStream fin = new FileStream( 
				infname, FileMode.Open, FileAccess.Read );
			FileStream fout = new FileStream(
				outfname, FileMode.Create, FileAccess.Write );

			StreamReader brin = new StreamReader( 
				fin, System.Text.Encoding.Default );
			StreamWriter brout  = new StreamWriter(
				fout, System.Text.Encoding.Default );

			int cnt = 0;	// �к�
			string s = brin.ReadLine();
			while ( s != null ) 
			{
				cnt ++; 
				s = deleteComments(s);						//ȥ����//��ʼ��ע��
				brout.WriteLine(cnt + ": \t" + s );			//д��
				Console.WriteLine(cnt + ": \t" + s );		//�ڿ�������ʾ
				s = brin.ReadLine();						//����
			}			
			brin.Close();				// �رջ�����������ļ�������������.
			brout.Close();
		} 
		catch (FileNotFoundException) 
		{
			Console.WriteLine("File not found!" );
		} 
		catch (IOException e2) 
		{
			Console.WriteLine( e2 );
		}
	}

	static string deleteComments( string s ) //ȥ����//��ʼ��ע��
	{
		if( s==null ) return s;
		int pos = s.IndexOf( "//" );
		if( pos<0 ) return s;
		return s.Substring( 0, pos );
	}
}
