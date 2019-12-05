using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numero = new List<int>();

            numero.Add(10);
            numero.Add(20);
            numero.Add(30);
            numero.Clear();
            for (int i = 0; i < numero.Count; i++)
            {
                Console.WriteLine(numero[i]);
            }

            foreach (int item in numero)
            {
                Console.WriteLine(item);
            }

        }
    }
}
