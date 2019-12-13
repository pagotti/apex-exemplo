using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Data;

namespace Conexao
{
    class ProdutoDAO : DAO<Produto>
    {

        public List<Produto> Todos()
        {
            return this.Listar("Select * from Products join Categories on Products.CategoryID = Categories.CategoryID");
        }

        public List<Produto> DezPrimeirosProdutos()
        {
            return this.Listar("select top 10 * from Products join Categories on Products.CategoryID = Categories.CategoryID order by ProductId");
        }

        public List<Produto> DezProdutosMaisCaros()
        {
            return this.Listar("select top 10 * from Products join Categories on Products.CategoryID = Categories.CategoryID order by UnitPrice desc");
        }

        public void Inserir(string nome, int idCategoria, int idFornecedor)
        {
            string sql = "insert into Products (ProductName, SupplierId, CategoryId, UnitPrice) values (@nome, @fornecedor, @categoria, @preco)";

            using (SqlConnection conexao = new SqlConnection(Configuracao.StringConexao()))
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(sql, conexao);
                SqlParameter parNome = new SqlParameter("nome", SqlDbType.VarChar);
                parNome.Value = nome;
                SqlParameter parFornecedor = new SqlParameter("fornecedor", SqlDbType.Int);
                parFornecedor.Value = idFornecedor;
                SqlParameter parCategoria = new SqlParameter("categoria", SqlDbType.Int);
                parCategoria.Value = idCategoria;
                SqlParameter parPreco = new SqlParameter("preco", SqlDbType.Money);
                parPreco.Value = 10;
                comando.Parameters.Add(parNome);
                comando.Parameters.Add(parFornecedor);
                comando.Parameters.Add(parCategoria);
                comando.Parameters.Add(parPreco);
                comando.ExecuteNonQuery();

            }
        }

        public void Atualizar(string nome, int idProduto)
        {
            string sql = "update Products set ProductName = @nome where ProductId = @id";

            using (SqlConnection conexao = new SqlConnection(Configuracao.StringConexao()))
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(sql, conexao);
                SqlParameter parNome = new SqlParameter("nome", SqlDbType.VarChar);
                parNome.Value = nome;
                SqlParameter parId = new SqlParameter("id", SqlDbType.Int);
                parId.Value = idProduto;
                comando.Parameters.Add(parNome);
                comando.Parameters.Add(parId);
                comando.ExecuteNonQuery();

            }
        }

        protected override void Preencher(List<Produto> lista, SqlDataReader reader)
        {
            Produto p = new Produto();
            p.Id = reader.GetInt32(reader.GetOrdinal("ProductId"));
            p.Nome = reader.GetString(reader.GetOrdinal("ProductName"));
            p.NomeCategoria = reader.GetString(reader.GetOrdinal("CategoryName"));
            lista.Add(p);
        }
    }
}
