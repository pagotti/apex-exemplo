using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // replace
            //string textoAntigo = "Esse é ANTIGO um ANTIGO texto ANTIGO";
            //Console.WriteLine(textoAntigo);
            //string textoNovo = textoAntigo.Replace("ANTIGO", "NOVO");
            //Console.WriteLine(textoNovo);

            // substring
            //string textoAntigo = "0123456";
            //Console.WriteLine(textoAntigo);
            //string textoNovo = textoAntigo.Substring(1, 3);
            //Console.WriteLine(textoNovo);

            //string textoAntigo = "ESTOU APRENDENDO C# - MAIÚSCULAS";
            //Console.WriteLine(textoAntigo);
            //string textoNovo = textoAntigo.ToLower().Replace("maiúsculas", "minusculas");
            //Console.WriteLine(textoNovo);

            //string textoAntigo = "um texto escrito em letras minúsculas";
            //Console.WriteLine(textoAntigo);
            //string textoNovo = textoAntigo.Replace("minúsculas", "MAIÚSCULAS").ToUpper();
            //Console.WriteLine(textoNovo);

            string textoAntigo = "um texto escrito em letras ";
            var tamanho = textoAntigo.IndexOf("em");
            Console.WriteLine(tamanho);

            Math.

            Console.ReadKey();
        }
    }
}
