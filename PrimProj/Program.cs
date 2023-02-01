using PrimProj.Entities;
using PrimProj.Entities.Enums;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace PrimProj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            } catch(DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }

        }
    }
}