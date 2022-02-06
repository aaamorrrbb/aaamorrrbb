namespace Assignment1.Birds
{
    public class Bird: Animal
    {
        public double flyingSpeed { get; set; }
        public double lengthOfWings { get; set; }

        public Bird() { }

        public Bird(double flyingSpeed, double lengthOfWings)
        {
            Id = "B001";
            this.flyingSpeed = flyingSpeed;
            this.lengthOfWings = lengthOfWings;
        }

        //Will be developed in the next version         
/*        public Bird CreateBird(BirdSpecies birdSpecies, double flyingSpeed, double lengthOfWings)
        {
            Animal bird = null;
            switch(birdSpecies)
            {
                case BirdSpecies.Dove:
                    bird = new Dove(flyingSpeed, lengthOfWings);
                    break;
                case BirdSpecies.Eagle:
                    bird = new Eagle(flyingSpeed, lengthOfWings);
                    break;
            }

            return (Bird)bird;
        }*/

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n{2, -15} {3, 6}\n", "Flying Speed:", flyingSpeed.ToString(), "Length of Wings:", lengthOfWings.ToString());

            return strOut;
        }
    }
}
