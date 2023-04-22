using System;
using System.Net;
using System.IO;

namespace BankApp
{
    public class EcrireFichier
    {
        public static void Ecrire(Personne pers)
        {
            string nomFichier = pers.Nom + "_Fichier.txt";
            try
            {
                //File.WriteAllText(nomFichier, contenu);
                
                using (StreamWriter sw = File.CreateText(nomFichier))
                {
                    sw.WriteLine(pers.Prenom + " " + pers.Nom);
                    sw.WriteLine("--------Comptes-------");
                    foreach(Compte compte in pers.ListCompte)
                    {
                        sw.WriteLine("Solde " + compte.Type + ": " + compte.Solde);
                        sw.WriteLine("-----Transactions-----");
                        foreach(Transaction transaction in compte.ListTransaction)
                        {
                            sw.WriteLine("Type : " + transaction.Type + " Montant : " + transaction.Solde);
                        }
                    }

                    Console.WriteLine("Ecriture terminee dans le fichier " + nomFichier);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Imposible d'ecrire dans le fichier " + nomFichier);
            }
        }
    }
}
