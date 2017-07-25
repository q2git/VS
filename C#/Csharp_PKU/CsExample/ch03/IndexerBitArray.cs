//���������������һ��BitArray �࣬����һ��λ������Ϊ���ʵ�����λ�ṩ��һ��������
//ע��BitArray ����Ԫ�ص��﷨��bool[]����ȫ��ͬ��
//һ����BitArray��ʵ������Ӧ��bool[] ���ĸ��ٵĴ洢�ռ�(ÿ������ֻռ��һλ������һ����)�������������bool[]һ��������
//�������CountPrimes ʹ��BitArray �;����"ɸѡ"�㷨�������1��һ�����������ݼ�����ݣ�

using System;
class BitArray
{
	int[] bits;
	int length;
	public BitArray(int length) {
		if (length < 0) throw new ArgumentException();
		bits = new int[((length - 1) >> 5) + 1];
		this.length = length;
	}
	public int Length {
		get { return length; }
	}
	public bool this[int index] {
		get {
			if (index < 0 || index >= length) {
				throw new IndexOutOfRangeException();
			}
			return (bits[index >> 5] & 1 << index) != 0;
		}
		set {
			if (index < 0 || index >= length) {
				throw new IndexOutOfRangeException();
			}
			if (value) {
				bits[index >> 5] |= 1 << index;
			}
			else {
				bits[index >> 5] &= ~(1 << index);
			}
		}
	}
}
class CountPrimes
{
	static int Count(int max) {
		BitArray flags = new BitArray(max + 1);
		int count = 1;
		for (int i = 2; i <= max; i++) {
			if (!flags[i]) {
				for (int j = i * 2; j <= max; j += i) 
					flags[j] = true;
				count++;
			}
		}
		return count;
	}
	static void Main() {
		Console.Write( "������һ������ " );
		string s = Console.ReadLine();
		int max = int.Parse(s);
		int count = Count(max);
		Console.WriteLine("�� 1 �� {0}�ҵ� {1} ������", 
			max, count);
	}
}
