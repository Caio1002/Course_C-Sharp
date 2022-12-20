using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj {
    internal class Quarto {
        
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
