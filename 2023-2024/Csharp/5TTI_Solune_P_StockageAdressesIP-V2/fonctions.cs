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

        public void lireAdresseIP(out int[] IP)
        {
            IP = new int[4];
            for (int i = 0; i < 4; i++)
            {
                lireOctet(out int octetIP);
                Console.Clear();
                IP[i] = octetIP;
            }
        }

        public void concateneAdresse(adresses[] Adresses, int ligne, out string sortieAdresse)
        {
            sortieAdresse = "";
            for (int i = 0;i <= 2; i++)
            {
                sortieAdresse += Adresses[ligne].IP[i] + ".";
            }
            sortieAdresse += Adresses[ligne].IP[3];
        }

        public bool ajouterAdresseIP(int placeLibre,ref adresses[] adresses, int[] IP)
        {
            if (placeLibre < 20)
            {
                for (int i = 0; i <= 3 ; i++)
                {
                    adresses[placeLibre].IP[i] = IP[i];
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ajouteNom(int placeLibre, ref adresses[] Adresses )
        {
            string UserNom;
            if (placeLibre < 21)
            {
                Console.WriteLine("Quel est votre Nom ?");
                UserNom = Console.ReadLine();
                Adresses[placeLibre].nom = UserNom;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void concateneTout(ref adresses[] Adresses, out string sortie)
        {
            sortie = "";
            for (int i = 0; i < 20; i++)
            {
                concateneAdresse(Adresses, i, out string sortieAdresse);
                sortie += Adresses[i].nom + " : " + sortieAdresse + "\n";
            }
        }
    }
}
