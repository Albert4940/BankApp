using System;
using System.Net;
using System.IO;

namespace BankApp
{
    public class EcrireFichier
    {
        public static void Ecrire(string contenu, string nomFichier)
        {
            try
            {
                File.WriteAllText(nomFichier, contenu);
                Console.WriteLine("Ecriture terminee dans le fichier " + nomFichier);
            }
            catch(IOException e)
            {
                Console.WriteLine("Imposible d'ecrire dans le fichier " + nomFichier);
            }
        }
    }
}
