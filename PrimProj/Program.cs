using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length);//quantidade de elementos no total
            Console.WriteLine(mat.Rank);//linhas da matriz
            Console.WriteLine(mat.GetLength(0));//quantidade de elementos da primeira dimensão
            Console.WriteLine(mat.GetLength(1));//quantidade de elementos da segunda dimensão

        }
    }
}