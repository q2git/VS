using System;
class LocalVarAndMemberVar 
{
	static int a;	//�����
	static void Main(){
		int b; //�ֲ�����
		int [] c= new int[5];
		Console.WriteLine(a);	// a��ֵΪ0
		//Console.WriteLine(b);  //���벻��ͨ��
		Console.WriteLine( c[3] );  //c[3]��ֵΪ0
	}
}
