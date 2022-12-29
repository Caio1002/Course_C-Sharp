using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de linhas da matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de colunas da matriz: ");
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }
            Console.WriteLine();

            Console.Write("Digite um numero para busca: ");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine("Posição: " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Em cima: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Em baixo: " + mat[i + 1, j]);
                        }
                    }
                }
            }
            Console.WriteLine();
        }

    }
}