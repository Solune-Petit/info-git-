using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _5TTI_Solune_P_StockageAdressesIP
{
    internal class fonctions
    {

        public void lireOctet(out int octetIp)
        {
            string Uinput;
            do
            {
                Console.WriteLine("Veuillez entrer votre octet :");
                Uinput = Console.ReadLine();
            } while (!int.TryParse(Uinput, out octetIp) || octetIp <= 0 || octetIp >= 256);
        }

        public void lireAdresseIP(out int[] adresse)
        {
            adresse = new int[4];
            for (int i = 0; i < 4; i++)
            {
                lireOctet(out int octetIP);
                Console.Clear();
                adresse[i] = octetIP;
            }
        }

        public void concateneAdresse(int[,] TBIP, int ligne, out string sortieAdresse)
        {
            sortieAdresse = "";
            for (int i = 0;i <= 2; i++)
            {
                sortieAdresse += TBIP[ligne,i] + ".";
            }
            sortieAdresse += TBIP[ligne, 3];
        }

        public bool ajouterAdresseIP(int placeLibre, int[,] TBIP, int[] adresse)
        {
            if (placeLibre < 20)
            {
                for (int i = 0; i <= 3 ; i++)
                {
                    TBIP[placeLibre, i] = adresse[i];
                }
                placeLibre++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ajouteNom(int nombreLigneNoms, string[] tableauNoms )
        {
            string UserNom;
            if (nombreLigneNoms < 21)
            {
                Console.WriteLine("Quel est votre Nom ?");
                UserNom = Console.ReadLine();
                tableauNoms[nombreLigneNoms] = UserNom;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void concateneTout(int[,] TBIP, string[] tableauNoms, out string sortie)
        {
            sortie = "";
            for (int i = 0; i < TBIP.GetLength(0); i++)
            {
                concateneAdresse(TBIP, i, out string sortieAdresse);
                sortie += tableauNoms[i] + " : " + sortieAdresse + "\n";
            }
        }
    }
}
