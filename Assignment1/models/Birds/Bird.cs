using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.models.Birds
{
    public class Birds: Animal
    {
        public double flyingSpeed { get; set; }
        public double lengthOfWings { get; set; }

        public Birds() { }

        public Birds(double flyingSpeed, double lengthOfWings)
        {
            this.flyingSpeed = flyingSpeed;
            this.lengthOfWings = lengthOfWings;
        }
    }
}
