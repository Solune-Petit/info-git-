using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _5T24_PetitSolune_enigma
{
    public class fonctions
    {
        public void rndRotors(string[,] rotors, int[] posInitRotors)
        {
            Random rnd = new Random();

            for (int i = 0; i < 3; i++)
            {
                posInitRotors[i] = rnd.Next(65, 91);
                char lettre = (char)posInitRotors[i];

                for (int j = 0; j < 26; j++)
                {
                    rotors[i, j] = lettre.ToString();
                    lettre++;
                    if(lettre == char.Parse("["))
                    {
                        lettre = (char)65;
                    }
                }
            }
        }


        public void cryptText(string[,] rotors, string message, int[] posInitRotors, out string cryptedMessage)
        {
            firstPass(rotors, message, posInitRotors, out cryptedMessage);
        }

        static void firstPass(string[,] rotors, string message, int[] posInitRotors, out string cryptedMessage)
        {
            bool step1 = false;
            bool step2 = false;

            cryptedMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                char cryptingLetter = message[i];
                if (cryptingLetter == char.Parse(" "))
                {
                    cryptedMessage = cryptedMessage + cryptingLetter;
                }
                else
                {
                    cryptingLetter = char.Parse(rotors[2, 0]);
                    step1 = true;
                    mooveRotor(step1, step2, posInitRotors);
                    step1 = false;
                    cryptingLetter = char.Parse(rotors[1, cryptingLetter - 65]);
                    step2 = true;
                    mooveRotor(step1, step2, posInitRotors);
                    cryptingLetter = char.Parse(rotors[0, cryptingLetter - 65]);
                    step2 = false;
                    cryptedMessage += cryptingLetter;
                }
            }
        }

        static void mooveRotor(bool step1, bool step2, bool step3, string[,] rotors, int[] posInitRotors)
        {
            if (step1)
            {
                string tempVar = rotors[2, 0];
                for (int i = 0; i < rotors.GetLength(1) - 1; i++)
                {
                    rotors[2, i] = rotors[2, i + 1];
                }
                rotors[2, 25] = tempVar;
            }else if (step2 && rotors[2,25] == ((char)posInitRotors[0]).ToString())
            {
                string tempVar = rotors[1, 0];
                for (int i = 0; i < rotors.GetLength(1) - 1; i++)
                {
                    rotors[2, i] = rotors[1, i + 1];
                }
                rotors[2, 25] = tempVar;
            }else if (step3 && rotors[1, 25] == ((char)posInitRotors[0]).ToString())
            {
                string tempVar = rotors[0, 0];
                for (int i = 0; i < rotors.GetLength(1) - 1; i++)
                {
                    rotors[2, i] = rotors[0, i + 1];
                }
                rotors[2, 25] = tempVar;
            }
        }
    }
}
