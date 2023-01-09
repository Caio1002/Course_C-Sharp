using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            DateTime d1 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
            DateTime d2 = new DateTime(2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);

            Console.WriteLine("d1: " + d1);
            Console.WriteLine("d2 kind: " + d2.Kind);
            Console.WriteLine("d3 to local: " + d3.ToLocalTime());
            Console.WriteLine("d4 to utc: " + d3.ToUniversalTime());

        }
    }
}