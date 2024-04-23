using System.Globalization;

namespace _5TTI_Solune_P_StockageAdressesIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fonctions outils = new fonctions();
            int[,] TBIP = new int[20, 4];
            int ligne = 0;
            int placeLibre = 0;
            bool nomOK;
            bool IPOK;
            int nombreLigneNoms = 0;
            string[] tableauNoms = new string[20];
            string temp;
            bool restart;

            string choix = "0";
            do
            {
                do
                {
                    Console.WriteLine("bienvenu sur mon recueil d'adresses IP \n Que voulez vous faire ?\n 1 - ajouter une IP\n 2 - afficher les Ip stoqués dans le tableau\n 3 - afficher une IP en particulier");
                    choix = Console.ReadLine();
                } while (choix != "1" && choix != "2" && choix != "3");

                if (choix == "1")
                {
                    outils.lireAdresseIP(out int[] adresse);
                    IPOK = outils.ajouterAdresseIP(placeLibre, TBIP, adresse);
                    nomOK = outils.ajouteNom(nombreLigneNoms, tableauNoms);
                }
                else if (choix == "2")
                {
                    outils.concateneTout(TBIP, tableauNoms, out string sortie);
                    Console.WriteLine(sortie);
                }

                
                
                do
                {
                    Console.WriteLine("avez-vous fini ?");
                    temp = Console.ReadLine();
                } while (temp != "oui" && temp != "non");

                if (temp == "non")
                {
                    restart = true;
                }
                else
                {
                    restart = false;
                }

            } while (restart);
        }
    }
}
