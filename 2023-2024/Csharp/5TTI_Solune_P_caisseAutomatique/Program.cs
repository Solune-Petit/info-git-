using System.Security.Cryptography.X509Certificates;

namespace _5TTI_Solune_P_caisseAutomatique
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("programme qui vous décompose un prix en combiens de billet sont nécéssaires");

            int input;
            string recommancer;
            string message = null;

            do
            { 
                Console.WriteLine("de combien est-ce que vous allez payer ???");
                input = int.Parse(Console.ReadLine());

                Calcul(input, out message);

                Console.WriteLine(message + "\n \n Voulez-vous recommancer ??? (true / false)");
                recommancer = Console.ReadLine();
                
            } while (recommancer == "true");

        }

        public static void Calcul(int input, out string message)
        {
            int nbrBillets100 = 0;
            int nbrBillets200 = 0;
            int nbrBillets50 = 0;
            int nbrBillets20 = 0;
            int nbrBillets10 = 0;
            int nbrBillets5 = 0;
            int nbrPiece2 = 0;
            int nbrPiece1 = 0;

            int nbrBillets500 = input / 500;
            input = input % 500;
            nbrBillets200 = input / 200;
            input = input % 200;
            nbrBillets100 = input / 100;
            input = input % 100;
            nbrBillets50 = input / 50;
            input = input % 50;
            nbrBillets20 = input / 20;
            input = input % 20;
            nbrBillets10 = input / 10;
            input = input % 10;
            nbrBillets5 = input / 5;
            input = input % 5;
            nbrPiece2 = input / 2;
            input = input % 2;
            nbrPiece1 = input / 1;
            

            message = "il vous faut " + nbrBillets500 + " billets de 500 ; " + nbrBillets200 + " billets de 200 ; " + nbrBillets100 + " billets de 100 ; " + nbrBillets50 + " billets de 50 ; " + nbrBillets20 + " billets de 20 ; " + nbrBillets10 + " billets de 10 ; " + nbrBillets5 + " billets de 5 ; " + nbrPiece2 + " pièces de 2 ; " + nbrPiece1 + " pièces de 1";
            //Console.WriteLine(message);
        }
    }
}