using System;

namespace opdrachten {
    class Program {

        static int Fibonacci(int n) {

            int a = 0;
            int b = 1;

            for (int i = 0; i < n; i++) {

                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        static void Main(string[] args) {

        Console.WriteLine("Geef een getal in");
        int getal = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < getal; i++) {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}