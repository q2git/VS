using System;
using System.IO;
class  ListAllFiles 
{
	public static void Main(string[] args)
	{ 
		ListFiles( new DirectoryInfo( "d:\\csExample"));
	}

	public static void ListFiles( FileSystemInfo info )
	{
		if( ! info.Exists ) return;

		DirectoryInfo dir = info as DirectoryInfo;
		if( dir == null ) return; //����Ŀ¼
		
		FileSystemInfo [] files = dir.GetFileSystemInfos();
		for( int i=0; i<files.Length; i++)
		{
			FileInfo file = files[i] as FileInfo;
			if( file != null ) // ���ļ�
			{
				Console.WriteLine( 
					file.FullName + "\t" + file.Length );
			}
			else	//��Ŀ¼
			{
				ListFiles( files[i] );  //������Ŀ¼,���еݹ����
			}
		}
	}
}
