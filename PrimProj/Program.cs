using System;
using System.Globalization;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            int s1 = CalcParams.Sum(2, 3);
            Console.WriteLine(s1);

            int s2 = CalcParams.Sum(2, 3, 4);
            Console.WriteLine(s2);

        }
    }
}