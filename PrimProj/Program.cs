using System;
using System.Globalization;

namespace PrimProj
{
    class Program
    {
        static void Main(string[] args)
        {

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


        }
    }
}