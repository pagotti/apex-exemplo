using System;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Exibir("Olá Mundo");
        }

        /// <summary>
        /// Exibe uma mensagem na tela
        /// </summary>
        /// <param name="mensagem">Informe aqui a mensagem a ser exibida</param>
        private static void Exibir(string mensagem)
        {
            // aqui estou escrevendo a mensagem na tela
            Console.WriteLine(mensagem);
        }

        //static void Exibir(string mensagem)
        //{
        //    Console.WriteLine(mensagem);
        //}
    }
}
