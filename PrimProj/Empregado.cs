using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj {
    class Empregado {

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
