using System;
using System.Globalization;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {
            /*TESTE FOREACH*/
            string[] vect = new string[] { "Maria", "Pedro", "Ana" };
            foreach(string obj in vect) {
                Console.WriteLine(obj);
            }    
        }
    }
}