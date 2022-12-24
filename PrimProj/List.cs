/*
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PrimProj {
    class Program {
        static void Main(string[] args) {

            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Add("Carlos");
            list.Add("João");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Contador da lista: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');        função lambda
            Console.WriteLine("Primeira letra 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');        função lambda
            Console.WriteLine("Ultima letra 'A': " + s1);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("Primeira posição que começa com 'A': " + s1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Ultima posição que começa com 'A': " + s1);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine();
            Console.WriteLine("removeRange------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine();
            Console.WriteLine("remove------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(2);
            Console.WriteLine();
            Console.WriteLine("removeAT------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine();
            Console.WriteLine("removeall------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

        }
    }
}
*/