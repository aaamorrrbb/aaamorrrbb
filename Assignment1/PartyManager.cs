using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class PartyManager
    {

        private string[] guestList = new string[] { };
        private int numOfElements = 0;
        private double costPerPerson;
        private double feePerPerson;
        public PartyManager(int maxNumberOfGuests)
        {
            guestList = new string[maxNumberOfGuests];
        }

        public double CostPerPerson { get => costPerPerson; set => costPerPerson = value; }
        public double FeePerPerson { get => feePerPerson; set => feePerPerson = value; }
        public int Count
        {
            get
            {
                return numOfElements;
            }
        }

        /// <summary>
        /// Adds guest to the list
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool success = false;

            if (numOfElements < guestList.Length)
            {
                guestList[numOfElements] = FullName(firstName, lastName);
                numOfElements++;
                success = true;
            }
            return success;
        }

        public double CalcTotalCost()
        {
            return CostPerPerson * NumOfGuests();
        }

        public double CalcTotalFees()
        {
            return FeePerPerson * NumOfGuests();
        }

        // The following method will be developed in the future.
        private bool ChangedAt(int index, string firstName, string lastName)
        {
            if (CheckIndex(index))
            {
                guestList[index] = FullName(firstName, lastName);
                return true;
            }

            return false;
        }

        private bool CheckIndex(int index)
        {
            return (index >= 0) && (index < guestList.Length);
        }


        private int FindVacantPos()
        {
            int foundPos = -1;
            for (int i = 0; i < guestList.Length; i++)
            {
                if (string.IsNullOrEmpty(guestList[i]))
                {
                    foundPos = i;
                    break;
                }
            }
            return foundPos;
        }

        public string FullName(string firstName, string lastName)
        {
            return string.Format("{0}, {1}", lastName.ToUpper(), firstName);
        }

        public string[] GetGuestList()
        {
            string[] gl = new string[] { };
            int j = 0;
            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    gl[j] = guestList[i];
                    j++;
                }
            }
            return gl;
        }

        public string GetItemAt(int index)
        {
            return guestList[index];
        }

        public void MoveELementsOneStepToTheLeft(int index)
        {
            for (int i = index + 1; i < guestList.Length; i++)
            {
                guestList[i - 1] = guestList[i];
                guestList[i] = string.Empty;
            }
        }

        public int NumOfGuests()
        {
            return Count;
        }

        public bool DeleteAt(int index)
        {
            guestList[index] = string.Empty;
            numOfElements--;
            MoveELementsOneStepToTheLeft(index);

            return true;
        }
    }
}
