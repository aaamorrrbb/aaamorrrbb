using Assignment1.Birds;
using Assignment1.Mammals;
using Assignment1.models;
using Assignment1.models.AnimalsCom;
using Assignment1.models.Mammals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//test

namespace Assignment1
{
    public partial class MainForm : Form
    {
        AnimalManager animalManager = new AnimalManager();

        public MainForm()
        {
            InitializeComponent();
            InitilizeGui();
        }

        private void InitilizeGui()
        {
            //input controls
            ClearTextBoxes();
            lbGender.Items.AddRange(typeof(GenderEnum).GetEnumNames());
            listCategoryType.Items.AddRange(typeof(CategoryEnum).GetEnumNames());
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

/*        private void ReadInputs()
        {
            lstAllGuests.Items.Add(string.Format("{0}  {1}", partyManager.Count, partyManager.GetItemAt(partyManager.Count - 1)));
            lblNumberOfGuests.Text = partyManager.Count.ToString();
            lblTotalCosts.Text = partyManager.CalcTotalCost().ToString();
            lblTotalFees.Text = partyManager.CalcTotalFees().ToString();
            lblSurplus.Text = (partyManager.CalcTotalFees() - partyManager.CalcTotalCost()).ToString();
        }*/

        private void ReadInputs()
        {

        }

        private bool AreInputsValid()
        {
            if (double.TryParse(tbAge.Text, out _) &&

               int.TryParse(tbName.Text, out _))
                return true;
            else
            {
                MessageBox.Show("Some input fields are invalid!");
                return false;
            }
        }

        private void tbMaxNumOfGuests_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbName.Text, out _))
                MessageBox.Show("This should be a number!");
        }

        private void tbCostPerPerson_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(tbAge.Text, out _))
                MessageBox.Show("This should be a number!");
        }

        private void tbFeePerPerson_Validating(object sender, CancelEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
/*            if (IsValidName(tbFirstName.Text) && IsValidName(tbLastName.Text))
            {
                bool ok = partyManager.AddNewGuest(tbFirstName.Text, tbLastName.Text);
                if (!ok)
                {
                    MessageBox.Show("The guest list  is full. No new guests!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    ReadInputs();

            }*/
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
/*            if (!IsValidName(tbFirstName.Text))
                MessageBox.Show("First name should not be left empty!");*/
        }

        private bool IsValidName(string text)
        {
            if (!string.IsNullOrEmpty(text))
                return true;
            return false;
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
/*            if (!IsValidName(tbLastName.Text))
                MessageBox.Show("Last name should not be left empty!");*/
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
/*            lstAllGuests.Items.Clear();
            if (AreInputsValid())
            {
                int maxNumberOfGuests = int.Parse(tbName.Text);
                partyManager = new PartyManager(maxNumberOfGuests);

                partyManager.CostPerPerson = double.Parse(tbAge.Text);
                partyManager.FeePerPerson = double.Parse("02");
                gbInviteGuest.Enabled = true;

                tbFirstName.Clear();
                tbLastName.Clear();

                MessageBox.Show(string.Format("Party list with space for {0} guests created!", maxNumberOfGuests, "Success"));

            }
            else
            {
                MessageBox.Show("Invalid input! Try again!");
            }*/
        }

        private void lstAllGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSpecies.Items.Clear();
            switch(listCategoryType.SelectedItem.ToString())
            {
                case "Mammal": 
                    listSpecies.Items.AddRange(typeof(MammalSpecies).GetEnumNames());
                    lblAnimalSpec.Text = "Number Of Teeth";
                    lblAnimalSpec2.Text = "Length of Tail";
                    break;
                case "Bird": 
                    listSpecies.Items.AddRange(typeof(BirdSpecies).GetEnumNames());
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
            Object species;
            switch (listSpecies.SelectedItem.ToString())
            {
                case "Dog":
                    rtbAddAnimal.Text = (new Dog(tbSpeciesSpec.Text.ToString())
                    {
                        Name = tbName.Text,
                        Age = Convert.ToInt32(tbAge.Text),
                        //Gender = (GenderEnum)lbGender.SelectedItem,
                   //     Category = (CategoryEnum)listCategoryType.SelectedItem,
                     //   colorOfHair = ColorsEnum.White,
                        numOfTeeth = Convert.ToInt32(tbAnimalSpec1.Text),
                        tailLength = Convert.ToDouble(tbAnimalSpec2.Text),
                    }.ToString());
                    break;
                case "Wolf":
                    species = new Wolf(tbSpeciesSpec.Text)
                    {
                        Name = tbName.Text,
                        Age = int.Parse(tbAge.Text),
                        Gender = (GenderEnum)lbGender.SelectedItem,
                        Category = (CategoryEnum)listCategoryType.SelectedItem,
                        colorOfHair = ColorsEnum.White,
                        numOfTeeth = int.Parse(tbAnimalSpec1.Text),
                        tailLength = int.Parse(tbAnimalSpec2.Text),
                    };
                    break;
                case "Dove":
                    species = new Dove(tbSpeciesSpec.Text)
                    {
                        Name = tbName.Text,
                        Age = int.Parse(tbAge.Text),
                        Gender = (GenderEnum)lbGender.SelectedItem,
                        Category = (CategoryEnum)listCategoryType.SelectedItem,
                        flyingSpeed = int.Parse(tbAnimalSpec1.Text),
                        lengthOfWings = int.Parse(tbAnimalSpec2.Text),
                    };
                    break;
                case "Eagle":
                    species = new Eagle(tbSpeciesSpec.Text)
                    {
                        Name = tbName.Text,
                        Age = int.Parse(tbAge.Text),
                        Gender = (GenderEnum)lbGender.SelectedItem,
                        Category = (CategoryEnum)listCategoryType.SelectedItem,
                        flyingSpeed = int.Parse(tbAnimalSpec1.Text),
                        lengthOfWings = int.Parse(tbAnimalSpec2.Text),
                    };
                    break;

            }

            
/*            animalManager.AddAnimal( new Animal

                {
                    Name = tbName.Text,
                    Age = int.Parse(tbAge.Text),
                    Gender = (GenderEnum)lbGender.SelectedItem,
                    Category = (CategoryEnum)listCategoryType.SelectedItem,
*//*                    flyingSpeed = int.Parse(tbAnimalSpec1.Text),
                    lengthOfWings = int.Parse(tbAnimalSpec2.Text),*//*
                    

                }
                );*/
        }

    }


}
