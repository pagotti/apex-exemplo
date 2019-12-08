using System;
using System.Collections.Generic;
using System.Text;

namespace Tabuada
{
    class Tabuada
    {
        private int numero;

        public Tabuada(int numero)
        {
            this.numero = numero;
        }

        public void Escrever()
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", this.numero, i, this.numero * i);
            }
        }
    }
}
