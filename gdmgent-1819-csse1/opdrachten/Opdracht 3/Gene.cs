using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Gene
{
    public string Dish {get; set;}
    public decimal Prijs {get; set;} 

public static Gene[] GetArrayOfGenes()
{
    Gene [] genes = new Gene[]{
        new Gene{Dish = "Plat Water", Prijs = 1.0m },
        new Gene{Dish = "Cola 25 Cl", Prijs = 1.5m },
        new Gene{Dish = "Cola 33 Cl", Prijs = 2.0m },
        new Gene{Dish = "Witte Wijn", Prijs = 3.0m },
        new Gene{Dish = "Pils", Prijs = 2.0m },
        new Gene{Dish = "Toast", Prijs = 5.0m },
        new Gene{Dish = "Kaasplank", Prijs = 4.0m },
    };
    return genes;
}

public override string ToString()
{
    return $"Dish: {Dish}\tPrijs: {Prijs}";
}
}