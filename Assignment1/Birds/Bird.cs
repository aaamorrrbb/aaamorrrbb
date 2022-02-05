namespace Assignment1.Birds
{
    public class Bird: Animal
    {
        public double flyingSpeed { get; set; }
        public double lengthOfWings { get; set; }

        public Bird() { }

        public Bird(double flyingSpeed, double lengthOfWings)
        {
            id = "B001";
            this.flyingSpeed = flyingSpeed;
            this.lengthOfWings = lengthOfWings;
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n{2, -15} {3, 6}\n", "Flying Speed:", flyingSpeed.ToString(), "Length of Wings:", lengthOfWings.ToString());

            return strOut;
        }
    }
}
