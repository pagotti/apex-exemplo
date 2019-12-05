using System;

namespace DuploLoop
{
    class Program
    {
        static void Main(string[] args)
        {

            string resposta;
            do
            {
                Console.WriteLine("Até quanto devo contar?");
                int contador;
                if (!int.TryParse(Console.ReadLine(), out contador))
                {
                    contador = 0;
                }

                // abaixo forma tradicional sem a checagem
                //int contador = Convert.ToInt32(Console.ReadLine());

                int i = 1;
                while (i <= contador)
                {
                    Console.WriteLine("{0}", i);
                    i++;
                }
                Console.WriteLine("Deseja continuar contando? (S/N)");
                resposta = Console.ReadLine();

                int repeticao = 1;
                while (resposta.ToUpper() != "S" && resposta.ToUpper() != "N")
                {
                    if (repeticao > 5)
                    {
                        Console.WriteLine("Você é muito teimoso!");
                    }
                    Console.WriteLine("Escolha S ou N, por favor");
                    resposta = Console.ReadLine();
                    repeticao++;
                    if (repeticao > 10)
                    {
                        Console.WriteLine("Estou saindo então e formatando o seu PC. hahahaha!");
                        resposta = "N";
                    }
                }
                
            } while (resposta.ToUpper() == "S");

            Console.ReadLine();
        }
    }
}
