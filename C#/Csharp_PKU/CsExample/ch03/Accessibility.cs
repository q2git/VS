using System;
namespace MyNameSpace 
{
	public class T1 
	{
		public static int myPublicInt;
		internal static int myInternalInt;
		private static int myPrivateInt = 0;

		public class M1 
		{
			public static int myPublicInt;
			internal static int myInternalInt;
			private static int myPrivateInt = 0;
		}

		private class M2 
		{
			public static int myPublicInt = 0;
			internal static int myInternalInt = 0;
			private static int myPrivateInt = 0;
		}
	}

	public class MainClass 
	{
		public static int Main() 
		{
			// Access to T1 fields:
			T1.myPublicInt = 1;      // ��ȡ������
			T1.myInternalInt = 2;    // ���ڵ�ǰ��Ŀ�п��Է���
			// T1.myPrivateInt = 3;  // ������T1֮�ⲻ�ܷ���
	
			// Access to the M1 fields:
			T1.M1.myPublicInt = 1;     // ��ȡ������
			T1.M1.myInternalInt = 2;   // ���ڵ�ǰ��Ŀ�п��Է���
			// T1.M1.myPrivateInt = 3; // ������M1֮�ⲻ�ܷ���
	
			// Access to the M2 fields:
			// T1.M2.myPublicInt = 1;   // ������T1֮�ⲻ�ܷ���
			// T1.M2.myInternalInt = 2; // ������T1֮�ⲻ�ܷ���
			// T1.M2.myPrivateInt = 3;  // ������T1֮�ⲻ�ܷ���M2
	
			return 0;
		}
	}
}
