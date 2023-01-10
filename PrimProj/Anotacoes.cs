using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimProj {
    internal class Anotacoes {

        /*
        VAR
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        */

        /*
        Switch Case
        int x = int.Parse(Console.ReadLine());
            string day;

            switch (x) {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda-feira";
                    break;
                case 3:
                    day = "Terça-feira";
                    break;
                case 4:
                    day = "Quarta-feira";
                    break;
                case 5:
                    day = "Quinta-feira";
                    break;
                case 6:
                    day = "Sexta-feira";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "Inválido";
                    break;
            }

            Console.WriteLine(day);
        */

        /*
        Condição ternária
        /*(CONDIÇÃO) ? VALOR_SE_VERDADEIRO : VALOR_SE_FALSO*/
        /*
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

        Console.WriteLine(desconto);
        */

        /*
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
        */

        /*
        DateTime d1 = DateTime.Now;//marcar hora atual
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);//marcar hora em ticks desde 01 Jan

            DateTime d2 = new DateTime(2019, 10, 14, 11, 02, 55);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2019, 10, 14, 11, 02, 55, 500);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Today;
            Console.WriteLine(d4);

            DateTime d5 = DateTime.Parse("15/08/2020");//br
            Console.WriteLine(d5);

            DateTime d6 = DateTime.Parse("2000-07-10 13:01:57");
            Console.WriteLine(d6);

            DateTime d7 = DateTime.ParseExact("2002-09-19", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d7);
        */

        /*
        TimeSpan
        //Duração de tempo
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);

            TimeSpan t2 = new TimeSpan(900000000L);
            Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t3);

            TimeSpan t4 = TimeSpan.FromHours(1.7);
            Console.WriteLine(t4);

            DateTime x = DateTime.Now;
            DateTime y = d.AddDays(7);
            Console.WriteLine(x);
        */

        /*
        //DateTime
            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d3 to local: " + d3.ToLocalTime());
            Console.WriteLine("d4 to utc: " + d3.ToUniversalTime());

            //ISO 8601
            // yyyy-MM-ddTHH:mm:ssz 
        */

    }
}
