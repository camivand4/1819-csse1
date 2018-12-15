using System;

namespace lesweek7
{
    class Prijs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MenuItem menuItem1 = new MenuItem();
            menuItem1.Type = 12;
            menuItem1.Naam = "blauw";
            Console.WriteLine(menuItem1.ToString());

            MenuItem menuItem2 = new MenuItem(30, "rood");
            Console.WriteLine(menuItem2.ToString());
            //auto1.Type = 12;

            Auto auto1 = new Auto();
            Console.WriteLine(auto1.ToString());
        }
    }

    /* internal class MenuItem
    {
        private string Type;
    } */
}
