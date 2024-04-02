using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _5T24_PetitSolune_enigma
{
    public class fonctions
    {

        public void rotorControl(int[] posInitRotors)
        {

            char temp;

            //creation des différents rotors
            string[,] rotorConfig1, rotorConfig2, rotorConfig3, rotorConfig4, rotorConfig5;
            rotorConfig1 = new string[2, 25];
            rotorConfig2 = new string[2, 25];
            rotorConfig3 = new string[2, 25];
            rotorConfig4 = new string[2, 25];
            rotorConfig5 = new string[2, 25];

            //listage des combinaisons + alphabet
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string chaine1 = "DMTWSILRUYQNKFEJCAZBPGXOHV";
            string chaine2 = "HQZGPJTMOBQNCIFDYAWVEUSRKX";
            string chaine3 = "UQNTLSZFMREHDPXKIBVYGJCWOA";


            //assignation des combinaisons aux rotor1 en fonction de ce que veux le user
            if (posInitRotors[0] == 1)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig1[2, i] = chaine1[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig1[1, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 2)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig1[2, i] = chaine2[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig1[1, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 3)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig1[2, i] = chaine3[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig1[1, i] = alphabet[i].ToString();
                }
            }


            //assignation des combinaisons aux rotor2 en fonction de ce que veux le user
            if (posInitRotors[1] == 1)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig2[2, i] = chaine1[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig2[1, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 2)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig2[2, i] = chaine2[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig2[1, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 3)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig2[2, i] = chaine3[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig2[1, i] = alphabet[i].ToString();
                }
            }

            //assignation des combinaisons aux rotor3 en fonction de ce que veux le user
            if (posInitRotors[1] == 1)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig3[2, i] = chaine1[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig3[1, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 2)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig3[2, i] = chaine2[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig3[1, i] = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 3)
            {
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig3[2, i] = chaine3[i].ToString();
                }
                for (int i = 0; i == 25; i++)
                {
                    rotorConfig3[1, i] = alphabet[i].ToString();
                }
            }

        }

        public bool noDoubleConnexion(string UinputTBConnexion, string message) //faire une entrée en plusieurs étapes et pas 1
        {
            bool confirm;
            message = "";

            for (int i = 0;i < UinputTBConnexion.Length+1;i++)
            {
                for(int j = 0;j < UinputTBConnexion.Length+1;j++)
                {
                    if (i == 0)
                    {

                    }else if ((UinputTBConnexion[i - 1] == UinputTBConnexion[j - 1]) && i != j)
                    { 
                        message += " ; " + UinputTBConnexion[i];
                    }
                }
            }

            if (message== "")
            {
                confirm = true;
            }
            else
            {
                confirm = false;
            }

            return confirm;
        }

        public void setTBconnexion(TBconnexion[] tbConnexion, string UinputTBConnexion)
        {
            for (int i = 0; i <= tbConnexion.Length; i++)
            {
                for (int j = 0; j <= UinputTBConnexion.Length; i++)
                {
                    if (UinputTBConnexion[i].ToString() != ";")
                    {
                        tbConnexion[i].lettre1 = UinputTBConnexion[i].ToString();
                        tbConnexion[i + 1].lettre2 = UinputTBConnexion[i + 1].ToString();
                        i++;
                    }
                }
            }
        }

        //public void cryptText(string message, int[] posInitRotors, out string cryptedMessage)
        //{
        //    firstPass(message, posInitRotors, out cryptedMessage);
        //}

        //static void firstPass(string[,] rotors, string message, int[] posInitRotors, out string cryptedMessage)
        //{
        //    bool step1 = false;
        //    bool step2 = false;

        //    cryptedMessage = "";
        //    for (int i = 0; i < message.Length; i++)
        //    {
        //        char cryptingLetter = message[i];
        //        if (cryptingLetter == char.Parse(" "))
        //        {
        //            cryptedMessage = cryptedMessage + cryptingLetter;
        //        }
        //        else
        //        {
        //            cryptingLetter = char.Parse(rotors[2, 0]);
        //            step1 = true;
        //            mooveRotor(step1, step2, posInitRotors);
        //            step1 = false;
        //            cryptingLetter = char.Parse(rotors[1, cryptingLetter - 65]);
        //            step2 = true;
        //            mooveRotor(step1, step2, posInitRotors);
        //            cryptingLetter = char.Parse(rotors[0, cryptingLetter - 65]);
        //            step2 = false;
        //            cryptedMessage += cryptingLetter;
        //        }
        //    }
        //}

        //static void mooveRotor(bool step1, bool step2, bool step3, string[,] rotors, int[] posInitRotors)
        //{
        //    if (step1)
        //    {
        //        string tempVar = rotors[2, 0];
        //        for (int i = 0; i < rotors.GetLength(1) - 1; i++)
        //        {
        //            rotors[2, i] = rotors[2, i + 1];
        //        }
        //        rotors[2, 25] = tempVar;
        //    }
        //    else if (step2 && rotors[2, 25] == ((char)posInitRotors[0]).ToString())
        //    {
        //        string tempVar = rotors[1, 0];
        //        for (int i = 0; i < rotors.GetLength(1) - 1; i++)
        //        {
        //            rotors[2, i] = rotors[1, i + 1];
        //        }
        //        rotors[2, 25] = tempVar;
        //    }
        //    else if (step3 && rotors[1, 25] == ((char)posInitRotors[0]).ToString())
        //    {
        //        string tempVar = rotors[0, 0];
        //        for (int i = 0; i < rotors.GetLength(1) - 1; i++)
        //        {
        //            rotors[2, i] = rotors[0, i + 1];
        //        }
        //        rotors[2, 25] = tempVar;
        //    }
        //}
    }
}
