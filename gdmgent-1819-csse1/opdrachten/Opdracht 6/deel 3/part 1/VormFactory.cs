namespace part_1
{
    public class VormFactory
    {
        // aanmaken van instantie type cirkel 👌
        public IVorm GetVorm(string typeVorm)
        {
            if(typeVorm == null)
            {
                return null;
            }
            else if (typeVorm.Equals("Vierkant") )
            //else if (typeVorm == "Cirkel" )
            {
                return new Vierkant();
                //class Cirkel
            }

            return null;
        }
    }
}