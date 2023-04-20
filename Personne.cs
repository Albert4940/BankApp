using System;

namespace BankApp
{
	public class Personne
	{
		private string nom, prenom;
		private IList<Compte> listCompte;
		
		public string Nom
		{
			get
			{
				return this.nom;
			}

			set
			{
				this.nom = value;
			}
		}

		public string Prenom
		{
			get
			{
				return this.prenom;
			}

			set
			{
				this.prenom = value;
			}
		}

		public Compte ListCompte
		{
			get
			{
				return (Compte)listCompte;
			}

			set
			{
				this.listCompte.Add(value);
			}
		}

		public void Afficher()
		{
			Console.WriteLine("Nom : " + this.Nom + "\nPrenom : " + this.Prenom);
		}
	
		public Personne(string nom, string prenom)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			listCompte  = new List<Compte>();

        }
	}
}