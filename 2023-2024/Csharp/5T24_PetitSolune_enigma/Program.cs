namespace _5T24_PetitSolune_enigma
{
    namespace Structures
    {
        public struct Rotors
        {
            public string[,] rotor1;
            public string[,] rotor2;
            public string[,] rotor3; 
            
            public Rotors()
            {
                rotor1 = new string[2, 25];
                rotor2 = new string[2, 25];
                rotor3 = new string[2, 25];
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] posInitRotors = new int[3];
            string message;
            string usage = "";
            do
            {
                Console.WriteLine("bienvenue sur la machine Enigma. Devez-vous décrypter ou encrypter un message ?");
                usage = Console.ReadLine();
                Console.Clear();

            } while (usage != "encrypter" && usage != "décrypter");

            if (usage == "encrypter")
            {
                Console.WriteLine("quel est le message à encrypter ?");
                message = Console.ReadLine();
                Console.Clear();
                crypting(posInitRotors, message);
            }
            else
            {

            }

        }

        static void crypting(int[] posInitRotors, string message)
        {
            fonctions mesOutils = new fonctions();
            mesOutils.rndRotors(posInitRotors);

            for (int i = 0; i < Rotors.GetLength(0); i++)
            {
                for (int j = 0; j < rotors.GetLength(1); j++)
                {
                    string temp = rotors[i, j];
                    Console.Write(temp + " | ");
                }

                Console.WriteLine("");
            }

            mesOutils.cryptText(rotors, message, posInitRotors, out string cryptedMessage);

            Console.WriteLine(cryptedMessage);

        }
    }
}
