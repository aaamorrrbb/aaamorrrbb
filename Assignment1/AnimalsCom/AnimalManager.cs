using System.Collections.Generic;

namespace Assignment1.models.AnimalsCom
{
    internal class AnimalManager
    {
        private List<Animal> animalList;

        public AnimalManager() => animalList = new List<Animal>();

        public bool AddAnimal(Animal animal)
        {
            bool success = false;


            animalList.Add(new Animal
            {
                Age = animal.Age,
                Category = animal.Category,
                Gender = animal.Gender,
                id = animal.Id,
                Name = animal.Name,
            });

            return success;
        }

    }
}
