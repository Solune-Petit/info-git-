using System.Reflection.Emit;

namespace _5TTI_Solune_P_ecritureSecrete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Uinput = null;
            string sortie = "";

            //ConsoleColor.Red
            Console.WriteLine("Écriture secrete");
            //ConsoleColor.White

            Thread.Sleep(1000);

            Console.WriteLine("quel est votre phrase ?");
            Uinput = Console.ReadLine();

            encripteur(Uinput ,out sortie);
        }

        public static void encripteur(string Uinput, out string sortie)
        {
            string listeABC = "abcdefghijklmnopqrstuvwxyz";
            uint nbrchractere = 0;

            for (int i = 0; i < Uinput.Length; i++)
            {
                uint.TryParse(Uinput[i], out uint a);
                if (a >= 0)
                {
                    sortie += Math.Abs((a - 10));
                } else if ((int)Uinput[i] == 1)
                {
                    sortie += "a";
                } else if (Uinput[i] == "z")
                {
                    sortie += "b";
                } else if (Uinput[i] == " ")
                {
                    sortie += "+";
                } else {
                    sortie += listeABC[i];
                }
            }
        }
    }
}