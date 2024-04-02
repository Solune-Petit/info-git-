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

            string choix;
            do
            {
                Console.WriteLine("bienvenu sur mon recueil d'adresses IP \n Que voulez vous faire ?\n 1 - ajouter une IP\n 2 - afficher les Ip stoqués dans le tableau");
                choix = Console.ReadLine();
            } while (choix != "1" && choix != "2");

            if (choix == "1")
            {
                outils.lireAdresseIP(out int[] adresse);
                IPOK = outils.ajouterAdresseIP(placeLibre, TBIP, adresse);
                nomOK = outils.ajouteNom(nombreLigneNoms, tableauNoms);
                outils.concateneAdresse(TBIP, ligne, out string sortieAdresse);
                outils.concateneTout(TBIP, tableauNoms, out string sortie);
                Console.WriteLine(sortie);
            }
        }
    }
}
