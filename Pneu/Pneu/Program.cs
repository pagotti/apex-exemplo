using System;
using System.Text.RegularExpressions;

namespace Pneu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sai do carro");
            Console.WriteLine("Abra o Porta-Mala");
            Console.WriteLine("Retire as ferramentas");
            Console.WriteLine("Qual é o aro do pneu?");

            var aro = Console.ReadLine();

            switch (aro)
            {
                case "13":
                    Console.WriteLine("OK. Pode trocar o pneu");
                    break;
                
                case "14":
                case "15":
                case "16":
                    Console.WriteLine("Seu estepe é menor que o aro. Deu ruim!");
                    break;

                case "17":
                    Console.WriteLine("Abra o outro compartimento e procure o estepe de 17 polegadas");
                    break;

                default:
                    Console.WriteLine("Não da pra tocar o pneu");
                    break;

            }

        }
    }
}
