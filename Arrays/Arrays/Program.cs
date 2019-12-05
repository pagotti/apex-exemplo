using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[5];
            numero[0] = 10;
            numero[1] = 20;
            numero[2] = 30;
            numero[3] = 40;
            numero[4] = 50;

            int[] numero2 = new int[] { 10, 20, 30, 40, 50 };

            char[] caracteres = new char[] { 'A', 'B', 'C' };

            for (int i = 0; i < numero2.Length; i++)
            {
                Console.WriteLine(numero2[i]);
            }

            foreach(int n in numero2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
