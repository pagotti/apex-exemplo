using System;
using System.Collections.Generic;
using System.Text;

namespace PoligonoInterface
{
    class Retangulo : ICalculos
    {
        private int ladoMenor;
        private int ladoMaior;

        public Retangulo(int ladoMenor, int ladoMaior)
        {
            this.ladoMaior = ladoMaior;
            this.ladoMenor = ladoMenor;
        }
        public int Area()
        {
            return this.ladoMenor * this.ladoMaior;
        }

        public int Perimetro()
        {
            return this.ladoMaior * 2 + this.ladoMenor * 2;
        }
    }
}
