using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Conexao
{
    abstract class DAO<T>
    {

        protected abstract void Preencher(List<T> lista, SqlDataReader reader);

        protected List<T> Listar(string sql)
        {
            List<T> lista = new List<T>();

            using (SqlConnection conexao = new SqlConnection(Configuracao.StringConexao()))
            {
                conexao.Open();
                SqlCommand comando = new SqlCommand(sql, conexao);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Preencher(lista, reader);
                }
                reader.Close();

            }

            return lista;
        }

    }
}
