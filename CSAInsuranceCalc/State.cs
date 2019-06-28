using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAInsuranceCalc
{
    class State
    {
        public string StateName { get; set; }
        public string StateAbbreviation { get; set; }

        public State()
        {
        }


        public State(string stateName, string stateAbbreviation)
        {
            this.StateName = stateName;
            this.StateAbbreviation = stateAbbreviation;
        }
    }
}
