using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj {
    internal class Quarto {

        /*
            MAIN
            Console.WriteLine("Quantos quartos serão alugados?");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Quarto[] quarto = new Quarto[10];

            for (int i = 0; i < quant; i++) {
                Console.WriteLine($"Aluguel #{i+1}:");
                Console.WriteLine();
                Console.Write("Nome do titular: ");
                string name = Console.ReadLine();
                Console.Write("Email do titular: ");
                string mail = Console.ReadLine();
                Console.Write("Numero do quarto: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine();
                quarto[num] = new Quarto { Nome = name, Email = mail };
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++) {
                if (quarto[i] != null) {
                    Console.WriteLine(i + ": " + quarto[i]);

                }
            }
            */

        public string Nome { get; set; }
        public string Email { get; set; }


        public override string ToString() {
            return " Nome: "
                + Nome
                + " -  Email: "
                + Email;
        }

    }
}
