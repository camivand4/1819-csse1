using System;

namespace opdracht2 {
    class Program {

static void Main(string[] args) {

    Console.WriteLine("Geef een getal in");
    int fact = Convert.ToInt32(Console.ReadLine());
    int  x = 1;
    for (int i = 1; i <= fact; i++)
    {
        x = x * i;
    }
        Console.WriteLine("de faculteit van " + fact + " is: " + x);
}   
}
}