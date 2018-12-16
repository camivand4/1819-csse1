namespace deel2
{
    public class Opleiding : Details
    {

        private string afkortingCampus;
        protected int campusNummer;
        public string Campus
        {
            get;
            set;
        }
        public string Opleidingsnaam
        {
            get;
            set;
        }
        string GetWifiCode()
        {
            return "code";
        }

        public Opleiding()
        {
            this.afkortingCampus = this.Campus.Substring(0,3);
        }

        public override string ToString()
        {
            return string.Format("Campus {0} - campusNummer", this.Campus, this.campusNummer);
        }
    }
}