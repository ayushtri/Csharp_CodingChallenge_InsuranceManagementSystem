using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Client
    {
        private int _ClientID;
        private string _ClientName;
        private string _ContactInfo;
        private Policy _Policy;

        public Client() { }

        public Client(int ClientID, string ClientName, string ContactInfo, Policy Policy)
        {
            this._ClientID = ClientID;
            this._ClientName = ClientName;
            this._ContactInfo = ContactInfo;
            this._Policy = Policy;
        }
        
        public int ClientID
        {
            get { return _ClientID; }
            set { _ClientID = value; }
        }

        public string ClientName
        {
            get { return _ClientName; }
            set { _ClientName = value; }
        }

        public string ContactInfo
        {
            get { return _ContactInfo; }
            set { _ContactInfo = value; }
        }

        public Policy Policy
        {
            get { return _Policy; }
            set { this._Policy = value; }
        }

        public override string ToString()
        {
            return $"Client ID: {ClientID}, Client Name: {ClientName}";
        }

        public void PrintDetails()
        {
            Console.WriteLine("Client ID: " + ClientID);
            Console.WriteLine("Client Name: " + ClientName);
            Console.WriteLine("Contact Info: " + ContactInfo);
        }

    }
}
