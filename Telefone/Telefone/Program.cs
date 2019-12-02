using System;
using System.Text.RegularExpressions;

namespace Telefone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça uma rotina para padronizar o formato do telefone (xx)99999-9999 e exiba na tela

            Console.WriteLine("Entre com o número do telefone:");
            var telefone = Console.ReadLine();

            // 1 - o numero tem 11 digitos
            // 2 - o numero tem 9 digitos
            // 3 - o numero tem 8 digitos

            //var numero = telefone.Length == 11 ?
            //    "(" + telefone.Substring(0, 2) + ") " + telefone.Substring(2, 5) + "-" + telefone.Substring(7, 4)
            //    : telefone.Length == 9 ?
            //    "(47) " + telefone.Substring(0, 5) + "-" + telefone.Substring(5, 4)
            //    : telefone.Length == 8 ?
            //    "(47) " + telefone.Substring(0, 4) + "-" + telefone.Substring(4, 4)
            //    : telefone;

            var numero = "";
            if (telefone.Length == 11)
            {
                numero = "(" + telefone.Substring(0, 2) + ") " + telefone.Substring(2, 5) + "-" + telefone.Substring(7, 4);
            } 
            else if (telefone.Length == 9)
            {
                numero = "(47) " + telefone.Substring(0, 5) + "-" + telefone.Substring(5, 4);
            }
            else if (telefone.Length == 8)
            {
                numero = "(47) " + telefone.Substring(0, 4) + "-" + telefone.Substring(4, 4);
            }
            else
            {
                numero = telefone;
            }

            Console.WriteLine(numero);
            
            // versao com regex
            var r = new Regex(@"(\d{2})?(\d{4,5})(\d{4})", RegexOptions.Compiled);
            numero = r.Replace(telefone, "($1) $2-$3");
            Console.WriteLine(numero);

        }
    }
}
