class Menu
{
    // velden
    // properties
    // methodes
    // constructors...

    private int type;
    //private bool motor;
    //private string brandstof;
    // Merk
    // Model
    // ...

    // properties

    /*  public int Laadvermogen
    {
        get;
        set;
    } */

    public int Laadvermogen
    {
        get
        {
            return type;
        }
        set
        {
            type  = value;
        }
    }

    public bool Motor
    {
        get;
        set;
    }

    public string Naam { get; set; }

    public Voertuig(int type, string naam)
    {
        //Type = type;
        this.type = type;
        Naam = naam;
    }

    public Voertuig()
    {
    }
    
    public string ToString()
    {
        return "Voertuig met type: " + this.type + ", met naam: " + this.Naam;
    }

}