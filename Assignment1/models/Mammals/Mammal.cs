using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.models.Mammals
{
    internal class Mammal
    {
        public int numOfTeeth { get; set; }
        public double tailLength { get; set; }
        public ColorsEnum color { get; set; }

        public Mammal(int numOfTeeth, double tailLength, ColorsEnum color, Dog dog, Monkey monkey)
        {
            this.numOfTeeth = numOfTeeth;
            this.tailLength = tailLength;
            this.color = color;
            this.dog = dog;
            this.monkey = monkey;
        }

        public Dog dog { get; set; }
        public Monkey monkey { get; set; }
    }
}
