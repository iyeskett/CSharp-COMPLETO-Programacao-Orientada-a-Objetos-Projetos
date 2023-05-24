using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01TiposReferenciaEValor
{
    struct Point
    {

        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + "," + Y + ")";
        }
    }
}
