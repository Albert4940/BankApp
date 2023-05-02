using System;

namespace BankApp
{
    public class Program
    {
        public static Personne pers = InitialisationPersonne();
        
        public static Personne InitialisationPersonne()
        {
            Personne pers = null;

            pers = EcrireLireFichier.LireDeserialize();

            if(pers == null)
            {
                pers = new Personne("Albert", "Mary");
                IList<Compte> listTemp = pers.ListCompte;
                listTemp.Add(new Compte("courant", 4000));
                listTemp.Add(new Compte("epargne", 9000));
                pers.ListCompte = listTemp;
            }
               
            return pers; 
        }

        public static Compte RechercherUnCompteParType(IList<Compte> listCompte, string type)
        {
            foreach (Compte compte in listCompte)
            {
                if (compte.Type.Equals(type))
                {
                    return compte;
                }
            }
            return null;
        }


        private static void ChoixMenu(string strChoixMenu)
        {

                switch (strChoixMenu)
                {
                    case "I":
                    Console.Clear();
                        pers.Afficher();
                    break;

                    case "CS":
                    Console.Clear();
                    if (RechercherUnCompteParType(pers.ListCompte, "courant") != null)
                         Console.WriteLine("Solde Compte Courant : " + RechercherUnCompteParType(pers.ListCompte,"courant").Solde);
                                
                        break;

                    case "CD":
                    Console.Clear();
                    if (RechercherUnCompteParType(pers.ListCompte, "courant") != null)
                             RechercherUnCompteParType(pers.ListCompte, "courant").Depot();                            
                        break;

                    case "CR":
                    Console.Clear();
                    if (RechercherUnCompteParType(pers.ListCompte, "courant") != null)
                        RechercherUnCompteParType(pers.ListCompte, "courant").Retrait();
                    break;

                    case "ES":
                    Console.Clear();
                    if (RechercherUnCompteParType(pers.ListCompte, "epargne") != null)
                        Console.WriteLine("Solde Compte Epargne : " + RechercherUnCompteParType(pers.ListCompte, "epargne").Solde);
                    break;

                    case "ED":
                    Console.Clear();
                    if (RechercherUnCompteParType(pers.ListCompte, "epargne") != null)
                        RechercherUnCompteParType(pers.ListCompte, "epargne").Depot();
                        break;

                    case "ER":
                    Console.Clear();
                    if (RechercherUnCompteParType(pers.ListCompte, "epargne") != null)
                        RechercherUnCompteParType(pers.ListCompte, "epargne").Retrait();
                    break;
                    case "X":
                    Console.Clear();
                    EcrireLireFichier.EcrireSerialize(pers);
                        Environment.Exit(-1);
                    break;
                default:
                    Console.WriteLine("Mauvais choix !");
                break;
                }

        }
        public static void Menu()
        {
            while(true)
            {
                Console.WriteLine("Appuyez sur Entrée pour afficher le menu." + pers.ListCompte.Count);
                string menu = Console.ReadLine();

                Console.WriteLine("Veuillez sélectionner une option ci-dessous :");

                Console.WriteLine("[I] Voir les informations sur le titulaire du compte");
                Console.WriteLine("[CS] Compte courant -Consulter le solde");
                Console.WriteLine("[CD] Compte courant -Déposer des fonds");
                Console.WriteLine("[CR] Compte courant -Retirer des fonds:");
                Console.WriteLine("[ES] Compte épargne -Consulter le solde");
                Console.WriteLine("[ED] Compte épargne -Déposer des fonds");
                Console.WriteLine("[ER] Compte épargne -Retirer des fonds");
                Console.WriteLine("[X] Quitter");

                string strChoixMenu = Console.ReadLine();

                strChoixMenu = strChoixMenu.ToUpper();

                ChoixMenu(strChoixMenu);
            }
           
        }
        public static void Main(string[] args)
        {
            Menu();
        }
    }
}