using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas
{
    class Conta
    {
        public string Nome { get; set; }

        public string Numero { get; set; }

        public decimal Saldo { get; set; }
        
        public string DisplayNomeConta 
        { 
            get
            {
                return $"Nome: {Nome}, Conta: {Numero}";
            }
                
        }

        public string DisplayNomeSaldo
        {
            get
            {
                return $"Nome: {Nome}, Saldo: {Saldo}";
            }
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Conta: {Numero}, Saldo: {Saldo}";
        }
    }
}
