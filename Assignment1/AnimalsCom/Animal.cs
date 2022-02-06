using System;

namespace Assignment1
{
    public class Animal
    {
        public string Id;
        public string Name { get; set; }
        public int Age { get; set; }
        public CategoryEnum Category { get; set; }
        public GenderEnum Gender { get; set; }

        public Animal()
        {
            Reset();
        }

        public void Reset()
        {
            this.Id = "0000";
            this.Name = string.Empty;
            this.Gender = GenderEnum.Unknown;
            this.Age = 0;
            Category = CategoryEnum.Mammal;

        }


        public string id
        {
            set { 
                    if(value.Length > 0)
                        id = value;
            }
        }

        public override string ToString()
        {
            //return base.ToString();
            string strOut = string.Format("{0, -15} {1, 6}\n{2, -15} {3, 6}\n{4, -15} {5, 6}\n", "ID:", Id, "Name:", Name, "Age:", Age);
            strOut += string.Format("{0,-15} {1,6}\n{2, -15} {3, 6}\n", "Gender:",Enum.GetName(typeof(GenderEnum),Gender) , "Category:", Enum.GetName(typeof(CategoryEnum),Category));

            return strOut;
        }
    }

}