using System;
class ArrayUse
{
    public static void Main()
    {
        int[] numbers = new int[5];  // һά����
        string[,] names = new string[5,4]; // ��ά����
        byte[][] scores = new byte[5][]; // ��������
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = new byte[i+3];
        }
        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine("Length of row {0} is {1}", 
				i, scores[i].Length);
        }
    }
}
