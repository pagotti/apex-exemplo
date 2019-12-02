using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o peso?");
            var peso = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual é a altura?");
            var altura = Convert.ToDecimal(Console.ReadLine());

            var imc = CalculoIMC.ValorIMC(peso, altura);
            Console.WriteLine("IMC = {0:f2}", imc);
            Console.ReadKey();
        }
    }
}
