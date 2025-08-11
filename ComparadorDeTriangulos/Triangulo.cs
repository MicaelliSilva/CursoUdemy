using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorDeTriangulos
{
    internal class Triangulo
    {
        public double Lado1;
        public double Lado2;
        public double Lado3;

        public double Area()
        {
            double p = (Lado1 + Lado2 + Lado3) / 2;
            double raiz = Math.Sqrt(p * (p - Lado1) * (p - Lado2) * (p - Lado3));
            return raiz;
        }
    }
}
