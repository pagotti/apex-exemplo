using System;

namespace Encotel
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Fazer um tradutor de letras para números de telefone
            /// Se for 0, 1 ou -, não traduz, caso contário use a tabela abaixo
            /// 
            /// Letras	Número
            /// ABC     2
            /// DEF     3
            /// GHI     4
            /// JKL     5
            /// MNO     6
            /// PQRS    7
            /// TUV     8
            /// WXYZ    9
         
            Console.WriteLine("Entre com o número codificado do telefone:");
            string numero = Console.ReadLine();

            Telefone tel = new Telefone();
            Console.WriteLine("Número Real: {0}", tel.Traduzir(numero));

            Console.ReadLine();

        }
    }
}
