using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAInsuranceCalc
{
    class Customer
    {

        public double Discount;
        public double Premium;
        public int CustomerID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public double Quote { get; set; }


        public Customer()
        {
            this.Discount = 0;
            this.Premium = 1000;
        }

        public Customer(int customerID, string fName, string lName)
        {
            CustomerID = customerID;
            FName = fName;
            LName = lName;
            this.Discount = 0;
            this.Premium = 1000;
        }
    }
}
