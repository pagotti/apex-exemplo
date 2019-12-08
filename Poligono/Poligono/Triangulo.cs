using System;
using System.Collections.Generic;
using System.Text;

namespace Poligono
{
    class Triangulo : PoligonoBase
    {

        private int tamanhoBase;
        private int altura;

        public Triangulo(int tamanhoBase, int altura)
        {
            this.tamanhoBase = tamanhoBase;
            this.altura = altura;
        }

        public override int Area()
        {
            return Convert.ToInt32((this.tamanhoBase * this.altura) / 2);
        }

        public override int Perimetro()
        {
            int lado = Convert.ToInt32(Math.Sqrt(Math.Pow((this.tamanhoBase / 2), 2) + Math.Pow(this.altura, 2)));
            return lado * 2 + this.tamanhoBase;

        }
    }
}
