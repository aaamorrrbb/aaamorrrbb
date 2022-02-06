namespace Assignment1.Mammals
{
    internal class Dog: Mammal
    {
        public string Breed { get; set; }

        public Dog(string breed)
        {
            Breed = breed;
        }

        public Dog(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
        {
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n", "Breed:", Breed);

            return strOut;
        }
    }
}
