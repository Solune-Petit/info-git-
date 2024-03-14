namespace _5T24_PetitSolune_enigma
{
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
                Console.WriteLine("quels sont les rotors que vous voulez utilliser ?");
                Console.ReadLine();
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
