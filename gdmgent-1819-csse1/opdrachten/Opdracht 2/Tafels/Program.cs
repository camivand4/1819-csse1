﻿using System;

namespace tafels
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int resultaat = 
            Optellen(Optellen(Vermenigvuldigen(Optellen(100, 7), 3), Vermenigvuldigen(Delen(Optellen(406, 7367), 69), 5)), 
            Optellen(Aftrekken(Vermenigvuldigen(73, 41), 39), Aftrekken(Vermenigvuldigen(7, 8), 19)));

            Console.WriteLine("Het resultaat is: " + resultaat);

            if (resultaat == 3872)
            {
                Console.WriteLine("Het resultaat is perfect!");

            }
            else if(resultaat > 3872)
            {
                Console.WriteLine("Het resultaat is te groot");
            }
            else 
            {
                Console.WriteLine("Het resultaat is te laag");
            }

            for (int teller = 0; teller< 11; teller++)
            {
                Console.WriteLine("De teller is nu:" + teller);
            }
            Program program = new Program();
            Console.WriteLine("schrijf een getal");
            int nieuw =Convert.ToInt32(Console.ReadLine());

            tafel(1);
            tafel(2);
            tafel(3);
            tafel(nieuw);


            


           void tafel(int getal)
            {
                Console.WriteLine("De tafel van: " + getal );
                for (int teller = 0; teller < 11; teller++)
                {
                    int resultaat3 = teller * getal;
                    Console.WriteLine(teller + "*" + getal + "=" + resultaat3);
                    
                }
            }

            int Optellen (int _a, int _b) {
                return _a + _b;
            }

            int Aftrekken (int _a, int _b) {
                return _a - _b;
            }

            int Vermenigvuldigen (int _a, int _b) {
                return _a * _b;
            }

            int Delen (int _a, int _b) {
                return _a / _b;
            }
        }
    }
}