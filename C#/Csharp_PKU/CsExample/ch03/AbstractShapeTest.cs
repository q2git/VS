using System;

public abstract class Shape
{
   private string myId;

   public Shape(string s)
   {
      Id = s;   
   }

   public string Id //����
   {
      get 
      {
         return myId;
      }

      set
      {
         myId = value;
      }
   }

   
   public abstract double Area //���,��������
   {
      get;
   }

   public virtual void Draw() //����,�鷽��
   {
      Console.WriteLine( "Draw Shape Icon" );
   }

   public override string ToString() // ����object���鷽��
   {
      return Id + " Area = " + string.Format("{0:F2}",Area);
   }
}

//��������
public class Square : Shape
{
   private int mySide; //�߳�

   public Square(int side, string id) : base(id)
   {
      mySide = side;
   }

   public override double Area	//ʵ�����
   {
      get
      {
         return mySide * mySide;
      }
   }

   public override void Draw() //���ǻ��Ʒ���
   {
		Console.WriteLine( "Draw 4 Side:" + mySide );
   }
}

// Բ��
public class Circle : Shape
{
   private int myRadius; //�뾶

   public Circle(int radius, string id) : base(id)
   {
      myRadius = radius;
   }

   public override double Area  //ʵ�����
   {
      get
      {
         return myRadius * myRadius * System.Math.PI;
      }
   }

   public override void Draw() //���ǻ��Ʒ���
   {
		Console.WriteLine( "Draw Circle:" + myRadius );
   }

}

//������
public class Rectangle : Shape
{
   private int myWidth;
   private int myHeight;

   public Rectangle(int width, int height, string id) : base(id)
   {
      myWidth  = width;
      myHeight = height;
   }

   public override double Area
   {
      get
      {
         return myWidth * myHeight;
      }
   }

   public override void Draw() //���ǻ��Ʒ���
   {
		Console.WriteLine( "Draw Rectangle" );
   }

}

//����
public class TestClass
{
   public static void Main()
   {
      Shape[] shapes =
         {
            new Square(5, "Square #1"),
            new Circle(3, "Circle #1"),
            new Rectangle( 4, 5, "Rectangle #1")
         };
      
      System.Console.WriteLine("Shapes Collection");
      foreach(Shape s in shapes)
      {
         System.Console.WriteLine(s);
      }
         
   }
}
