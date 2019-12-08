using System;

namespace Teatro
{
    class Program
    {
        static void Main(string[] args)
        {
            Ingresso[] ingressos = new Ingresso[9];

            Ingresso maiorIngresso = null;
            decimal maiorLucro = 0;

            for (int i = 0; i < 9; i++)
            {
                Ingresso ingresso = new Ingresso();
                ingresso.Preco = 5 - 0.5m * i;
                ingresso.Ingressos = 120 + 26 * i;
                ingresso.Despesas = 200;
                ingressos[i] = ingresso;

                if (ingresso.Lucro() > maiorLucro)
                {
                    maiorLucro = ingresso.Lucro();
                    maiorIngresso = ingresso;
                }

                Console.WriteLine("preco:{0}, ingressos:{1}, despesas:{2}, lucro:{3}",
                    ingresso.Preco, ingresso.Ingressos, ingresso.Despesas, ingresso.Lucro());
            }

            Console.WriteLine();
            Console.WriteLine("Preço de Ingresso com maior Lucro");
            Console.WriteLine("preco:{0}, ingressos:{1}, despesas:{2}, lucro:{3}",
                maiorIngresso.Preco, maiorIngresso.Ingressos, maiorIngresso.Despesas, maiorIngresso.Lucro());

        }
    }
}
