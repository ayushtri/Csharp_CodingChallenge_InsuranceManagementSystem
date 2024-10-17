using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLibrary
{
    public class Payment
    {
        private int _PaymentId;
        private DateTime _PaymentDate;
        private decimal _PaymentAmount;
        private Client _Client;

        public Payment() { }

        public Payment(int PaymentId, DateTime PaymentDate, decimal PaymentAmount, Client Client)
        {
            this._PaymentId = PaymentId;
            this._PaymentDate = PaymentDate;
            this._PaymentAmount = PaymentAmount;
            this._Client = Client;
        }

        public int PaymentID
        {
            get { return _PaymentId; }
            set { _PaymentId = value; }
        }

        public DateTime PaymentDate
        {
            get { return _PaymentDate; }
            set { _PaymentDate = value; }
        }
        public decimal PaymentAmount
        {
            get { return _PaymentAmount; }
            set { _PaymentAmount = value; }
        }

        public Client Client
        {
            get { return _Client; }
            set { _Client = value; }
        }
        public override string ToString()
        {
            return $"Payment ID: {PaymentID}, Payment Date: {PaymentDate}, Payment Amount: {PaymentAmount}";
        }

        public void PrintDetails()
        {
            Console.WriteLine("Payment ID: " + PaymentID);
            Console.WriteLine("Payment Date: " + PaymentDate.ToString("yyyy-MM-dd"));
            Console.WriteLine("Payment Amount: " + PaymentAmount.ToString("C"));
            Console.WriteLine("Client: ");
            Client.PrintDetails();
        }
    }
}
