using System.Drawing;

namespace _5T24_PetitSolune_enigma
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            fonctions mesOutils = new fonctions();


            int[] posInitRotors = new int[3];
            int[] placementOriginalRotor = new int[3];
            string UinputTBConnexion;
            string message = "";
            string cryptedMessage = null;
            string usage = "";
            bool probleme;

            TBconnexion[] tbConnexion = new TBconnexion[13];
            Rotor1[] rotor1 = new Rotor1[26];
            Rotor2[] rotor2 = new Rotor2[26];
            Rotor3[] rotor3 = new Rotor3[26];



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
                    Console.WriteLine("à quel cran doit-il se placer ?");
                    placementOriginalRotor[0] = int.Parse(Console.ReadLine());
                    Console.WriteLine("quel est le deuxième rotor que vous voulez utilliser ?");
                    posInitRotors[1] = int.Parse(Console.ReadLine());
                    Console.WriteLine("à quel cran doit-il se placer ?");
                    placementOriginalRotor[1] = int.Parse(Console.ReadLine());
                    Console.WriteLine("quel est le troisième rotor que vous voulez utilliser ?");
                    posInitRotors[2] = int.Parse(Console.ReadLine());
                    Console.WriteLine("à quel cran doit-il se placer ?");
                    placementOriginalRotor[2] = int.Parse(Console.ReadLine());
                } while ((posInitRotors[0] == posInitRotors[1] && posInitRotors[0]== posInitRotors[2] && posInitRotors[1] == posInitRotors[2]) || (placementOriginalRotor[0] < 0 && placementOriginalRotor[0] > 26 && placementOriginalRotor[1] < 0 && placementOriginalRotor[1] > 26 && placementOriginalRotor[2] < 0 && placementOriginalRotor[2] > 26));
                mesOutils.rotorControl(posInitRotors, ref rotor1, ref rotor2, ref rotor3, placementOriginalRotor);

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

                    Console.WriteLine("quels sont les connexions que vous voulez ?\n- si vous voulez effacer une lettre, appuyez juste sur la touche enter\n- si vous ne voulez plus de connexions, mettez juste un espace");
                    UinputTBConnexion = Console.ReadLine();
                    mesOutils.setTBconnexion(UinputTBConnexion, out message, tbConnexion, out probleme);
                    Console.Clear();
                } while (UinputTBConnexion != " " || probleme);



                Console.WriteLine("quel est le message à encrypter ?");
                message = Console.ReadLine();
                Console.Clear();
                mesOutils.crypt(posInitRotors, message, tbConnexion, ref rotor1, ref rotor2, ref rotor3, out cryptedMessage);
                Console.WriteLine(cryptedMessage);
                Console.ReadLine();
            }
            else
            {

            }

        }
    }
}
