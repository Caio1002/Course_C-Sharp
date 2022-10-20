using System.Globalization;

namespace PrimProj
{
    internal class Funcionario
    {

        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentaSalario(double porcentagem)
        {
            Salario = Salario + (Salario * (porcentagem / 100));
        }

        public override string ToString()
        {
            return
            "Funcionário: "
            + Nome
            + ", " 
            + "Salario: R$"
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
