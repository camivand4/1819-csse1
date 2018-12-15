using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Author auteur1 = new Author("Jan PietJoris", "Willen_varen@gmail.com", 'M');
            Book boek1 = new Book("Mannen met baarden", auteur1, 8.0, 1);
           
           Console.WriteLine(boek1.Print());
            Console.WriteLine(boek1.getName());
            Console.WriteLine(boek1.getAuthor());
            Console.WriteLine(boek1.getPrice());
            Console.WriteLine(boek1.getQtyInStock());

            boek1.setPrice(0.0);
            boek1.setQtyInStock(0);
            
            Console.WriteLine(boek1.Print());
            Console.WriteLine(boek1.getName());
            Console.WriteLine(boek1.getAuthor());
            Console.WriteLine(boek1.getPrice());
            Console.WriteLine(boek1.getQtyInStock());

            Console.WriteLine(boek1.getAuthor());

        }
    }
}
