using System;
using System.Collections.Generic;

namespace Conexao
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("===================== Produtos ==================");

            ProdutoDAO produtos = new ProdutoDAO();
            List<Produto> listaProduto = produtos.Todos();
            foreach (var item in listaProduto)
            {
                Console.WriteLine("ID: {0}, Nome: {1}, Categoria: {2}", item.Id, item.Nome, item.NomeCategoria);
            }

            Console.WriteLine("===================== Categorias ==================");

            CategoriaDAO categorias = new CategoriaDAO();
            List<Categoria> lista = categorias.Todos();
            foreach (var item in lista)
            {
                Console.WriteLine("ID: {0}, Nome: {1}, Descricao: {2}", item.Id, item.Nome, item.Descricao);
            }

            //Console.WriteLine("======================Inserir novo produto==================");
            //Console.WriteLine("Nome do Produto:");
            //string nome = Console.ReadLine();

            //produtos.Inserir(nome, 1, 1);
            //produtos.Atualizar(nome, 78);

        }
    }
}
