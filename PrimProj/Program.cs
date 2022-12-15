using System;
using System.Globalization;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite a quantidade de pessoas: ");
            int numero = int.Parse(Console.ReadLine());

            double[] vect = new double[numero];
            Console.WriteLine();
            Console.WriteLine("Digite as alturas:");
            for(int i = 0; i < numero; i++) {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            double soma = 0;
            for(int i = 0; i < numero; i++) {
                soma += vect[i];
            }
            double media = soma / numero;

            Console.WriteLine();
            Console.WriteLine("A média de altura é: " + media.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}