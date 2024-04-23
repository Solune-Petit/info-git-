using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _5T24_PetitSolune_enigma
{
    public class fonctions
    {

        public void rotorControl(int[] posInitRotors, out string[,] rotorConfig1, out string[,] rotorConfig2, out string[,] rotorConfig3)
        {

            string temp;

            //creation des différents rotors
            string[,] rotorConfig4, rotorConfig5;
            rotorConfig1 = new string[3, 26];
            rotorConfig2 = new string[3, 26];
            rotorConfig3 = new string[3, 26];

            //listage des combinaisons + alphabet
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string chaine1 = "dmtwsilruyqnkfejcazbpgxohv";
            string chaine2 = "HQZGPJTMOBQNCIFDYAWVEUSRKX";
            string chaine3 = "UQNTLSZFMREHDPXKIBVYGJCWOA";


            //assignation des combinaisons aux rotor1 en fonction de ce que veux le user
            if (posInitRotors[0] == 1)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig1[2, i] = chaine1[i].ToString();
                    rotorConfig1[1,i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig1[0, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 2)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig1[2, i] = chaine2[i].ToString();
                    rotorConfig1[1, i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig1[0, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 3)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig1[2, i] = chaine3[i].ToString();
                    rotorConfig1[1, i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig1[0, i] = alphabet[i].ToString();
                }
            }


            //assignation des combinaisons aux rotor2 en fonction de ce que veux le user
            if (posInitRotors[1] == 1)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig2[2, i] = chaine1[i].ToString();
                    rotorConfig2[1, i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig2[0, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 2)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig2[2, i] = chaine2[i].ToString();
                    rotorConfig2[1, i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig2[0, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 3)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig2[2, i] = chaine3[i].ToString();
                    rotorConfig2[1, i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig2[0, i] = alphabet[i].ToString();
                }
            }

            //assignation des combinaisons aux rotor3 en fonction de ce que veux le user
            if (posInitRotors[1] == 1)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig3[2, i] = chaine1[i].ToString();
                    rotorConfig3[1, i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig3[0, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 2)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig3[2, i] = chaine2[i].ToString();
                    rotorConfig3[1, i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig3[0, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 3)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig3[2, i] = chaine3[i].ToString();
                    rotorConfig3[1, i] = alphabet[i].ToString() + chaine1[i].ToString();
                    rotorConfig3[0, i] = alphabet[i].ToString();
                }
            }


            temp = rotorConfig1[2, 0];
            for (int i = 0;i < 25; i++)
            {
                rotorConfig1[2, i] = rotorConfig1[2, i + 1];
            }
            rotorConfig1[2,25] = temp;

        }

        static void turnRotors(ref string[,] rotor1, ref string[,] rotor2, ref string[,] rotor3)
        {
            string temp = rotor1[0,0];
            for (int i = 0;i < rotor1.GetLength(0);i++)
            {
                rotor1[0,i] = rotor1[0,i+1];
            }
            rotor1[0,25] = temp;

            temp = rotor1[1, 0];
            for (int i = 0; i < rotor1.GetLength(1); i++)
            {
                rotor1[1, i] = rotor1[1, i + 1];
            }
            rotor1[1, 25] = temp;



            temp = rotor2[0, 0];
            for (int i = 0; i < rotor2.GetLength(0); i++)
            {
                rotor2[0, i] = rotor2[0, i + 1];
            }
            rotor2[0, 25] = temp;

            temp = rotor2[1, 0];
            for (int i = 0; i < rotor2.GetLength(1); i++)
            {
                rotor2[1, i] = rotor2[1, i + 1];
            }
            rotor2[1, 25] = temp;



            temp = rotor3[0, 0];
            for (int i = 0; i < rotor3.GetLength(0); i++)
            {
                rotor3[0, i] = rotor3[0, i + 1];
            }
            rotor3[0, 25] = temp;

            temp = rotor3[1, 0];
            for (int i = 0; i < rotor3.GetLength(1); i++)
            {
                rotor3[1, i] = rotor3[1, i + 1];
            }
            rotor3[1, 25] = temp;
        }

        public void setTBconnexion(string UinputTBConnexion, out string message, TBconnexion[] tbConnexion, out bool confirm)     //faire une entrée en plusieurs étapes et pas 1
        {
            bool doublon = false;
            confirm = false;
            message = string.Empty;


            //vérifie qu'il n'y as pas 2 fois la même lettre dans le tableau
            for (int i = 0;i < 13;i++)
            {
                if (tbConnexion[i].lettre1 == UinputTBConnexion || tbConnexion[i].lettre2 == UinputTBConnexion)
                {
                    message = "vous avez déjà assigné la lettre " + UinputTBConnexion;
                    confirm = true;
                    doublon = true;
                    i = 14;
                }
            }


                                                        //si il n'y as pas 2 foi sla même lettre dans le tableau, le programme l'insert
            if (doublon == false)
            {
                for(int i = 0;i < 13;i++)
                {
                    if (tbConnexion[i].lettre1 == null)
                    {
                        UinputTBConnexion = UinputTBConnexion;
                        tbConnexion[i].lettre1 = UinputTBConnexion;
                        confirm = false;
                        i = 14;

                    }else if (tbConnexion[i].lettre2 == null)
                    {
                        tbConnexion[i].lettre2 = UinputTBConnexion;
                        confirm = false;
                        i = 14;
                    }
                }
            }
        }

        public void crypt(int[] posInitRotors, string message, TBconnexion[] tbConnexion, string[,] rotor1, string[,] rotor2, string[,] rotor3, out string cryptedMessage)
        {
            string lettre;
            string cryptedLettre = "" ;
            cryptedMessage = "";


            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].ToString() != " ")
                {
                    turnRotors(ref rotor1, ref rotor2, ref rotor3);
                    lettre = message[i].ToString();
                    cryptTbconnexion(lettre, ref cryptedLettre, tbConnexion);
                    cryptRotorFirstPass(ref cryptedLettre, ref rotor1, ref rotor2, ref rotor3);
                    //test purpus
                    cryptedMessage += cryptedLettre;
                }
                else
                {
                    cryptedMessage += message[i];
                }
            }
        }

        static void cryptTbconnexion(string lettre, ref string cryptedLettre, TBconnexion[] tbConnexion)
        {
            bool converted = false;

            for (int i = 0;i < 13; i++)
            {
                if (lettre == tbConnexion[i].lettre1)
                {
                    cryptedLettre = tbConnexion[i].lettre2;
                    converted = true;
                }else if (lettre == tbConnexion[i].lettre2)
                {
                    cryptedLettre = tbConnexion[i].lettre1;
                    converted = true;
                }
            }

            if (converted == false)
            {
                cryptedLettre = lettre;
            }
        }

        static void cryptRotorFirstPass(ref string cryptedLettre, ref string[,] rotor1, ref string[,] rotor2, ref string[,] rotor3)
        {
            int posNextRotor = 1;
            
            for (int i = 0; i < rotor1.GetLength(0); i++)
            {
                if (cryptedLettre == rotor1[0,i])
                {
                    cryptedLettre = rotor1[1,i].ToLower();
                    posNextRotor = i;
                    i = rotor1.GetLength(0) + 1;
                }
            }

            cryptedLettre = rotor2[1, posNextRotor];
             
            

            for (int i = 0; i < rotor3.GetLength(0); i++)
            {
                if (cryptedLettre == rotor3[0, i])
                {
                    cryptedLettre = rotor3[1, i].ToLower();
                    i = rotor3.GetLength(0) + 1;
                }
            }
        }
    }
}
