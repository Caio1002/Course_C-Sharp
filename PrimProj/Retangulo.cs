using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PrimProj
{

    /*
     MAIN
    Retangulo ret = new Retangulo();

    Console.Write("Entre com a largura: ");
    ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine();
    Console.Write("Entre com a altura: ");
    ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine();
    Console.WriteLine("Area: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Perimetro: " + ret.Perim().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Diagonal: " + ret.Diag().ToString("F2", CultureInfo.InvariantCulture));
    */
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
