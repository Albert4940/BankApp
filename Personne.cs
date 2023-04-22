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

		public IList<Compte> ListCompte
		{
			get
			{
				return this.listCompte;
			}

			set
			{
				this.listCompte = null;
				this.listCompte = value;
			}
		}

		public void Afficher()
		{
			Console.WriteLine("Nom : " + this.Nom + "\nPrenom : " + this.Prenom);
		}
	
		public void RegrouperContenu()
		{
			string contenu = "";
			contenu += this.Nom + " " + this.Prenom + "/n";
			
			//EcrireFichier.Ecrire(contenu, this.Nom + "_Fichier.txt");
		}

		public Personne(string nom, string prenom)
		{
			this.Nom = nom;
			this.Prenom = prenom;
			this.listCompte = new List<Compte>();
		}
	}
}