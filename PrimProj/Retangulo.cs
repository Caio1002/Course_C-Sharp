using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimProj
{
    internal class Retangulo
    {

        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perim()
        {
            return 2 * (Largura + Altura);
        }

        public double Diag()
        {
            return Math.Sqrt((Altura * Altura) + (Largura * Largura));
        }

    }
}
