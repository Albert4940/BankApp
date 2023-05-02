using System;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankApp
{
    public class EcrireLireFichier
    {
        public const  String NOMFICHIER = "PersonneInfo.osl";
        public static void EcrireSerialize(Personne pers)
        {
            Stream stream = File.Open(NOMFICHIER, FileMode.Create);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            
            Console.WriteLine("Writting Personne Information");

            binaryFormatter.Serialize(stream, pers);

            stream.Close();
        }

        public static Personne LireDeserialize()
        {
            Personne pers = null;
            if(File.Exists(NOMFICHIER))
            {
                Stream stream = File.Open(NOMFICHIER, FileMode.Open);
                BinaryFormatter binaryFormatter = new BinaryFormatter();

                Console.WriteLine("Recuperation des informations");

                pers = (Personne)binaryFormatter.Deserialize(stream);
                stream.Close();
            }

            return pers;
        }
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
