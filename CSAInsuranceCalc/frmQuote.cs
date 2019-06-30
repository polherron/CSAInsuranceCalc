using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSAInsuranceCalc
{
    public partial class frmQuote : Form
    {

        List<State> usStates = new List<State>();
        List<Blacklist> blackList = new List<Blacklist>();
        Customer myCustomer;

        public frmQuote()
        {
            InitializeComponent();
            usStates = Model.GetAllStates();
            cbStates.DataSource = usStates;
            cbStates.DisplayMember = "StateName";
            cbStates.ValueMember = "StateName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Calls form validator
        /// Utilities.CheckBlacklisted
        /// Calls Utilities.CheckOver25
        /// Instantiates Customer type and displays quote
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuote_Click(object sender, EventArgs e)
        {

            //Calls validation method
            if (ValidateForm())
            {
                MessageBox.Show("You mut enter a valid ID Number, first and last name");
            }

            int customerNumber;


            int.TryParse(txtCustomerID.Text, out customerNumber);
            bool blacklisted = Utilities.CheckBlacklisted(cbStates.SelectedItem.ToString(), customerNumber);
            bool platinumState = Utilities.CheckPlatinumState(cbStates.SelectedText.ToString());
            bool over25 = Utilities.CheckOver25(dtPicker.Value);

            if (!blacklisted && over25)
            {
                myCustomer = new GoldCustomer(customerNumber, txtFName.Text, txtLName.Text);
            }
            else
            {
                myCustomer = new Customer(customerNumber, txtFName.Text, txtLName.Text);
            }
            if (myCustomer != null)
            {
                txtPremium.Text = myCustomer.Premium.ToString();
                txtDiscount.Text = myCustomer.Discount.ToString();
            }
        }

        private bool ValidateForm()
        {
            return !Utilities.ValidateForm(txtCustomerID, txtFName, txtLName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateQuote() && ValidateForm())
            {
                Utilities.SaveQuote(txtCustomerID.Text, txtFName.Text, txtLName.Text, txtDiscount.Text, txtPremium.Text);
            }
            else
            {
                MessageBox.Show("You mut enter a valid ID Number, " +
                    "first and last name and then " +
                    "click Quote");
            }
        }

        private bool ValidateQuote()
        {
            return Utilities.ValidateFormQuote(txtPremium.Text, txtDiscount.Text);
        }
    }
}
