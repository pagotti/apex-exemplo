using System;
using System.Collections.Generic;
using System.Text;

namespace Teatro
{
    class Ingresso
    {
        public decimal Preco { get; set; }
        
        public int Ingressos { get; set; }

        public decimal Despesas { get; set; }

        public decimal Lucro()
        {
            return Preco * Ingressos - Despesas;
        }
    }
}
