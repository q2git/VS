using System;
class OddEvenCount 
{
   public static void Main() 
   {
      int odd = 0, even = 0;
      int[] arr = new int [] {0,1,2,5,7,8,11};

      foreach (int i in arr) 
      {
         if (i%2 == 0)  
            even++;      
         else 
            odd++;         
      }
      Console.WriteLine(@"����{0}����ż��{1}��.",
                        odd, even) ;
   }
}
