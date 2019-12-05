using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine("Valor de n é: " + n);
                n++;
            }
           
            int numero;

            Console.WriteLine("Até qual número devo contar?");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(i + 1);
            }

            Console.Read();
        }
    }
}
