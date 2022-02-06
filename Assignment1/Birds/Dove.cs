using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Birds
{
    internal class Dove: Bird
    {
        public string DoveTaxon { get; set; }

        public Dove(string doveTaxon)
        {
            DoveTaxon = doveTaxon;
        }

        public Dove(double flyingSpeed, double lengthOfWings) : base(flyingSpeed, lengthOfWings)
        {
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n", "Number of Teeth:", DoveTaxon);

            return strOut;
        }
    }
}
