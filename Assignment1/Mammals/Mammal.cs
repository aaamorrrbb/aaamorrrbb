namespace Assignment1.Mammals
{
    internal class Mammal: Animal
    {
        public int numOfTeeth { get; set; }
        public double tailLength { get; set; }

        public Mammal()
        {
        }

        public Mammal(int numOfTeeth, double tailLength)//, ColorsEnum color)
        {
            Id = "M001";
            this.numOfTeeth = numOfTeeth;
            this.tailLength = tailLength;
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut+= string.Format("{0,-15} {1,6}\n{2, -15} {3, 6}\n", "Number of Teeth:", numOfTeeth.ToString(), "Tail Length:", tailLength.ToString());

            return strOut;
        }
    }
}
