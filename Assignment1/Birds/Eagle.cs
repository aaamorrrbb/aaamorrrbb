using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Birds
{
    internal class Eagle:Bird
    {
        public string EagleTaxon { get; set; }

        public Eagle(string eagleTaxon)
        {
            EagleTaxon = eagleTaxon;
        }

        public override string ToString()
        {
            var strOut = base.ToString();
            strOut += string.Format("{0,-15} {1,6}\n", "Eagle Taxon:", EagleTaxon);

            return strOut;
        }
    }
}
