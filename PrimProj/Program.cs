using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG  ";
            Console.WriteLine("Original: " + original + " - ");

            string s1 = original.ToUpper();
            Console.WriteLine("Maiuscula: " + s1 + " - ");

            string s2 = original.ToLower();
            Console.WriteLine("Minuscula: " + s2 + " - ");

            //apagar espaços em branco
            string s3 = original.Trim();
            Console.WriteLine("Sem espaço: " + s3 + "- ");

            //procura string
            int n1 = original.IndexOf("bc");
            Console.WriteLine("bc encontrado " + n1 + " vezes.");

            int n2 = original.LastIndexOf("bc");
            Console.WriteLine("Localização do ultimo registro 'bc' na string: " + n2);

            //cortar string
            string s4 = original.Substring(3);
            Console.WriteLine("Substring: " + s4);

            //cortar string
            string s5 = original.Substring(3, 5);
            Console.WriteLine("Substring inicio e fim: " + s5);

            //substituir string
            string n6 = original.Replace('a', 'x');
            Console.WriteLine("Substituição: " + n6);

            string n7 = original.Replace("abc", "xy");
            Console.WriteLine("Substituição: " + n7);

            //testar string vazia
            bool b1 = String.IsNullOrEmpty(original);
            Console.WriteLine("Nulo? " + b1);

            //testar espaço em branco
            bool b2 = String.IsNullOrWhiteSpace(original);
            Console.WriteLine("Testar espaço em branco: " + b2);

        }
    }
}