using CSharpPOO.Objetos;
using System;

namespace CSharpPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Cristina";
            pessoa.DataNascimento = new DateTime(2001, 11, 30);

            Console.WriteLine(pessoa.Nome);

            Pessoa novaPessoa = new Pessoa("Laura");
            novaPessoa.DataNascimento = new DateTime(2000, 5, 4);

            Console.WriteLine(novaPessoa.Nome);

            Pessoa outraPessoa = new Pessoa("Vagner", 49);
            outraPessoa.DataNascimento = new DateTime(1998, 6, 12);

            Console.WriteLine(outraPessoa.Nome);

            Pessoa n = new Pessoa();
            n.Nome = "Igor";
            Console.WriteLine(n.Nome);

        }
    }
}
