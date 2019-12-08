using System;
using System.Collections.Generic;
using System.Text;

namespace Poligono
{
    abstract class PoligonoBase
    {
        public virtual int Area()
        {
            return 0;
        }

        public abstract int Perimetro();

    }
}
