using System;
class MyDate {
    public int day,month,year;
    public MyDate(int i,int j,int k) {
    	day = i;
    	month = j;
    	year = k;
    }
}

class MyOkDate  : MyDate{
	public MyOkDate(int i,int j,int k )
	:base(i,j,k)
	{
	}
	public override bool Equals( object obj ){
		if( obj is MyOkDate ){
			MyOkDate m = (MyOkDate)obj; 
			if(m.day==day && m.month==month && m.year==year )
				return true;
		}
		return false;
	}
	public override int GetHashCode(){
		return year*366 + month*31 + day;
	}
}

public class TestEqualsObject{
	public static void Main(string[] args) {
 	   MyDate m1 = new MyDate(24, 3, 2001);
 	   MyDate m2 = new MyDate(24, 3, 2001);
	   Console.WriteLine( m1.Equals(m2) ); //�����,��ʾfalse
	   m1 = new MyOkDate( 24, 3, 2001 );
	   m2 = new MyOkDate( 24, 3, 2001 );
	   Console.WriteLine( m1.Equals(m2) ); //���,��ʾtrue
   }
}
