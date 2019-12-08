using System;
using System.Collections.Generic;

namespace PoligonoInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICalculos> calculos = new List<ICalculos>();

            calculos.Add(new Retangulo(10, 20));
            calculos.Add(new Quadrado(10));

            foreach(ICalculos c in calculos)
            {
                Console.WriteLine("Area = {0}", c.Area());
            }
        }
    }
}
