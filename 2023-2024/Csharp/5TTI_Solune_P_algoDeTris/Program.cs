using _5TTI_Solune_P_algoDeTris;
using System.Runtime.InteropServices;

namespace _5TTI_Solune_P_algorithmesDeTri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programme de tri de tableaux");
            int choix;
            int tailleTableau;
            double[] tableau;
            Console.WriteLine("de quel taille voulez-vous votre tableau ?");
            tailleTableau = int.Parse(Console.ReadLine());
            generateurTableaux(tailleTableau, out tableau);
            double[] tableauTrie = tableau;

            for (int i = 0; i < tableauTrie.Length; i++)
            {
                double temp = tableauTrie[i];
                Console.WriteLine(temp + " | ");

            }


            Console.WriteLine("quel méthode voulez vous utiliser ? (intuitif = 1 / selection = 2 / bulle = 3 / shell = 4 / encastrement = 5");
            choix = int.Parse(Console.ReadLine());

            if (choix == 1)
            {
                fonctions.intuitif(tableauTrie);
            }
            else if (choix == 2)
            {
                fonctions.selection(tableauTrie);
            }
            else if (choix == 3)
            {
                fonctions.bulle(tableauTrie);
            }
            else if (choix == 4)
            {
                fonctions.shell(tableauTrie);
            }
            else if (choix == 5)
            {
                fonctions.encastrement(tableauTrie);
            }

            for (int i = 0; i < tableauTrie.Length; i++)
            {
                double temp = tableauTrie[i];
                Console.WriteLine(temp + " | ");
            }

            static void generateurTableaux(int tailleTableau, out double[] tableau)
            {
                //création d'un tableau aléatoire
                Random alea = new Random();
                tableau = new double[tailleTableau];
                for (int i = 0; i < tailleTableau; i++)
                {
                    tableau[i] = alea.Next(1, 101);
                }
            }
        }
    }