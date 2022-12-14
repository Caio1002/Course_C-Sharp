using System.Globalization;

namespace PrimProj {
    internal class Funcionario {
        /*
         MAIN
            Funcionario func = new Funcionario();

            Console.WriteLine("Entre com os dados do funcionário: ");
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            func.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(func);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine());
            func.AumentaSalario(porc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
        */

        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }

        public void AumentaSalario(double porcentagem) {
            Salario = Salario + (Salario * (porcentagem / 100));
        }

        public override string ToString() {
            return
            "Funcionário: "
            + Nome
            + ", "
            + "Salario: R$"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
