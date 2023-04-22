using System;
namespace BankApp
{
    public class Transaction
    {
        private int numero;
        private double solde;
        private string type;

        public double Solde
        {
            get
            {
                return this.solde;
            }

            set
            {
                this.solde = value;
            }
        }

        public string Type
        {
            get
            {
                return this.type;
            }

            set
            {
                this.type = value;
            }
        }
        public Transaction(string type, double solde)
        {
            this.Type = type;
            this.Solde = solde;
        }
    }
}