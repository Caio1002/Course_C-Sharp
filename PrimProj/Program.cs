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

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2022 13:45:02"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("10/02/2023 03:48:59"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

        }
    }
}