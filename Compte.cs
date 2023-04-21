using System;

namespace BankApp
{
	public class Compte
	{
		private int numero;
		private double solde;
		private string type;
		private IList<Transaction> listTransaction;

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

		public Transaction ListTransaction
		{
			get
			{
				return (Transaction)listTransaction;
			}

			set
			{
				this.listTransaction.Add(value);
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
		public void Depot()
		{
			
		}
		
		public double DemanderUnMontant()
		{
			Console.WriteLine("Entrer le montant : ");
			string solde = Console.ReadLine();
			return Double.Parse(solde);
		}
		public Compte(string type, double solde)
		{
			this.Solde = solde;
			this.Type = type;
		}
	}
}