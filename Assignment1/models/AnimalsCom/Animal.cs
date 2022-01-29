using System;

namespace Assignment1.models
{
    public class Animal
    {
        public string Id;
        public string Name { get; set; }
        public int Age { get; set; }
        public Category Category { get; set; }
        public GenderEnum Gender { get; set; }

        public Animal()
        {
            Reset();
        }

        public void Reset()
        {
            this.Name = string.Empty;
            this.Gender = GenderEnum.Unknown;
            this.Age = 0;
            Category = Category.Mammal;

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
            string strOut = string.Format("{0.-15} {1,6}\n{2, -15} {3, 6}\n{4, -15} {5, 6}\n", "ID:", Id, "Name:", Name, "Age:", Age);
            strOut += string.Format("{0.-15} {1,6}\n{2, -15} {3, 6}\n{4, -15} {5, 6}\n")

            return strOut;
        }
    }

}