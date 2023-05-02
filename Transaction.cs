using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace BankApp
{
    [Serializable()]
    public class Transaction : ISerializable
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

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("TransactionSolde", this.Solde);
            info.AddValue("TransactionType", this.Type);
        }
        public Transaction(SerializationInfo info, StreamingContext ctxt)
        {
            this.Solde = (Double)info.GetValue("TransactionSolde", typeof(Double));
            this.Type = (String)info.GetValue("TransactionType", typeof(String));
        }
        public Transaction(string type, double solde)
        {
            this.Type = type;
            this.Solde = solde;
        }
    }
}