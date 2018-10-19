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
            for (int i = 0; i < 30; i++) {
                Console.WriteLine(Fibonacci(i));
            }
        }
    }
}