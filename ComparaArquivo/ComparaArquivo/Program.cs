using System;

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

            for (int i = 0; i < arquivo1.Linhas.Count; i++)
            {
                string nome = arquivo1.Linhas[i];
                bool encontrou = false;

                for (int j = 0; j < arquivo2.Linhas.Count; j++)
                {
                    string nome2 = arquivo2.Linhas[j];

                    if (nome == nome2)
                    {
                        encontrou = true;
                        break;
                    }
                }

                if (!encontrou)
                {
                    Console.WriteLine("Não encontrei {0}", nome);
                    arquivoDiferenca.Linhas.Add(nome);
                }

            }

            arquivoDiferenca.Gravar();
        }

        
    }
}
