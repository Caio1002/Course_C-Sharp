using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

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

        }
    }
}