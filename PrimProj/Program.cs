using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            Console.Write("Quantidade de empregados a serem registrados: ");
            int quant = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Empregado> lista = new List<Empregado>();

            for (int i = 0; i < quant; i++) {
                Console.WriteLine("Empregado #"+ i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: R$ ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                lista.Add(new Empregado(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Insira o ID do empregado que terá o reajuste de salario: ");
            int ProcId = int.Parse(Console.ReadLine());

            Empregado emp = lista.Find(x => x.Id == ProcId);
            if(emp != null) {
                Console.Write("Digite a porcentagem de reajuste: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AcrescentarSalario(percent);
            } else {
                Console.WriteLine("ID não encontrado!");
            }

            Console.WriteLine();
            Console.WriteLine("Salario de empregado ajustado!");
            foreach(Empregado obj in lista) {
                Console.WriteLine(obj);
            }

        }
    }
}