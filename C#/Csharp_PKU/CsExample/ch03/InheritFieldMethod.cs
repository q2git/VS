using System;
class A
{
	public int a = 10;
	public void m() {
		a++; Console.WriteLine(a);
	}
}
class B : A
{
	new public int a = 20;
	new public void m() { 
		a++; Console.WriteLine(a);
	}
	static void Main()
	{
		A x = new B(); 
		Console.WriteLine( x.a ); //��ʾ10
		x.m(); //��ʾ11
		
		B y = new B();
		Console.WriteLine( y.a ); //��ʾ20
		y.m(); //��ʾ21
	}
}
