namespace Assignment1.Mammals
{
    internal class Wolf : Mammal
    {
        public string HairType { get; set; }

        public Wolf(string hairType)
        {
            HairType = hairType;
        }

        public Wolf(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
        {
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n", "Hair Type:", HairType);

            return strOut;
        }
    }
}
