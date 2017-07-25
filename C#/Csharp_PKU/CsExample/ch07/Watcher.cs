using System;
using System.IO;
public class Watcher
{
	public static void Main()
	{
		const string path = @"d:\csExample";

		FileSystemWatcher watcher = new FileSystemWatcher();
		watcher.Path = path;
		watcher.Filter = "*.txt";

		watcher.NotifyFilter = NotifyFilters.LastAccess | 
			NotifyFilters.LastWrite | NotifyFilters.FileName | 
			NotifyFilters.DirectoryName;

		// �¼�������
		watcher.Changed += new FileSystemEventHandler(OnChanged);
		watcher.Created += new FileSystemEventHandler(OnChanged);
		watcher.Deleted += new FileSystemEventHandler(OnChanged);
		watcher.Renamed += new RenamedEventHandler(OnRenamed);

		// ��ʼ����
		watcher.EnableRaisingEvents = true;

		// ���û�����q�Ž�������
		Console.WriteLine("Press'q' to quit the sample.");
		while(Console.Read()!='q');
	}

	// �¼�������.
	public static void OnChanged(object source, FileSystemEventArgs e)
	{
		// ��ʾ��Щ�ļ����˺����޸�
		Console.WriteLine("File: " +  e.FullPath + " " + e.ChangeType);
	}

	public static void OnRenamed(object source, RenamedEventArgs e)
	{
		// ��ʾ�����ĵ��ļ���
		Console.WriteLine("File: {0} renamed to {1}", e.OldFullPath, e.FullPath);
	}
}