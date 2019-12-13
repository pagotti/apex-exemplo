using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Conexao
{
    class CategoriaDAO : DAO<Categoria>
    {
        protected override void Preencher(List<Categoria> lista, SqlDataReader reader)
        {
            Categoria item = new Categoria();
            item.Id = reader.GetInt32(reader.GetOrdinal("CategoryId"));
            item.Nome = reader.GetString(reader.GetOrdinal("CategoryName"));
            item.Descricao = reader.GetString(reader.GetOrdinal("Description"));
            lista.Add(item);
        }

        public List<Categoria> Todos()
        {
            return Listar("select * from Categories");
        }
    }
}
