class A
{
	class B
	{ 
		public int i;
		private int j;
		private void MB()
		{
			M1();// ���Է��� A��private��Ա
		}
	}
	private static void M1(){}
	static void M2 ()
	{ 
		A.B b = new A.B(); // ���Է��� A.B
		b.i = 1; // ���Է��� A.B �� public ��Ա
	}
}

class Test
{
	static void Main()
	{
		object obj = new A();
		//obj  = new A.B(); // ����, A.B���ɷ���
	}
}
