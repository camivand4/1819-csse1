using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var genes = Gene.GetArrayOfGenes();
            string [] jamjam = new string[]
            {
                "Plat Water",
                "Cola 25 Cl",
                "Cola 33 Cl",
                "Witte Wijn",
                "Pils",
                "Toast",
                "Kaasplank"
            };
            

            var orderedJamjam = jamjam.OrderBy(s => s.Length);
            foreach(var f in genes)
            {
                Console.WriteLine(f);
            }

            Console.WriteLine(" ");

            var orderedGenes = genes.OrderBy(g => g.Prijs);
            foreach(var f in orderedGenes)
            {
                Console.WriteLine(f);
            } 

            Console.WriteLine("");
            Console.WriteLine("Welke Dish wil je aanspreken?");
            string aanspreekbareDish = Console.ReadLine();
        }
    }
}