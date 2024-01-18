using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _5TTI_Solune_P_concatenation
{
    using System;
    using System.Threading;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("faire des triangles");

            uint nbrColonnes;
            uint nbrLignes;
            string recommancer;
            string strNbrLignes = null;
            do
            {
                string sortie = "";
                uint spaces = 1;
                Console.WriteLine("combiens de ligne voulez vous ?");
                nbrLignes = uint.Parse(Console.ReadLine());
                //LireReel(strNbrLignes, out uint nbrLignes);
                Console.WriteLine("combiens de colonnes voulez vous ?");

                //Console.WriteLine(nbrLignes);
                //Console.WriteLine(nbrColonnes);

                Console.Clear();

                for (uint i = 0; i < nbrLignes; i++)
                {
                    if (sortie == "")
                    {
                        sortie += "X";
                    }
                    else if (i == nbrLignes-1)
                    {
                        sortie += "X";
                    }
                    else
                    {
                        sortie += "O";
                    }
                    Console.WriteLine(sortie);
                }
                sortie = " ";

                Thread.Sleep(2000);
                Console.Clear();

                for (int i = 0; i <= 9; i++)
                {
                    for (int j = 0; j <= 9 - i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine(); // Newline here
                    Console.Write(sortie);
                    sortie += " ";
                }

                Thread.Sleep(5000);
                //Console.Clear();



                Console.WriteLine("voulez-vous recommancer ?");
                recommancer = Console.ReadLine();
            } while (recommancer == "t");
        }

        //static void LireReel(string strNbrLignes , out uint nbrLignes)
        //{ 
        //    uint nbrLignes = 0;
        //    strNbrLignes = Console.ReadLine();
        //    while (!uint.TryParse(strNbrLignes, out nbrLignes))
        //    {
        //        Console.WriteLine("Attention ! vous devez taper un nombre réel !");
        //        strNbrLignes = Console.ReadLine();
        //    }
        //}

        //static void LireReel1(string strNbrColonnes ,out uint nbrColonnes)
        //{
        //    strNbrColonnes = Console.ReadLine();
        //    while (!uint.TryParse(strNbrColonnes, out nbrColonnes))
        //    {
        //        Console.WriteLine("Attention ! vous devez taper un nombre réel !");
        //        strNbrColonnes = Console.ReadLine();
        //    }
        //}

    }
}