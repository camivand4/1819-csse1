﻿using System;

namespace week4 {
    class Program {
        static void Main(string[] args) {

            int resultaat =
                Optellen(Optellen(Vermenigvuldigen(Optellen(100, 7), 3), Vermenigvuldigen(Delen(Optellen(406, 7367), 69), 5)),
                    Optellen(Aftrekken(Vermenigvuldigen(73, 41), 39), Aftrekken(Vermenigvuldigen(7, 8), 19)));

            Console.WriteLine("Het resultaat is: " + resultaat);

            int resultaat2 =
                Optellen(Optellen(Vermenigvuldigen(Optellen(100, 8), 3), Vermenigvuldigen(Delen(Optellen(406, 7367), 69), 5)),
                    Optellen(Aftrekken(Vermenigvuldigen(73, 41), 39), Aftrekken(Vermenigvuldigen(7, 8), 19)));

            Console.WriteLine("Het resultaat is: " + resultaat2);

            int Optellen(int _a, int _b) {
                return _a + _b;
            }

            int Aftrekken(int _a, int _b) {
                return _a - _b;
            }

            int Vermenigvuldigen(int _a, int _b) {
                return _a * _b;
            }

            int Delen(int _a, int _b) {
                return _a / _b;
            }

            if (resultaat == 3872) {
                Console.WriteLine("het resultaat is perfect!");
            } else if (resultaat > 3872) {
                Console.WriteLine("Het resultaat is niet correct!");
            }

            if (resultaat2 == 3872) {
                Console.WriteLine("het resultaat is perfect!");
            } else if (resultaat2 > 3872) {
                Console.WriteLine("Het resultaat is te groot!");
            } else {
                Console.WriteLine("het resulataat is niet correct!");
            }

            // for (int teller = 0; teller < 10; teller++) {
            //     Console.WriteLine("De teller is nu: " + teller);
            //     Console.WriteLine( + teller);

            // }
            
            tafel(1);
            tafel(2);
            tafel(3);

            int getal3 = 4;
            do{
                Console.WriteLine("De waarde van het getal is: " + getal3);
                getal3++; 
            } while (getal3 > 5);

            int getal4 = 4;
            while(getal4 < 5)
            {
                Console.WriteLine ("De waarde van het getal is: " + getal4);
                getal4++;
            }

            void tafel (int getal)
            {
                Console.WriteLine("De tafel van: " + getal);
                for (int teller = 0; teller < 11; teller++)
                {
                    int resultaat3 = teller * getal;
                    Console.WriteLine(teller + " * " + getal + " = " + resultaat3);
                }
            }
        }
    }
}