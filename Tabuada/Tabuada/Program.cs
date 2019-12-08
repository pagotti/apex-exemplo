using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Tabuada tabuada = new Tabuada(i);
                tabuada.Escrever();
                Console.WriteLine();
                
            }
        }
    }
}
