using System.Globalization;

namespace _5TTI_Solune_P_StockageAdressesIP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fonctions outils = new fonctions();
            adresses[] Adresse = new adresses[20];
            int placeLibre = 0;
            bool nomOK;
            bool IPOK;
            string temp;
            bool restart;

            string choix = "0";
            do
            {
                do
                {
                    Console.WriteLine("bienvenu sur mon recueil d'adresses IP \n Que voulez vous faire ?\n 1 - ajouter une IP\n 2 - afficher les Ip stoqués dans le tableau");
                    choix = Console.ReadLine();
                } while (choix != "1" && choix != "2" && choix != "3");

                if (choix == "1")
                {
                    outils.lireAdresseIP(out int[] IP);
                    IPOK = outils.ajouterAdresseIP(placeLibre,ref Adresse, IP);
                    nomOK = outils.ajouteNom(placeLibre,ref Adresse);
                    placeLibre++;
                }
                else if (choix == "2")
                {
                    outils.concateneTout(ref Adresse, out string sortie);
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
