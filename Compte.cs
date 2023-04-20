using System;

namespace BankApp
{
	public class Compte
	{
		private int numero;
		private double montant;
		private string type;
		private IList<Transaction> listTransaction;

		public void Depot()
		{
			
		}
		
		public double DemanderUnMontant()
		{
			Console.WriteLine("Entrer le montant : ");
			string montant = Console.ReadLine();
			return Double.Parse(montant);
		}
		Compte(int numero, string type)
		{
			
		}
	}
}