using System;
delegate void ������( ref int x);

class �չ��
{
	public void ����( ref int �¶�)
	{
		�¶� += 1;
	}
}

class �׳��
{
	public void ����( ref int �¶�)
	{
		�¶� += 2;
	}
}

class ����
{
	public void �ȷ�( ref int �¶�)
	{
		�¶� -= 5;
	}
}

class �յ�
{
	static public void ��( ref int �¶�)
	{
		�¶� = 25;
	}
}


class ����
{
	static public void �����¶�()
	{
		�չ�� flu1 = new �չ��();
		�չ�� flu2 = new �չ��();
		�׳�� light = new �׳��();
		���� fan1 = new ����();

		int �¶� = 30;
		������ ctrls = null;

		ctrls += new ������( flu1.���� );
		ctrls += new ������( flu2.���� );
		ctrls += new ������( light.���� );
        ctrls( ref �¶�);
		Console.WriteLine( �¶� );
		
		ctrls -= new ������( light.���� );
		ctrls -= new ������( flu2.���� );
		ctrls += new ������( fan1.�ȷ� );
		ctrls( ref �¶�);
		Console.WriteLine( �¶� );
		
		ctrls += new ������( �յ�.�� );
		ctrls( ref �¶�);
		Console.WriteLine( �¶� );

	}
	static public void Main()
	{
		�����¶�();
	}
}
