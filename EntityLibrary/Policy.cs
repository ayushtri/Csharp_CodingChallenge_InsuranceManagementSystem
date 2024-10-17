using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Policy
    {
        private int _PolicyID;
        private string _PolicyNumber;

        public Policy() { }

        public Policy(int PolicyID, string PolicyNumber)
        {
            this._PolicyID = PolicyID;
            this._PolicyNumber = PolicyNumber;
        }

        public int PolicyID
        { 
            get { return _PolicyID; }
            set { _PolicyID = value; }
        }
        public string PolicyNumber 
        {
            get { return _PolicyNumber; }
            set { _PolicyNumber = value; }
        }

        public override string ToString()
        {
            return $"Policy ID: {PolicyID}, Policy Number: {PolicyNumber}";
        }

        public void PrintDetails()
        {
            Console.WriteLine("Policy ID: " + PolicyID);
            Console.WriteLine("Policy Number: " + PolicyNumber);
        }
    }
}
