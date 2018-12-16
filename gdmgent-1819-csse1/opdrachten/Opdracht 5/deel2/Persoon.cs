namespace deel2
{
    public class Persoon : Gebruiker
    {
        protected string naam;
        protected string voornaam;
        public string Naam
        {
            get
            {
                return this.naam;
            }
            set
            {
                this.naam = value;
            }
        }
        // public DateTime geboorteDatum
        // {
        //     get;
        //     set;
        // }

        public string Voornaam
        {
            get;
            set;
        }
        public string volledigeNaam
        {
            get;
        }
        public override string GenereerWachtwoord()
        {
            return "Persoon + wachtwoord";
        }

        public string GenereerWachtwoord(int input)
        {
            return "GenereerWachtwoord2";
        }

        public string GenereerWachtwoord(string input)
        {
            return "GenereerWachtwoord2";
        }

        public override string ToString()
        {
            return "override string ToString";
        }
        public string Leeftijd(){
            return "x aantal jaar";
        }


    }
}