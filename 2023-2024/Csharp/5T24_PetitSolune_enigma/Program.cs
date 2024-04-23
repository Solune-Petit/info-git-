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
            string cryptedMessage = null;
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
                //configuration des rotors (refaire ça avec tryParse)
                do {
                    Console.WriteLine("quel est le premier rotor que vous voulez utilliser ?");
                    posInitRotors[0] = int.Parse(Console.ReadLine());
                    Console.WriteLine("quel est le deuxième rotor que vous voulez utilliser ?");
                    posInitRotors[1] = int.Parse(Console.ReadLine());
                    Console.WriteLine("quel est le troisième rotor que vous voulez utilliser ?");
                    posInitRotors[2] = int.Parse(Console.ReadLine());
                } while (posInitRotors[0] == posInitRotors[1] && posInitRotors[0]== posInitRotors[2] && posInitRotors[1] == posInitRotors[2]);
                mesOutils.rotorControl(posInitRotors,out string[,] rotor1, out string[,] rotor2, out string[,] rotor3);

                //configuration du tableau de connexion
                do
                {
                    Console.WriteLine(message + "\n \n");
                    Console.Write("[");

                    for (int i  = 0; i < tbConnexion.Length; i++)
                    {
                        Console.Write(tbConnexion[i].lettre1);
                        Console.Write(tbConnexion[i].lettre2 + "][");
                    }

                    Console.WriteLine("quels sont les connexions que vous voulez ? \n(si vous ne voulez plus de connexions, mettez juste un espace)");
                    UinputTBConnexion = Console.ReadLine();
                    mesOutils.setTBconnexion(UinputTBConnexion, out message, tbConnexion, out probleme);
                    Console.Clear();
                } while (UinputTBConnexion != " " || probleme);



                Console.WriteLine("quel est le message à encrypter ?");
                message = Console.ReadLine();
                Console.Clear();
                mesOutils.crypt(posInitRotors, message, tbConnexion, rotor1, rotor2, rotor3, out cryptedMessage);
                Console.WriteLine(cryptedMessage);
                Console.ReadLine();
            }
            else
            {

            }

        }
    }
}
