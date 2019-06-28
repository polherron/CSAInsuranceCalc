using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAInsuranceCalc
{
    class PlatinumCustomer : Customer
    {
        public override double Discount { get; set; }
        public override double Premium { get; set; }

        ///Constructor                
        public PlatinumCustomer(int customerID,
           string fName, string lName)
            : base(customerID, fName, lName)
        {
            this.Discount = 60;
            this.Premium = 400;
        }
        ///Constructor
        public PlatinumCustomer()
        {
            this.Discount = 60;
            this.Premium = 400;
        }
    }
}
