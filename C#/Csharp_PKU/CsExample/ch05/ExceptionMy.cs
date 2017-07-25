using System;
class MyException : ApplicationException{
   	private int idnumber;
 	public MyException(String message, int id) 
		:base(message)
	{
			this.idnumber = id;
 	} 
	public int getId() {
		return idnumber;
 	}
}

public class Test{
    public static void regist(int num) {
 	    if(num < 0) {
   			  Console.WriteLine("�ǼǺ���" + num );
 	          throw new MyException("����Ϊ��ֵ��������",3);
 	    }
    }
	public static void manager() {
 	    try {
	        regist(-100);
 	    } catch (MyException e) {
 	        Console.WriteLine("�Ǽ�ʧ�ܣ���������" + e.getId());
	    }
	    Console.WriteLine("���εǼǲ�������");
    }
	public static void Main(){
	    Test.manager();
    }
}
