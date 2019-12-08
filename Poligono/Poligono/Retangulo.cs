using System;
using System.Collections.Generic;
using System.Text;

namespace Poligono
{
    class Retangulo : PoligonoBase
    {
        private int ladoMenor;
        private int ladoMaior;
        public Retangulo(int ladoMenor, int ladoMaior)
        {
            this.ladoMenor = ladoMenor;
            this.ladoMaior = ladoMaior;
        }

        public override int Area()
        {
            return this.ladoMenor * this.ladoMaior;
        }

        public override int Perimetro()
        {
            return 2 * this.ladoMenor + 2 * this.ladoMaior;
        }
    }
}
