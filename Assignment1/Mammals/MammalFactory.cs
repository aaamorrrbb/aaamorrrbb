using Assignment1.Mammals;

namespace Assignment1.models.Mammals
{
    internal class MammalFactory
    {
        /// <summary>
        /// A static method which takes Mammal parameters and returns corresponding speice object.
        /// </summary>
        /// <param name="species"></param>
        /// <param name="numOfTeeth"></param>
        /// <param name="tailLength"></param>
        /// <returns></returns>
        internal static Mammal CreateMammal(MammalSpecies species, int numOfTeeth, double tailLength)
        {
            Mammal m = null;

            switch(species)
            {
                case MammalSpecies.Dog:
                    m = new Dog(numOfTeeth, tailLength);
                    break;
                case MammalSpecies.Wolf:
                    m = new Wolf(numOfTeeth, tailLength);
                    break;
            }


            return m;
        }
    }
}
