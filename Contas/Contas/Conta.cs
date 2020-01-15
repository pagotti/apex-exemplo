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

        private decimal saldo;
        public decimal Saldo { 
            get { return this.saldo; }
            set 
            {
                if (value < 0 && !this.Especial)
                {
                    throw new InvalidOperationException("Conta não especial");
                }

                if (this.Especial && Math.Abs(value) > this.Limite)
                {
                    throw new InvalidOperationException("Excedeu o limite");
                }

                this.saldo = value;
            } 
        }

        public bool Especial { get; set; }

        public decimal Limite { get; set; }
        
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
