using Assignment1.Birds;

namespace Assignment1.models.Birds
{
    internal class BirdFactory
    {
        /// <summary>
        /// A static method which takes Bird parameters and returns corresponding speice object.
        /// </summary>
        /// <param name="species"></param>
        /// <param name="flyingSpeed"></param>
        /// <param name="lengthOfWings"></param>
        /// <returns></returns>
        internal static Bird CreateBird(BirdSpecies species, int flyingSpeed, double lengthOfWings)
        {
            Bird bird = null;

            switch (species)
            {
                case BirdSpecies.Dove:
                    bird = new Dove(flyingSpeed, lengthOfWings);
                    break;
                case BirdSpecies.Eagle:
                    bird = new Eagle(flyingSpeed, lengthOfWings);
                    break;
            }

            return bird;
        }
    }
}
