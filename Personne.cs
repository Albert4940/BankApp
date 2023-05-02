using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace BankApp
{
	[Serializable()] //Set this attribute to all classes that want to serialize 
	public class Personne : ISerializable //derive your class from ISerializable
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
			Console.WriteLine("-------------- INFORMATION SOLDES-------------");
			Console.WriteLine("Nom : " + this.Nom + "\nPrenom : " + this.Prenom);
            Console.WriteLine("--------Comptes-------");
            foreach (Compte compte in this.ListCompte)
            {
                Console.WriteLine("Solde " + compte.Type + ": " + compte.Solde);
                Console.WriteLine("-----Transactions-----");
                foreach (Transaction transaction in compte.ListTransaction)
                {
                    Console.WriteLine("Type : " + transaction.Type + " Montant : " + transaction.Solde);
                }
            }
        }
	
		//Serialisation function
		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. For ex:- If you write EmpId as "EmployeeId"
            // then you should read the same with "EmployeeId"

            info.AddValue("NomPersonne", this.Nom);
			info.AddValue("PrenomPersonne", this.Prenom);
			info.AddValue("ListCompte", this.ListCompte);
		}

		//Deserialization constructor
		public Personne(SerializationInfo info, StreamingContext ctxt)
		{
			this.Prenom = (String)info.GetValue("NomPersonne", typeof(String));
			this.Nom = (String)info.GetValue("PrenomPersonne", typeof(String));
			this.ListCompte = (IList<Compte>)info.GetValue("ListCompte", typeof(IList<Compte>));
		}
		public Personne(string nom, string prenom)
		{
            this.Nom = nom;
			this.Prenom = prenom;
			this.listCompte = new List<Compte>();
		}
	}
}