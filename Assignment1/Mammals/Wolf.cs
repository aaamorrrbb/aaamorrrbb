using Assignment1.models.Mammals;

namespace Assignment1.Mammals
{
    internal class Wolf : Mammal
    {
        public string HairType { get; set; }

        public Wolf(string hairType)
        {
            HairType = hairType;
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n", "Hair Type:", HairType);

            return strOut;
        }
    }
}
