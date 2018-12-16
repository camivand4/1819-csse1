namespace deel2
{
    public class Student : Persoon
    {

        public Opleiding Opleiding
        {
            get;
            set;
        }
        public string Emailadres
        {
            get;
            set;
        }
        public override string GenereerWachtwoord()
        {
            return "Student - wachtwoord";
        }
    }
}