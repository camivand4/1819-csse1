﻿using System;

namespace week4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int resultaat = 
            Optellen(Optellen(Vermenigvuldigen(Optellen(100, 7), 3), Vermenigvuldigen(Delen(Optellen(406, 7367), 69), 5)), 
            Optellen(Aftrekken(Vermenigvuldigen(73, 41), 39), Aftrekken(Vermenigvuldigen(7, 8) , 19)));

            Console.WriteLine("Het resultaat is: " + resultaat);

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