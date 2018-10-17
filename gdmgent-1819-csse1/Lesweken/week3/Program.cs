using System;

namespace week3
{
    class Program
    {
        static void Main(string[] args)
        {
            //het afdrukken van een tekst in de console
            Console.WriteLine("Hello World!");
            // deze applicatie doet nog niets

            //rekenmachine
             int a = 5;
             int b = 6;
             //int c, d;

            int resultaat1 = optellen(a, b);
            int resultaat2 = deling(a, b);
            int resultaat3 = verhogen(a);
        }

       static int optellen(int a, int b)
        {
return a + b;
        }

       static int verhogen(int a)
        {
return a++;
        }

       static int deling(int a, int b)
        {
return a / b;
        }
    }
}
