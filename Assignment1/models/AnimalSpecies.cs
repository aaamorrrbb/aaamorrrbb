namespace Assignment1.models
{
    public enum AnimalSpeciesEnum
    {
        Mammals,
        Birds,
        Reptiles
    }
    public class AnimalSpecies
    {
        public Mammals mammals { get; set; }
        public Birds birds { get; set; }
        public Reptiles reptiles { get; set; }
    }

    public class Reptiles
    {
        public string scalesType { get; set; }
    }

    public class Monkey
    {
        public string toxicId { get; set; }
    }

    public class Dog
    {
        public string breed { get; set; }
    }
}