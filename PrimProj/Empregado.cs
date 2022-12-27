using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj {
    class Empregado {

        /*
            MAIN
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
            */

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregado(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AcrescentarSalario(double porcentagem) {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString() {
            return "ID:"
                + Id
                + ", Nome: "
                + Nome
                + ", Salario: R$ "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
