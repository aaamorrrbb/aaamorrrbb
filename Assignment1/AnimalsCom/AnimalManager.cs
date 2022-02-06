using System.Collections.Generic;

namespace Assignment1.models.AnimalsCom
{
    /// <summary>
    /// Not to be used in this version as the application handles just oneobject.
    /// </summary>
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
                Id = animal.Id,
                Name = animal.Name,
            });

            return success;
        }

    }
}
