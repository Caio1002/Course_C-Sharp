using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj {

            /*
                MAIN
                Console.Write("Digite a quantidade de produtos: ");
                int n = int.Parse(Console.ReadLine());

                Product[] vect = new Product[n];

                for (int i = 0; i < n; i++) {
                    Console.WriteLine("Nome do produto:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Valor do produto:");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine();
                    vect[i] = new Product { Name = name, Price = price };
                }

                double soma = 0.0;
                for(int i = 0; i < n; i++) {
                    soma += vect[i].Price;
                }
                double media = soma / n;
                Console.WriteLine("Preço médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
            */

    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
    }
}

