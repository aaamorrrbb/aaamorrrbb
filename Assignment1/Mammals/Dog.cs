using Assignment1.models.Mammals;

namespace Assignment1.Mammals
{
    internal class Dog: Mammal
    {
        public string Breed { get; set; }

        public Dog(string breed)
        {
            Breed = breed;
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n", "Breed:", Breed);

            return strOut;
        }
    }
}
