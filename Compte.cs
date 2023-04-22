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

		public IList<Transaction> ListTransaction
		{
			get
			{
				return this.listTransaction;
			}

			set
			{
				this.listTransaction = (value);
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
				this.type = null;
				this.type = value;
			}
		}
		public void Depot()
		{
			double montant = DemanderUnMontant("Quel montant souhaitez-vous déposer ?");
			this.Solde += montant;

			IList<Transaction> listTemp = this.ListTransaction;
			listTemp.Add(new Transaction("depot", montant));
			Console.WriteLine("Vous avez déposé : " + montant + " €.");
		}
		
		public void Retrait()
		{
			double montant = DemanderUnMontant("Quel montant souhaitez-vous retirer ?");
			if(this.Solde >= montant)
			{
                this.Solde -= montant;

                IList<Transaction> listTemp = this.ListTransaction;
                listTemp.Add(new Transaction("retrait", montant));
                Console.WriteLine("Vous avez retire : " + montant + " €.");
            }
			else
			{
				Console.WriteLine("Le solde de votre compte doit etre superieur ou egal au montant du retrait");
			}
		}
		public double DemanderUnMontant(string msg)
		{
			Console.WriteLine(msg);
			string solde = Console.ReadLine();
			return Double.Parse(solde);
		}
		public Compte(string type, double solde)
		{
			this.Solde = solde;
			this.Type = type;
			listTransaction = new List<Transaction>();

        }
	}
}