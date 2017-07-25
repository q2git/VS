using System;
public struct Digit
{
	byte value;
	public Digit(byte value) 
	{
		if (value < 0 || value > 9) throw new ArgumentException();
		this.value = value;
	}
	public Digit(int value): this((byte) value) {}
	public static implicit operator byte(Digit d) 
	{
		return d.value;
	}
	public static explicit operator Digit(byte b) 
	{
		return new Digit(b);
	}
	public static Digit operator+(Digit a, Digit b) 
	{
		return new Digit(a.value + b.value);
	}
	public static Digit operator-(Digit a, Digit b) 
	{
		return new Digit(a.value - b.value);
	}
	public static bool operator==(Digit a, Digit b) 
	{
		return a.value == b.value;
	}
	public static bool operator!=(Digit a, Digit b) 
	{
		return a.value != b.value;
	}
	public override bool Equals(object value) 
	{
		return this == (Digit) value;
	}
	public override int GetHashCode() 
	{
		return value.GetHashCode();
	}
	public override string ToString() 
	{
		return value.ToString();
	}
}
class Test
{
	static void Main() 
	{
		Digit a = (Digit) 5;
		Digit b = (Digit) 3;
		Digit plus = a + b;
		Digit minus = a - b;
		bool equals = (a == b);
		Console.WriteLine("{0} + {1} = {2}", a, b, plus);
		Console.WriteLine("{0} - {1} = {2}", a, b, minus);
		Console.WriteLine("{0} == {1} = {2}", a, b, equals);
	}
}
/*
Digit���Ͷ���������Ĳ�������
��	��Digit��byte����ʽת����������
��	��byte��Digit����ʽת��������
��	������Digit��ֵ��Ӳ�����һ��Digit��ֵ�ļӷ���������
��	��һ��Digit��ֵ������Digit��ֵ�����������һ��digit��ֵ�ļ�����������
��	�Ƚ�����digit��ֵ�ĵ�ʽ�ͷǵ�ʽ��
*/