using System;
using System.Threading;
class Test
{
	static void Main()
	{
		Test obj1 = new Test();
		Thread thread1 = new Thread( new ThreadStart( obj1.Count ));
		thread1.Name = "�߳�1";

		Test obj2 = new Test();
		Thread thread2 = new Thread( new ThreadStart( obj2.Count ));
		thread2.Name = "�߳�2";

		Thread thread3 = new Thread( new ThreadStart( obj2.Count ));
		thread3.Name = "�߳�3";

		thread1.Start();
		thread2.Start();
		thread3.Start();
	}

	private int cnt = 0;
	private void Count()
	{
		while( cnt < 10 )
		{
			cnt ++;
			Console.WriteLine( Thread.CurrentThread.Name + "����" + cnt  );
			Thread.Sleep( 100 );
		}
	}
}