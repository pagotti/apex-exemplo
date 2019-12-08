using System;
using System.Collections.Generic;

namespace Poligono
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PoligonoBase> poligonos = new List<PoligonoBase>();

            poligonos.Add(new Quadrado(10));
            poligonos.Add(new Retangulo(10, 20));
            poligonos.Add(new Triangulo(8, 5));

            ImprimeArea(poligonos);

            //Console.WriteLine("Area do Quadrado: {0}", q.Area());
            //Console.WriteLine("Area do Retangulo: {0}", r.Area());
            //Console.WriteLine("Area do Triangulo: {0}", t.Area());

        }

        static void ImprimeArea(List<PoligonoBase> poligonos)
        {
            foreach (PoligonoBase p in poligonos)
            {
                Console.WriteLine("Area: {0}", p.Area());
            }
        }
    }
}
