using System;
class Person {
	public string name; //������
	public int age;
	public void sayHello(){ //���巽��
		Console.WriteLine("Hello!  My name is " + name );
	}
	public void sayHello( Person another ){ //��������
		Console.WriteLine("Hello," + another.name + 
			"! My name is " + name );
	}
	public bool isOlderThan( int anAge ){ //���巽��
		bool flg;
		if( age > anAge ) flg = true; else flg=false;
		return flg;
	}
	public Person( string n, int a ){ //���췽��
		name = n;
		age = a;
	}
	public Person( string n ){ //���췽������
		name = n;
		age = -1;
	}
	public Person(  ):this(  "", 0 )//�����������췽��
	{ 
	}
}

class  Student : Person  //��������
{
	public string school; //���ӵ���
	public int score = 0;
	public bool isGoodStudent(){ //���ӵķ���
		return score>=90;
	}
	new public void sayHello(){ //�½���new)ͬ������
		base.sayHello();
		Console.WriteLine( "My school is " + school );
	}
	public void sayHello( Student another ){ //���ط���
		Console.WriteLine("Hi!");
		if( school == another.school ) 
			Console.WriteLine(" Shoolmates ");
	}
	public void testThisSuper(){
		int a;
		a = age;		//��������������Ч����ͬ
		a = this.age;	//ʹ��this
		a = base.age;	//ʹ��base
	}
	public Student(){  //���췽��
	}
	public Student(string name, int age, string school ) 
		: base( name, age ) //���ø���Ĺ��췽��
	{
		this.school = school;
	}

	public static void Main( string [] arggs )
	{
		Person p = new Person( "Liming", 50 );
		Student s = new Student( "Wangqiang", 20, "PKU" );
		Person p2 = new Student( "Zhangyi", 18, "THU" );
		Student s2 = (Student) p2; //����ת��
	}
}
