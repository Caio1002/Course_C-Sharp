using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a dimensão da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Diagonal principal: ");
            for (int i = 0; i < n; i++) {
                Console.WriteLine(mat[i,i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Quantidade de numeros negativos:");
            int count = 0;
            for (int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    if(mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);

        }
    }
}