using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

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

        }
    }
}