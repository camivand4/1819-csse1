namespace deel2
{
    public class Gebruiker
    {
        public string wachtwoord;
        public string Gebruikersnaam
        {
            get;
            set;
        }
        public virtual string GenereerWachtwoord()
        {
            return "Gebruiker - wachtwoord";
        }

        public void GenereerGebruikersnaam()
        {
            this.Gebruikersnaam = "test";
        }

        public Gebruiker()
        {
            this.wachtwoord = GenereerWachtwoord();
        }
    }
}