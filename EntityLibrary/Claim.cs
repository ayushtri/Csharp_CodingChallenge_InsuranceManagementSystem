using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Claim
    {
        private int _ClaimId;
        private string _ClaimNumber;
        private DateTime _DateFiled;
        private decimal _ClaimAmount;
        private string _Status;
        private Policy _Policy; 
        private Client _Client;

        public Claim() { }

        public Claim(int ClaimId, string ClaimNumber, DateTime DateFiled, decimal ClaimAmount, string Status, Policy policy, Client client)
        {
            this._ClaimId = ClaimId;
            this._ClaimNumber = ClaimNumber;
            this._DateFiled = DateFiled;
            this._ClaimAmount = ClaimAmount;
            this._Status = Status;
            this._Policy = Policy;
            this._Client = Client;
        }

        public int ClaimID
        {
            get { return _ClaimId; }
            set { _ClaimId = value; }
        }

        public string ClaimNumber
        {
            get { return _ClaimNumber; }
            set { _ClaimNumber = value; }
        }

        public DateTime DateFiled
        {
            get { return _DateFiled; }
            set { _DateFiled = value; }
        }

        public decimal ClaimAmount
        {
            get { return _ClaimAmount; }
            set { _ClaimAmount = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public Policy Policy
        {
            get { return _Policy; }
            set { _Policy = value; }
        }

        public Client Client
        {
            get { return _Client; }
            set { _Client = value; }
        }

        public override string ToString()
        {
            return $"Claim ID: {ClaimID}, Claim Number: {ClaimNumber}, Status: {Status}";
        }

        public void PrintDetails()
        {
            Console.WriteLine("Claim ID: " + ClaimID);
            Console.WriteLine("Claim Number: " + ClaimNumber);
            Console.WriteLine("Date Filed: " + DateFiled.ToString("yyyy-MM-dd"));
            Console.WriteLine("Claim Amount: " + ClaimAmount.ToString("C"));
            Console.WriteLine("Status: " + Status);
            Console.WriteLine("Client: ");
            Client.PrintDetails();
            Console.WriteLine("Policy: ");
            Policy.PrintDetails();
        }
    }
}
