using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class MainForm : Form
    {
        PartyManager partyManager = new PartyManager(0);

        public MainForm()
        {
            InitializeComponent();
            InitilizeGui();
        }

        private void InitilizeGui()
        {
            //input controls
            ClearTextBoxes();
            gbInviteGuest.Enabled = false;
            btnDelete.Enabled = false;

        }

        private void ClearTextBoxes()
        {
            tbCostPerPerson.Clear();
            tbFeePerPerson.Clear();
            tbFirstName.Clear();
            tbLastName.Clear();
            tbMaxNumOfGuests.Clear();
            lblNumberOfGuests.Text = "0";
            lblSurplus.Text = "0.00";
            lblTotalCosts.Text = "0.00";
            lblTotalFees.Text = "0.00";
        }

        private void ReadInputs()
        {
            lstAllGuests.Items.Add(string.Format("{0}  {1}", partyManager.Count, partyManager.GetItemAt(partyManager.Count - 1)));
            lblNumberOfGuests.Text = partyManager.Count.ToString();
            lblTotalCosts.Text = partyManager.CalcTotalCost().ToString();
            lblTotalFees.Text = partyManager.CalcTotalFees().ToString();
            lblSurplus.Text = (partyManager.CalcTotalFees() - partyManager.CalcTotalCost()).ToString();
        }

        private bool AreInputsValid()
        {
            if (double.TryParse(tbCostPerPerson.Text, out _) &&
               double.TryParse(tbFeePerPerson.Text, out _) &&
               int.TryParse(tbMaxNumOfGuests.Text, out _))
                return true;
            else
            {
                MessageBox.Show("Some input fields are invalid!");
                return false;
            }
        }

        private void tbMaxNumOfGuests_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(tbMaxNumOfGuests.Text, out _))
                MessageBox.Show("This should be a number!");
        }

        private void tbCostPerPerson_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(tbCostPerPerson.Text, out _))
                MessageBox.Show("This should be a number!");
        }

        private void tbFeePerPerson_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(tbFeePerPerson.Text, out _))
                MessageBox.Show("This should be a number!");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsValidName(tbFirstName.Text) && IsValidName(tbLastName.Text))
            {
                bool ok = partyManager.AddNewGuest(tbFirstName.Text, tbLastName.Text);
                if (!ok)
                {
                    MessageBox.Show("The guest list  is full. No new guests!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    ReadInputs();

            }
        }

        private void tbFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidName(tbFirstName.Text))
                MessageBox.Show("First name should not be left empty!");
        }

        private bool IsValidName(string text)
        {
            if (!string.IsNullOrEmpty(text))
                return true;
            return false;
        }

        private void tbLastName_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidName(tbLastName.Text))
                MessageBox.Show("Last name should not be left empty!");
        }

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            lstAllGuests.Items.Clear();
            if (AreInputsValid())
            {
                int maxNumberOfGuests = int.Parse(tbMaxNumOfGuests.Text);
                partyManager = new PartyManager(maxNumberOfGuests);

                partyManager.CostPerPerson = double.Parse(tbCostPerPerson.Text);
                partyManager.FeePerPerson = double.Parse(tbFeePerPerson.Text);
                gbInviteGuest.Enabled = true;

                tbFirstName.Clear();
                tbLastName.Clear();

                MessageBox.Show(string.Format("Party list with space for {0} guests created!", maxNumberOfGuests, "Success"));

            }
            else
            {
                MessageBox.Show("Invalid input! Try again!");
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            int deletedIndex = lstAllGuests.SelectedIndex;
            lstAllGuests.Items.Remove(lstAllGuests.SelectedItem);

            partyManager.DeleteAt(deletedIndex);

            //Update output labels
            UpdateGui();

        }

        public void UpdateGui()
        {
            lblNumberOfGuests.Text = partyManager.Count.ToString();
            lblTotalCosts.Text = partyManager.CalcTotalCost().ToString();
            lblTotalFees.Text = partyManager.CalcTotalFees().ToString();
            lblSurplus.Text = (partyManager.CalcTotalFees() - partyManager.CalcTotalCost()).ToString();
        }

        private void lstAllGuests_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstAllGuests_Enter(object sender, EventArgs e)
        {
            if (partyManager.Count > 0)
                btnDelete.Enabled = true;
        }
    }


}
