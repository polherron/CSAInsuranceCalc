using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAInsuranceCalc
{
    class Utilities
    {
        /// <summary>
        /// Checks State list (xml) for a blacklisted state.
        /// Returns true of state is found
        /// </summary>
        /// <param name="states"></param>
        /// <param name="stateName"></param>
        /// <returns></returns>
        public static Boolean CheckStateBlacklisted(string stateName)
        {
            List<State> states = Model.GetBlacklistedStates();
            return states.Any(st => st.StateName == stateName);
        }

        /// <summary>
        /// Checks a values string (csv) for a value.
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        internal static bool CheckCustomerBlacklisted(int i)
        {
            string values = Model.GetBlacklistedCustomers(); 
            string[] numbers = values.Split(',');
            foreach (var item in numbers)
            {
                int number;
                if (int.TryParse(item, out number))
                {
                    if (number == i)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Retrieves a list of states
        /// returns true if either the State or Customer is blacklisted
        /// </summary>
        /// <param name="state"></param>
        /// <param name="customerNumber"></param>
        /// <returns>bool</returns>
        internal static bool CheckBlacklisted(string state, int customerNumber)
        {
            return (CheckStateBlacklisted(state)
            && CheckCustomerBlacklisted(customerNumber));
        }

        /// <summary>
        /// Validates inputs
        /// Customer ID is an integer
        /// Customer First and Last names contain text
        /// </summary>
        /// <param name="txtCustomerID"></param>
        /// <param name="txtFName"></param>
        /// <param name="txtLName"></param>
        /// <returns>bool</returns>
        internal static bool ValidateForm(TextBox txtCustomerID, TextBox txtFName, TextBox txtLName)
        {
            int temp;
            return (txtFName.Text.Length > 0
                && txtLName.Text.Length > 0
                && int.TryParse(txtCustomerID.Text, out temp));
        }
        /// <summary>
        /// Checks DOB and returns age in years
        /// </summary>
        /// <param name="dob"></param>
        /// <returns>age in years as integer</returns>
        internal static bool CheckOver25(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;
            return age > 24;
        }
    }
}
