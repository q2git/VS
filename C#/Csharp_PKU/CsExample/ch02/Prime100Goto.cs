using System;
public class Prime100Continue{
	public static void Main( string [] args ){
		Console.WriteLine(" **** 100--200������ ****");
		int n=0;
		for(int i=101;i<200;i+=2){ //���ѭ��
			for(int j=2; j<i; j++){ //�ڲ�ѭ��
				if( i%j==0 )		//��������������ת�����ѭ��
					goto outer;
			}
			Console.Write(" "+i);//��ʾ����
			n++;					//������� 
			if( n<10 )				//δ��10�������򲻻���
				continue;	
			Console.WriteLine( );
			n=0;
			outer:; 
		}
		Console.WriteLine( );
	}
}
