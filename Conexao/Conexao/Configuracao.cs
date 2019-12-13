using System;
using System.Collections.Generic;
using System.Text;

namespace Conexao
{
    class Configuracao
    {
        public static string StringConexao()
        {
            // o 'LAPTOP-1CRL0DCM' é o nome do servidor SQL que deve conectar
            return @"Data Source=LAPTOP-1CRL0DCM; Initial Catalog=Northwind; Integrated Security=True";
        }
    }
}
