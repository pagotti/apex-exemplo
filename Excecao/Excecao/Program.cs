using System;

namespace Excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MinhaRegraDeNegocio(10);
                Console.WriteLine("Passou no 10");

                //MinhaRegraDeNegocio(-6);
                Console.WriteLine("Passou no -6");

                MinhaRegraDeNegocio(-1);
                Console.WriteLine("Passou no -1");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void MinhaRegraDeNegocio(int umNumero)
        {
            if (umNumero < -5)
            {
                throw new MinhaException("Menos 5");
            }
            if (umNumero < 0)
            {
                throw new MinhaException();
            }
        }
    }
}
