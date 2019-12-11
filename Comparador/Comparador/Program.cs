using System;
using System.Collections.Generic;

namespace ComparaArquivo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArquivoNomes arquivo1 = new ArquivoNomes(@"C:\Users\vagne\source\repos\ComparaArquivo\ComparaArquivo\arquivo1.txt");
            ArquivoNomes arquivo2 = new ArquivoNomes(@"C:\Users\vagne\source\repos\ComparaArquivo\ComparaArquivo\arquivo2.txt");

            ArquivoNomes arquivoDiferenca = new ArquivoNomes(@"C:\Users\vagne\source\repos\ComparaArquivo\ComparaArquivo\arquivoDiferenca.txt");
 
            arquivo1.Ler();
            arquivo2.Ler();

            HashSet<string> nomes1 = new HashSet<string>(arquivo1.Linhas);
            HashSet<string> nomes2 = new HashSet<string>(arquivo2.Linhas);

            nomes1.ExceptWith(nomes2);

            foreach(string diferenca in nomes1)
            {
                Console.WriteLine("Não achei o nome {0}", diferenca);
                arquivoDiferenca.Linhas.Add(diferenca);
            }
                       
            arquivoDiferenca.Gravar();
        }

        
    }
}
