using System;
using System.Collections.Generic;
using System.Drawing;
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

        public void rotorControl(int[] posInitRotors, ref Rotor1[] rotorConfig1, ref Rotor2[] rotorConfig2, ref Rotor3[] rotorConfig3, int[] placementInitRotors)
        {

            //listage des combinaisons + alphabet
            string[] alphabet = new string[26];
            string[] chaine1 = new string[26];
            string[] chaine2 = new string[26];
            string[] chaine3 = new string[26];

            //assigniation des chaines aux tbs

            alphabet[0] = "1";
            alphabet[1] = "2";
            alphabet[2] = "3";
            alphabet[3] = "4";
            alphabet[4] = "5";
            alphabet[5] = "6";
            alphabet[6] = "7";
            alphabet[7] = "8";
            alphabet[8] = "9";
            alphabet[9] = "10";
            alphabet[10] = "11";
            alphabet[11] = "12";
            alphabet[12] = "13";
            alphabet[13] = "14";
            alphabet[14] = "15";
            alphabet[15] = "16";
            alphabet[16] = "17";
            alphabet[17] = "18";
            alphabet[18] = "19";
            alphabet[19] = "20";
            alphabet[20] = "21";
            alphabet[21] = "22";
            alphabet[22] = "23";
            alphabet[23] = "24";
            alphabet[24] = "25";
            alphabet[25] = "26";

            chaine1[0] = "4";
            chaine1[1] = "13";
            chaine1[2] = "20";
            chaine1[3] = "23";
            chaine1[4] = "19";
            chaine1[5] = "9";
            chaine1[6] = "12";
            chaine1[7] = "18";
            chaine1[8] = "21";
            chaine1[9] = "25";
            chaine1[10] = "17";
            chaine1[11] = "14";
            chaine1[12] = "11";
            chaine1[13] = "6";
            chaine1[14] = "5";
            chaine1[15] = "10";
            chaine1[16] = "3";
            chaine1[17] = "1";
            chaine1[18] = "26";
            chaine1[19] = "2";
            chaine1[20] = "16";
            chaine1[21] = "7";
            chaine1[22] = "24";
            chaine1[23] = "15";
            chaine1[24] = "8";
            chaine1[25] = "22";

            chaine2[0] = "8";
            chaine2[1] = "17";
            chaine2[2] = "25";
            chaine2[3] = "7";
            chaine2[4] = "16";
            chaine2[5] = "10";
            chaine2[6] = "19";
            chaine2[7] = "13";
            chaine2[8] = "15";
            chaine2[9] = "2";
            chaine2[10] = "17";
            chaine2[11] = "14";
            chaine2[12] = "3";
            chaine2[13] = "9";
            chaine2[14] = "6";
            chaine2[15] = "4";
            chaine2[16] = "25";
            chaine2[17] = "1";
            chaine2[18] = "23";
            chaine2[19] = "22";
            chaine2[20] = "5";
            chaine2[21] = "21";
            chaine2[22] = "19";
            chaine2[23] = "18";
            chaine2[24] = "11";
            chaine2[25] = "24";

            chaine3[0] = "21";
            chaine3[1] = "17";
            chaine3[2] = "14";
            chaine3[3] = "20";
            chaine3[4] = "12";
            chaine3[5] = "19";
            chaine3[6] = "26";
            chaine3[7] = "6";
            chaine3[8] = "13";
            chaine3[9] = "18";
            chaine3[10] = "5";
            chaine3[11] = "8";
            chaine3[12] = "4";
            chaine3[13] = "16";
            chaine3[14] = "24";
            chaine3[15] = "11";
            chaine3[16] = "9";
            chaine3[17] = "2";
            chaine3[18] = "22";
            chaine3[19] = "25";
            chaine3[20] = "7";
            chaine3[21] = "10";
            chaine3[22] = "3";
            chaine3[23] = "23";
            chaine3[24] = "15";
            chaine3[25] = "1";





            //assignation des combinaisons aux rotor1 en fonction de ce que veux le user
            if (posInitRotors[0] == 1)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig1[i].lettreOutput = chaine1[i].ToString();
                    rotorConfig1[i].lettreInput = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 2)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig1[i].lettreOutput = chaine2[i].ToString();
                    rotorConfig1[i].lettreInput = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[0] == 3)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig1[i].lettreOutput = chaine3[i].ToString();
                    rotorConfig1[i].lettreInput = alphabet[i].ToString();
                }
            }


            //assignation des combinaisons aux rotor2 en fonction de ce que veux le user
            if (posInitRotors[1] == 1)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig2[i].lettreOutput = chaine1[i].ToString();
                    rotorConfig2[i].lettreInput = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[1] == 2)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig2[i].lettreOutput = chaine2[i].ToString();
                    rotorConfig2[i].lettreInput = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[1] == 3)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig2[i].lettreOutput = chaine3[i].ToString();
                    rotorConfig2[i].lettreInput = alphabet[i].ToString();
                }
            }

            //assignation des combinaisons aux rotor3 en fonction de ce que veux le user
            if (posInitRotors[2] == 1)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig3[i].lettreOutput = chaine1[i].ToString();
                    rotorConfig3[i].lettreInput = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[2] == 2)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig3[i].lettreOutput = chaine2[i].ToString();
                    rotorConfig3[i].lettreInput = alphabet[i].ToString();
                }

            }
            else if (posInitRotors[2] == 3)
            {
                for (int i = 0; i <= 25; i++)
                {
                    rotorConfig3[i].lettreOutput = chaine3[i].ToString();
                    rotorConfig3[i].lettreInput = alphabet[i].ToString();
                }
            }

            //configuration de la position initiale des rotors

            for (int i = 0;i < placementInitRotors[0]; i++)
            {
                string tempRotor1_0 = rotorConfig1[0].lettreInput, tempRotor1_2 = rotorConfig1[0].lettreOutput;
                for (int j = 0; j < rotorConfig1.GetLength(0) - 1; j++)
                {
                    rotorConfig1[j].lettreInput = rotorConfig1[j + 1].lettreInput;
                    rotorConfig1[j].lettreOutput = rotorConfig1[j + 1].lettreOutput;
                }

                rotorConfig1[25].lettreInput = tempRotor1_0;
                rotorConfig1[25].lettreOutput = tempRotor1_2;
            }

            for (int i = 0; i < placementInitRotors[1]; i++)
            {
                string tempRotor1_0 = rotorConfig2[0].lettreInput, tempRotor1_2 = rotorConfig2[0].lettreOutput;
                for (int j = 0; j < rotorConfig2.GetLength(0) - 1; j++)
                {
                    rotorConfig2[j].lettreInput = rotorConfig2[j + 1].lettreInput;
                    rotorConfig2[j].lettreOutput = rotorConfig2[j + 1].lettreOutput;
                }

                rotorConfig2[25].lettreInput = tempRotor1_0;
                rotorConfig2[25].lettreOutput = tempRotor1_2;
            }

            for (int i = 0; i < placementInitRotors[1]; i++)
            {
                string tempRotor1_0 = rotorConfig3[0].lettreInput, tempRotor1_2 = rotorConfig3[0].lettreOutput;
                for (int j = 0; j < rotorConfig3.GetLength(0) - 1; j++)
                {
                    rotorConfig3[j].lettreInput = rotorConfig3[j + 1].lettreInput;
                    rotorConfig3[j].lettreOutput = rotorConfig3[j + 1].lettreOutput;
                }

                rotorConfig3[25].lettreInput = tempRotor1_0;
                rotorConfig3[25].lettreOutput = tempRotor1_2;
            }

        }

        static void turnRotors(ref Rotor1[] rotor1, ref Rotor2[] rotor2, ref Rotor3[] rotor3, ref int nbrpassRtr2)
        {
            string tempRotor1_0 = rotor1[0].lettreInput, tempRotor1_2 = rotor1[0].lettreOutput, tempRotor2_0 = rotor2[0].lettreInput, tempRotor2_2 = rotor2[0].lettreOutput, tempRotor3_0 = rotor3[0].lettreInput, tempRotor3_2 = rotor3[0].lettreOutput;
            for (int i = 0; i < rotor1.GetLength(0) - 1; i++)
            {
                rotor1[i].lettreInput = rotor1[i + 1].lettreInput;
                rotor1[i].lettreOutput = rotor1[i + 1].lettreOutput;
            }

            rotor1[25].lettreInput = tempRotor1_0;
            rotor1[25].lettreOutput = tempRotor1_2;

            if (rotor1[0].lettreInput == "1")
            {
                for (int i = 0; i < rotor1.GetLength(0) - 1; i++)
                {
                    rotor2[i].lettreInput = rotor2[i + 1].lettreInput;
                    rotor2[i].lettreOutput = rotor2[i + 1].lettreOutput;
                }

                rotor2[25].lettreInput = tempRotor2_0;
                rotor2[25].lettreOutput = tempRotor2_2;
            }

            nbrpassRtr2++;

            if (rotor2[0].lettreInput == "1" && nbrpassRtr2 == 27)
            {
                for (int i = 0;i < rotor2.GetLength(0) - 1; i++)
                {
                    rotor3[i].lettreInput = rotor3[i + 1].lettreInput;
                    rotor3[i].lettreOutput = rotor3[i + 1].lettreOutput;
                }

                rotor3[25].lettreInput = tempRotor3_0;
                rotor3[25].lettreOutput = tempRotor3_2;

                nbrpassRtr2 = 0;
            }
        }

        public void setTBconnexion(string UinputTBConnexion, out string message, TBconnexion[] tbConnexion, out bool confirm)     //faire une entrée en plusieurs étapes et pas 1
        {
            bool doublon = false;
            bool delete = false;
            confirm = false;
            message = string.Empty;

            if (UinputTBConnexion == "")
            {
                delete = true;
            }
                                                        //vérifie qu'il n'y as pas 2 fois la même lettre dans le Tableau de connexions
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
            if (doublon == false && delete == false)
            {
                for(int i = 0;i < 13;i++)
                {
                    if (tbConnexion[i].lettre1 == null)
                    {
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
            }else if (doublon == false && delete == true)
            {
                for (int i = 0; i < 13; i++)
                {
                    if (tbConnexion[i].lettre1 == null)
                    {
                        tbConnexion[i - 1].lettre2 = null;
                        confirm = false;
                        i = 14;

                    }
                    else if (tbConnexion[i].lettre2 == null)
                    {
                        tbConnexion[i].lettre1 = null;
                        confirm = false;
                        i = 14;
                    }
                }
            }
        }

        public void crypt(int[] posInitRotors, string message, TBconnexion[] tbConnexion, ref Rotor1[] rotor1, ref Rotor2[] rotor2, ref Rotor3[] rotor3, out string cryptedMessage)
        {
            string lettre;
            string cryptedLettre = "" ;
            cryptedMessage = "";
            int nbrpassRtr2 = 0;


            for (int i = 0; i < message.Length; i++)
            {
                if (message[i].ToString() != " ")
                {
                    turnRotors(ref rotor1, ref rotor2, ref rotor3, ref nbrpassRtr2);
                    cryptedLettre = message[i].ToString();
                    cryptTbconnexion2(ref cryptedLettre, tbConnexion);
                    cryptRotorPass(ref cryptedLettre, ref rotor1, ref rotor2, ref rotor3);
                    cryptTbconnexion2(ref cryptedLettre, tbConnexion);
                    //test purpus
                    cryptedMessage += cryptedLettre;
                }
                else
                {
                    cryptedMessage += message[i];
                }
            }
            int posFinalRotor1 = int.Parse(rotor1[0].lettreInput) - 1;
            int posFinalRotor2 = int.Parse(rotor2[0].lettreInput) - 1;
            int posFinalRotor3 = int.Parse(rotor3[0].lettreInput) - 1;
            cryptedMessage += "\n\n\n\n\n les dernières positions des rotors sont : \n\n- rotor 1 : " + posFinalRotor1 + "\n- rotor 2 : " + posFinalRotor2 + "\n- rotor 3 : " + posFinalRotor3;
        }

        static void cryptTbconnexion2(ref string cryptedLettre, TBconnexion[] tbConnexion)
        {
            bool converted = false;

            for (int i = 0; i < 13; i++)
            {
                if (cryptedLettre == tbConnexion[i].lettre1)
                {
                    cryptedLettre = tbConnexion[i].lettre2;
                    converted = true;
                    i = 15;
                }
                else if (cryptedLettre == tbConnexion[i].lettre2)
                {
                    cryptedLettre = tbConnexion[i].lettre1;
                    converted = true;
                    i = 15;
                }
            }

            if (converted == false)
            {
                cryptedLettre = cryptedLettre;
            }
        }

        static void cryptRotorPass(ref string cryptedLettre, ref Rotor1[] rotor1, ref Rotor2[] rotor2, ref Rotor3[] rotor3)
        {
            int posNextRotor;

            convertLettreToNumber(ref cryptedLettre);

            posNextRotor = int.Parse(rotor1[int.Parse(cryptedLettre) - 1].lettreOutput);
            cryptedLettre = rotor2[posNextRotor].lettreInput;
            posNextRotor = int.Parse(rotor2[int.Parse(cryptedLettre) - 1].lettreOutput);
            cryptedLettre = rotor3[posNextRotor].lettreInput;
            posNextRotor = int.Parse(rotor3[int.Parse(cryptedLettre) - 1].lettreOutput);
            cryptedLettre = rotor3[posNextRotor].lettreInput;
            posNextRotor = int.Parse(rotor3[int.Parse(cryptedLettre) - 1].lettreOutput);
            cryptedLettre = rotor2[posNextRotor].lettreInput;
            posNextRotor = int.Parse(rotor2[int.Parse(cryptedLettre) - 1].lettreOutput);
            cryptedLettre = rotor1[posNextRotor].lettreInput;

            convertNumbersToLetters(ref cryptedLettre);

        }


        static void convertLettreToNumber(ref string cryptedLettre)
        {
            if (cryptedLettre.ToLower() == "a")
            {
                cryptedLettre = "1";
            }
            else if (cryptedLettre.ToLower() == "b")
            {
                cryptedLettre = "2";
            }
            else if (cryptedLettre.ToLower() == "c")
            {
                cryptedLettre = "3";
            }
            else if (cryptedLettre.ToLower() == "d")
            {
                cryptedLettre = "4";
            }
            else if (cryptedLettre.ToLower() == "e")
            {
                cryptedLettre = "5";
            }
            else if (cryptedLettre.ToLower() == "f")
            {
                cryptedLettre = "6";
            }
            else if (cryptedLettre.ToLower() == "g")
            {
                cryptedLettre = "7";
            }
            else if (cryptedLettre.ToLower() == "h")
            {
                cryptedLettre = "8";
            }
            else if (cryptedLettre.ToLower() == "i")
            {
                cryptedLettre = "9";
            }
            else if (cryptedLettre.ToLower() == "j")
            {
                cryptedLettre = "10";
            }
            else if (cryptedLettre.ToLower() == "k")
            {
                cryptedLettre = "11";
            }
            else if (cryptedLettre.ToLower() == "l")
            {
                cryptedLettre = "12";
            }
            else if (cryptedLettre.ToLower() == "m")
            {
                cryptedLettre = "13";
            }
            else if (cryptedLettre.ToLower() == "n")
            {
                cryptedLettre = "14";
            }
            else if (cryptedLettre.ToLower() == "o")
            {
                cryptedLettre = "15";
            }
            else if (cryptedLettre.ToLower() == "p")
            {
                cryptedLettre = "16";
            }
            else if (cryptedLettre.ToLower() == "q")
            {
                cryptedLettre = "17";
            }
            else if (cryptedLettre.ToLower() == "r")
            {
                cryptedLettre = "18";
            }
            else if (cryptedLettre.ToLower() == "s")
            {
                cryptedLettre = "19";
            }
            else if (cryptedLettre.ToLower() == "t")
            {
                cryptedLettre = "20";
            }
            else if (cryptedLettre.ToLower() == "u")
            {
                cryptedLettre = "21";
            }
            else if (cryptedLettre.ToLower() == "v")
            {
                cryptedLettre = "22";
            }
            else if (cryptedLettre.ToLower() == "w")
            {
                cryptedLettre = "23";
            }
            else if (cryptedLettre.ToLower() == "x")
            {
                cryptedLettre = "24";
            }
            else if (cryptedLettre.ToLower() == "y")
            {
                cryptedLettre = "25";
            }
            else if (cryptedLettre.ToLower() == "z")
            {
                cryptedLettre = "26";
            }
        }


        static void convertNumbersToLetters(ref string cryptedLettre)
        {
            if (cryptedLettre == "1")
            {
                cryptedLettre = "a";
            }
            else if (cryptedLettre == "2")
            {
                cryptedLettre = "b";
            }
            else if (cryptedLettre == "3")
            {
                cryptedLettre = "c";
            }
            else if (cryptedLettre == "4")
            {
                cryptedLettre = "d";
            }
            else if (cryptedLettre == "5")
            {
                cryptedLettre = "e";
            }
            else if (cryptedLettre == "6")
            {
                cryptedLettre = "f";
            }
            else if (cryptedLettre == "7")
            {
                cryptedLettre = "g";
            }
            else if (cryptedLettre == "8")
            {
                cryptedLettre = "h";
            }
            else if (cryptedLettre == "9")
            {
                cryptedLettre = "i";
            }
            else if (cryptedLettre == "10")
            {
                cryptedLettre = "j";
            }
            else if (cryptedLettre == "11")
            {
                cryptedLettre = "k";
            }
            else if (cryptedLettre == "12")
            {
                cryptedLettre = "l";
            }
            else if (cryptedLettre == "13")
            {
                cryptedLettre = "m";
            }
            else if (cryptedLettre == "14")
            {
                cryptedLettre = "n";
            }
            else if (cryptedLettre == "15")
            {
                cryptedLettre = "o";
            }
            else if (cryptedLettre == "16")
            {
                cryptedLettre = "p";
            }
            else if (cryptedLettre == "17")
            {
                cryptedLettre = "q";
            }
            else if (cryptedLettre == "18")
            {
                cryptedLettre = "r";
            }
            else if (cryptedLettre == "19")
            {
                cryptedLettre = "s";
            }
            else if (cryptedLettre == "20")
            {
                cryptedLettre = "t";
            }
            else if (cryptedLettre == "21")
            {
                cryptedLettre = "u";
            }
            else if (cryptedLettre == "22")
            {
                cryptedLettre = "v";
            }
            else if (cryptedLettre == "23")
            {
                cryptedLettre = "w";
            }
            else if (cryptedLettre == "24")
            {
                cryptedLettre = "x";
            }
            else if (cryptedLettre == "25")
            {
                cryptedLettre = "y";
            }
            else if (cryptedLettre == "26")
            {
                cryptedLettre = "z";
            }

        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        public void decrypt(int[] posInitRotors, string message, TBconnexion[] tbConnexion, ref Rotor1[] rotor1, ref Rotor2[] rotor2, ref Rotor3[] rotor3, out string cryptedMessage)
        {
            string cryptedLettre = "";
            cryptedMessage = "";
            int nbrpassRtr2 = 0;


            for (int i = message.Length - 1; i >= 0; i--)
            {
                if (message[i].ToString() != " ")
                {
                    cryptedLettre = message[i].ToString();
                    cryptTbconnexion2(ref cryptedLettre, tbConnexion);
                    cryptRotorPass(ref cryptedLettre, ref rotor1, ref rotor2, ref rotor3);
                    cryptTbconnexion2(ref cryptedLettre, tbConnexion);
                    cryptedMessage += cryptedLettre;
                    inverseTurnRotors(ref rotor1, ref rotor2, ref rotor3, ref nbrpassRtr2);
                }
                else
                {
                    cryptedMessage += message[i];
                }
            }
        }


        static void inverseTurnRotors(ref Rotor1[] rotor1, ref Rotor2[] rotor2, ref Rotor3[] rotor3, ref int nbrpassRtr2)
        {
            string tempRotor1_0 = rotor1[25].lettreInput, tempRotor1_2 = rotor1[25].lettreOutput, tempRotor2_0 = rotor2[25].lettreInput, tempRotor2_2 = rotor2[25].lettreOutput, tempRotor3_0 = rotor3[25].lettreInput, tempRotor3_2 = rotor3[25].lettreOutput;
            for (int i = 24; i >= 0; i--)
            {
                rotor1[i].lettreInput = rotor1[i + 1].lettreInput;
                rotor1[i].lettreOutput = rotor1[i + 1].lettreOutput;
            }

            rotor1[25].lettreInput = tempRotor1_0;
            rotor1[25].lettreOutput = tempRotor1_2;

            if (rotor1[0].lettreInput == "1")
            {
                for (int i = 24; i >= 0; i--)
                {
                    rotor2[i].lettreInput = rotor2[i + 1].lettreInput;
                    rotor2[i].lettreOutput = rotor2[i + 1].lettreOutput;
                }

                rotor2[25].lettreInput = tempRotor2_0;
                rotor2[25].lettreOutput = tempRotor2_2;
            }

            nbrpassRtr2++;

            if (rotor2[0].lettreInput == "1" && nbrpassRtr2 == 27)
            {
                for (int i = 24; i >= 0; i--)
                {
                    rotor3[i].lettreInput = rotor3[i + 1].lettreInput;
                    rotor3[i].lettreOutput = rotor3[i + 1].lettreOutput;
                }

                rotor3[25].lettreInput = tempRotor3_0;
                rotor3[25].lettreOutput = tempRotor3_2;

                nbrpassRtr2 = 0;
            }
        }
    }
}
