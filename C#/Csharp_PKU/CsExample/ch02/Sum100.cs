using System;
public class Sum100{
	public static void Main( ){
		int sum,n;

		Console.WriteLine("\n**** for statement ****");
		sum=0;
		for( int i=1; i<=100; i++){ //��ʼ��,ѭ������,ѭ���ı�
			sum+=i;		//ѭ����
		}
		Console.WriteLine("sum is "+sum);

		Console.WriteLine("\n**** while statement ****");
		sum=0;
		n=100;			//��ʼ��
		while( n>0 ){	//ѭ������
			sum+=n;		//ѭ����
			n--;		//ѭ���ı�
		}
		Console.WriteLine("sum is "+sum);

		Console.WriteLine("\n**** do_while statement ****");
		sum=0;
		n=0;			//��ʼ��
		do{
			sum+=n;		//ѭ����
			n++;		//ѭ���ı�
		}while( n<=100 );//ѭ������
		Console.WriteLine("sum is "+sum);
	}
}
