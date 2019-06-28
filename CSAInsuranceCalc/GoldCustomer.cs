using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAInsuranceCalc
{
    class GoldCustomer : Customer
    {

        public new double Discount;
        public new double Premium;

        ///Constructor                
        public GoldCustomer(int customerID,
           string fName, string lName)
            : base(customerID, fName, lName)
            {
                this.Discount = 40;
                this.Premium = 600;
            }
        ///Constructor
        public GoldCustomer()
        {
            this.Discount = 40;
            this.Premium = 600;
        }
    }

}
