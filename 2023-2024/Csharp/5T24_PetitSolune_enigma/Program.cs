using System.Drawing;

namespace _5T24_PetitSolune_enigma
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            fonctions mesOutils = new fonctions();


            int[] posInitRotors = new int[3];
            string UinputTBConnexion;
            string message = "";
            string usage = "";
            bool probleme;

            TBconnexion[] tbConnexion = new TBconnexion[13];


            do
            {
                Console.WriteLine("bienvenue sur la machine Enigma. Devez-vous décrypter ou encrypter un message ?");
                usage = Console.ReadLine();
                Console.Clear();

            } while (usage != "encrypter" && usage != "décrypter");

            if (usage == "encrypter")
            {
                //configuration des rotors
                do {
                    Console.WriteLine("quel est le premier rotor que vous voulez utilliser ?");
                    posInitRotors[0] = int.Parse(Console.ReadLine());
                    Console.WriteLine("quel est le deuxième rotor que vous voulez utilliser ?");
                    posInitRotors[1] = int.Parse(Console.ReadLine());
                    Console.WriteLine("quel est le troisième rotor que vous voulez utilliser ?");
                    posInitRotors[2] = int.Parse(Console.ReadLine());
                } while (posInitRotors[0] == posInitRotors[1] && posInitRotors[0]== posInitRotors[2] && posInitRotors[1] == posInitRotors[2]);
                mesOutils.rotorControl(posInitRotors);

                //configuration du tableau de connexion
                do
                {
                    Console.WriteLine(message);
                    Console.WriteLine("quels sont les connexions que vous voulez ? ( example : AH;JK;RG;OP)");
                    UinputTBConnexion = Console.ReadLine();
                } while (mesOutils.noDoubleConnexion(UinputTBConnexion, message));
                mesOutils.setTBconnexion(tbConnexion, UinputTBConnexion);



                Console.WriteLine("quel est le message à encrypter ?");
                message = Console.ReadLine();
                Console.Clear();
                //crypting(posInitRotors, message);
            }
            else
            {

            }

        }

        //static void crypting(int[] posInitRotors, string message)
        //{
        //    fonctions mesOutils = new fonctions();
        //    mesOutils.rndRotors(posInitRotors);

        //    for (int i = 0; i < Rotors.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < rotors.GetLength(1); j++)
        //        {
        //            string temp = rotors[i, j];
        //            Console.Write(temp + " | ");
        //        }

        //        Console.WriteLine("");
        //    }

        //    mesOutils.cryptText(rotors, message, posInitRotors, out string cryptedMessage);

        //    Console.WriteLine(cryptedMessage);

        //}
    }
}
