using System;
class A
{
	int x = 1;
	//int y = x+M(); //Error����Ϊ��ĳ�ʼ���в�������this.x �� this.M()
	int M(){ return 1; }
	public A( int x ){}
	public A(){}
};

class B : A
{
	int z=5;
	//public B() : base( z ) //Error���ڸ����͵Ĺ��캯��������֮ǰ�������� this.z
	//{
	//}
};

class Test
{
	static void Main(){}
}