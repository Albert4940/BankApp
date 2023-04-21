using System;

namespace BankApp
{
    public class Program
    {
        public static Personne pers = InitialisationPersonne();
        
        public static Personne InitialisationPersonne()
        {
            Personne pers = new Personne("Albert", "Mary");
            IList<Compte> listTemp = pers.ListCompte;
            listTemp.Add(new Compte("courant", 5000));
            listTemp.Add(new Compte("epargne", 9000));
            pers.ListCompte = listTemp;
            return pers; 
        }
        private static void ChoixMenu(string strChoixMenu)
        {

                switch (strChoixMenu)
                {
                    case "I":
                        pers.Afficher();
                    break;

                    case "CS":
                     foreach(Compte compte in pers.ListCompte)
                        {
                          if(compte.Type.Equals("courant"))
                            {
                                Console.WriteLine("Solde Compte Courant : " + compte.Solde);
                                break;
                            }
                        }
                        break;

                    case "CD":
                        Console.WriteLine(strChoixMenu);
                        break;

                    case "CR":
                        Console.WriteLine(strChoixMenu);
                        break;

                    case "ES":
                        Console.WriteLine(strChoixMenu);
                        break;

                    case "ED":
                        Console.WriteLine(strChoixMenu);
                        break;

                    case "ER":
                        Console.WriteLine(strChoixMenu);
                        break;
                    case "X":
                        Console.WriteLine(strChoixMenu);
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
            Console.WriteLine("Appuyez sur Entrée pour afficher le menu." + pers.ListCompte.Count);
            string menu = Console.ReadLine();
            Menu();
        }
    }
}