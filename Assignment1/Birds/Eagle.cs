namespace Assignment1.Birds
{
    internal class Eagle:Bird
    {
        public string EagleTaxon { get; set; }

        public Eagle(string eagleTaxon)
        {
            EagleTaxon = eagleTaxon;
        }

        public Eagle(double flyingSpeed, double lengthOfWings) : base(flyingSpeed, lengthOfWings)
        {
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n", "Eagle Taxon:", EagleTaxon);

            return strOut;
        }
    }
}
