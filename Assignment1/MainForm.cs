using Assignment1.AnimalsCom;
using Assignment1.Birds;
using Assignment1.Mammals;
using Assignment1.models.AnimalsCom;
using Assignment1.models.Birds;
using Assignment1.models.Mammals;
using System;
using System.ComponentModel;
using System.Windows.Forms;

/// <summary>
/// This is the main class for the application which is an interface for user inputs and Animal object.
/// </summary>

namespace Assignment1
{
    public partial class MainForm : Form
    {
        AnimalManager animalManager = new AnimalManager();  //To be used in the next version

        public MainForm()
        {
            InitializeComponent();
            InitilizeGui();
        }

        private void InitilizeGui()
        {
            //input controls
            ClearTextBoxes();
            listGender.Items.AddRange(typeof(GenderEnum).GetEnumNames());
            listGender.SelectedIndex = 0;
            listCategoryType.Items.AddRange(typeof(CategoryEnum).GetEnumNames());
            listCategoryType.SelectedIndex = 0;
            listColour.Items.AddRange(typeof(ColorsEnum).GetEnumNames());
            listColour.SelectedIndex = 0;
        }

        private void ClearTextBoxes()
        {
            tbAge.Clear();
            tbName.Clear();
            tbSpeciesSpec.Clear();
            tbAnimalSpec1.Clear();
            tbAnimalSpec2.Clear();
            
            listSpecies.Items.Clear();

        }

        private Animal ReadInputs()
        {
            CategoryEnum category = (CategoryEnum)Enum.Parse(typeof(CategoryEnum), listCategoryType.SelectedItem.ToString());
            Animal animal = null;

            switch (category)
            {
                case CategoryEnum.Mammal:
                    animal = CreateMammal();
                    break;
                case CategoryEnum.Bird:
                    animal = CreateBird();
                    break;
            }
            if(animal != null)
            {
                ReadCommonValues(ref animal);
            }

            return animal;
            }

        private Animal CreateBird()
        {
            Animal animal = null;
            int flyingSpeed;

            if (!int.TryParse(tbAnimalSpec1.Text, out flyingSpeed))
            {
                MessageBox.Show("Give a valid flying speed!");
                tbAnimalSpec1.Focus();
            }

            double lengthOfWings = 0;
            if (!double.TryParse(tbAnimalSpec2.Text, out lengthOfWings))
            {
                MessageBox.Show("Give a valid length of wings!");
                tbAnimalSpec2.Focus();
            }

            BirdSpecies species = (BirdSpecies)Enum.Parse(typeof(BirdSpecies), listSpecies.SelectedItem.ToString());

            animal = BirdFactory.CreateBird(species, flyingSpeed, lengthOfWings);

            if (species == BirdSpecies.Dove)
            {
                ((Dove)animal).DoveTaxon = tbSpeciesSpec.Text;
            }

            if (species == BirdSpecies.Eagle)
            {
                ((Eagle)animal).EagleTaxon = tbSpeciesSpec.Text;
            }

            return animal;
        }

        private void ReadCommonValues(ref Animal animal)
        {
            animal.Name = tbName.Text;
            int age = 0;

            if(int.TryParse(tbAge.Text, out age))
                animal.Age = age;

            animal.Gender = (GenderEnum)Enum.Parse(typeof(GenderEnum),listGender.SelectedItem.ToString());
            animal.Category = (CategoryEnum)Enum.Parse(typeof(CategoryEnum),listCategoryType.SelectedItem.ToString());
            animal.Color = (ColorsEnum)Enum.Parse(typeof(ColorsEnum), listColour.SelectedItem.ToString());
        }

        private Animal CreateMammal()
        {
            Animal animal = null;
            int numOfTeeth = 0;
            
            if(!int.TryParse(tbAnimalSpec1.Text, out numOfTeeth))
            {
                MessageBox.Show("Give a valid number of teeth!");
                tbAnimalSpec1.Focus();
            }

            double tailLength = 0;
            if(!double.TryParse(tbAnimalSpec2.Text, out tailLength))
            {
                MessageBox.Show("Give a valid tail length!");
                tbAnimalSpec2.Focus();
            }

            MammalSpecies species = (MammalSpecies)Enum.Parse(typeof(MammalSpecies), listSpecies.SelectedItem.ToString());

            animal = MammalFactory.CreateMammal(species, numOfTeeth, tailLength);

            if(species == MammalSpecies.Dog)
            {
                ((Dog)animal).Breed = tbSpeciesSpec.Text;
            }

            if (species == MammalSpecies.Wolf)
            {
                ((Wolf)animal).HairType = tbSpeciesSpec.Text;
            }
            return animal;
        }

        private CategoryEnum ReadCategory()
        {
           // Not used for now.
           return new CategoryEnum();
        }

        private bool AreInputsValid()
        {

            bool ok = !string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbAnimalSpec1.Text) && !string.IsNullOrEmpty(tbAnimalSpec2.Text) && !string.IsNullOrEmpty(tbAge.Text) && listCategoryType.SelectedIndex != -1 && listSpecies.SelectedIndex != -1 && listGender.SelectedIndex != -1;
            if (ok)
                return true;
            else
            {
                MessageBox.Show("Not all fields are filled/selected", "Validation Error!");
                return false;
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
                MessageBox.Show("This should be filled!");
        }

        private void tbAge_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(tbAge.Text, out _))
                MessageBox.Show("This should be a number!");
        }

        private void listCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSpecies.Items.Clear();
            switch(listCategoryType.SelectedItem.ToString())
            {
                case "Mammal": 
                    listSpecies.Items.AddRange(typeof(MammalSpecies).GetEnumNames());
                    gbAnimalCatSpec.Text = "Mammal Specification";
                    lblAnimalSpec.Text = "Number Of Teeth";
                    lblAnimalSpec2.Text = "Length of Tail";
                    break;
                case "Bird": 
                    listSpecies.Items.AddRange(typeof(BirdSpecies).GetEnumNames());
                    gbAnimalCatSpec.Text = "Bird Specification";
                    lblAnimalSpec.Text = "Flying Speed";
                    lblAnimalSpec2.Text = "Length of Wings";
                    break;
            }
                 
        }

        private void listSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listSpecies.SelectedItem.ToString())
            {
                case "Dog":
                    lblSpeciesSpec.Text = "Breed";
                    gbSpeciesSpec.Text = "Dog Specifications";
                    break;
                case "Wolf":
                    lblSpeciesSpec.Text = "Hair Type";
                    gbSpeciesSpec.Text = "Wolf Specifications";
                    break;
                case "Dove":
                    lblSpeciesSpec.Text = "Dove Taxon";
                    gbSpeciesSpec.Text = "Dove Specifications";
                    break;
                case "Eagle":
                    lblSpeciesSpec.Text = "Eagle Taxon";
                    gbSpeciesSpec.Text = "Eagle Specifications";
                    break;
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (AreInputsValid())
            {
                Animal animal = ReadInputs();
                rtbAddAnimal.Text = animal.ToString();
            }

        }

        private void lbGender_Validating(object sender, CancelEventArgs e)
        {
            if(listGender.SelectedIndex == -1)
                MessageBox.Show("Select a gender type!");
        }
    }


}
