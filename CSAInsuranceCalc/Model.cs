using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace CSAInsuranceCalc
{
    internal class Model
    {

        /// <summary>
        /// Reads xml file of Blacklisted states
        /// Returns a list of type state
        /// </summary>
        /// <returns>List<State></returns>
        internal static List<State> GetBlacklistedStates()
        {

                XDocument xdoc = XDocument.Load("../../data/BlacklistedStates.xml");
                List<State> states = (from state in xdoc.Element("states").Elements("state")
                                      select new State
                                      {
                                          StateName = (string)state.Element("code").Value,
                                          StateAbbreviation = (string)state.Element("code").Value
                                      }).ToList();

                return states;
        }

        /// <summary>
        /// Reads xml file of US states
        /// Returns a list of type state
        /// </summary>
        /// <returns>List<State></returns>
        internal static List<State> GetAllStates()
        {
            XDocument xdoc = XDocument.Load("../../data/usStates.xml");
            List<State> states = (from state in xdoc.Element("states").Elements("state")
                                  select new State
                                  {
                                      StateName = (string)state.Element("name").Value,
                                      StateAbbreviation = (string)state.Element("code").Value
                                  }).ToList();

            return states;
        }

        /// <summary>
        /// Reads a text file and returns result as a single string.
        /// </summary>
        /// <returns>string</returns>
        internal static string GetBlacklistedCustomers()
        {
            return File.ReadAllText("..\\..\\data\\BlacklistedCustomers.txt");
        }

        internal static List<State> GetPlatinumStates()
        {
            XDocument xdoc = XDocument.Load("../../data/PlatinumStates.xml");
            List<State> states = (from state in xdoc.Element("states").Elements("state")
                                  select new State
                                  {
                                      StateName = (string)state.Element("name").Value,
                                      StateAbbreviation = (string)state.Element("code").Value
                                  }).ToList();

            return states;
        }
    }
}