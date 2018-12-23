using System;

namespace part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");

            VormFactory vormFactory = new VormFactory();
            IVorm vormA = vormFactory.GetVorm("Vierkant"); 

            vormA.Teken();
        }
    }
}
