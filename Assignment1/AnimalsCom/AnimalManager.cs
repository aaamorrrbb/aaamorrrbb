using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.models.AnimalsCom
{
    internal class AnimalManager
    {
        private List<Animal> animalList;
        /*        private int mammalId = 100;
                private int birdId = 100;*/

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
