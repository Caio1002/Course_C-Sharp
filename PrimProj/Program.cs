using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            //Duração de tempo
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);

            TimeSpan t2 = new TimeSpan(900000000L);
            Console.WriteLine(t2);

            TimeSpan t3 = TimeSpan.FromDays(1.5);
            Console.WriteLine(t3);

            TimeSpan t4 = TimeSpan.FromHours(1.7);
            Console.WriteLine(t4);

        }
    }
}