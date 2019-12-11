using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Text;

namespace ComparaArquivo
{
    class ArquivoNomes
    {
        private string nome;
        public List<string> Linhas { get; set; }

        public ArquivoNomes(string nome)
        {
            this.nome = nome;
            this.Linhas = new List<string>();
        }

        public void Gravar()
        {
            try
            {
                using (StreamWriter r = new StreamWriter(this.nome, true))
                {
                    r.WriteLine("---> {0}", DateTime.Now);
                    for (int i = 0; i < this.Linhas.Count; i++)
                    {
                        r.WriteLine(this.Linhas[i]);
                    }
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Não encontrei a pasta do arquivo"); 
            }
            catch (IOException)
            {
                Console.WriteLine("O nome do arquivo '{0}' é invalido", this.nome);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("O usuário não tem permissão para escrever o arquivo '{0}'", this.nome);
            }
            catch (SecurityException)
            {
                Console.WriteLine("O usuário não tem autorização no arquivo '{0}'", this.nome);
            }

        }

        public void Ler()
        {          
            StreamReader s = null;
            try
            {
                s = new StreamReader(this.nome);
                while (!s.EndOfStream)
                {
                    this.Linhas.Add(s.ReadLine());
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("O arquivo '{0}' não foi encontrado", this.nome);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("O arquivo '{0}' é inválido", this.nome);
            }
            catch (IOException)
            {
                Console.WriteLine("O nome do arquivo '{0}' é inválido", this.nome);
            }
            finally
            {
                if (s != null)
                {
                    s.Close();
                }
            }
        }
    }
}
