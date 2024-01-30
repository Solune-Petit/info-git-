using _5TTI_Solune_P_algoDeTris;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

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

            double temp = tableauTrie[0];
            Console.WriteLine(temp + " | ");
            for (int i = 1; i < tableauTrie.Length; i++)
            {
                temp = tableauTrie[i];
                Console.Write(temp + " | ");

            }


            Console.WriteLine("\n quel méthode voulez vous utiliser ? (intuitif = 1 / selection = 2 / bulle = 3 / shell = 4 / encastrement = 5 / tout pour comparer = 6");
            choix = int.Parse(Console.ReadLine());

            Console.Clear();

            if (choix == 1)
            {
                triIntuitif(tableauTrie, out string phrase);
                Console.WriteLine(phrase);
            }
            else if (choix == 2)
            {
                triSelection(tableauTrie, out string phrase);
                Console.WriteLine(phrase);
            }
            else if (choix == 3)
            {
                triBulle(tableauTrie, out string phrase);
                Console.WriteLine(phrase);
            }
            else if (choix == 4)
            {
                triShell(tableauTrie, out string phrase);
                Console.WriteLine(phrase);
            }
            else if (choix == 5)
            {
                triEncastrement(tableauTrie, out string phrase);
                Console.WriteLine(phrase);
            }else if (choix == 6)
            {
                tousLesTris(tableau, tableauTrie, out string phrase);
                Console.WriteLine(phrase);
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

            static void triIntuitif(double[] tableauTrie, out string phrase)
            {
                Fonctions mesOutils = new Fonctions();
                phrase = string.Empty;
                Stopwatch chrono = new Stopwatch();
                chrono.Start();
                mesOutils.intuitif(tableauTrie);
                chrono.Stop();
                long millisec = chrono.ElapsedMilliseconds;
                for (int i = 0;i < tableauTrie.Length; i++)
                {
                    double temp = tableauTrie[i];
                    phrase = phrase + temp.ToString() + " | ";
                }
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode intuitif";
            }

            static void triSelection(double[] tableauTrie, out string phrase)
            {
                Fonctions mesOutils = new Fonctions();
                phrase = string.Empty;
                Stopwatch chrono = new Stopwatch();
                chrono.Start();
                mesOutils.selection(tableauTrie);
                chrono.Stop();
                long millisec = chrono.ElapsedMilliseconds;
                for (int i = 0; i < tableauTrie.Length; i++)
                {
                    double temp = tableauTrie[i];
                    phrase = phrase + temp.ToString() + " | ";
                }
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode sélection";
            }

            static void triBulle(double[] tableauTrie, out string phrase)
            {
                Fonctions mesOutils = new Fonctions();
                phrase = string.Empty;
                Stopwatch chrono = new Stopwatch();
                chrono.Start();
                mesOutils.bulle(tableauTrie);
                chrono.Stop();
                long millisec = chrono.ElapsedMilliseconds;
                for (int i = 0; i < tableauTrie.Length; i++)
                {
                    double temp = tableauTrie[i];
                    phrase = phrase + temp.ToString() + " | ";
                }
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode bulle";
            }

            static void triShell(double[] tableauTrie, out string phrase)
            {
                Fonctions mesOutils = new Fonctions();
                phrase = string.Empty;
                Stopwatch chrono = new Stopwatch();
                chrono.Start();
                mesOutils.shell(tableauTrie);
                chrono.Stop();
                long millisec = chrono.ElapsedMilliseconds;
                for (int i = 0; i < tableauTrie.Length; i++)
                {
                    double temp = tableauTrie[i];
                    phrase = phrase + temp.ToString() + " | ";
                }
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode shell";
            }

            static void triEncastrement(double[] tableauTrie, out string phrase)
            {
                Fonctions mesOutils = new Fonctions();
                phrase = string.Empty;
                Stopwatch chrono = new Stopwatch();
                chrono.Start();
                mesOutils.encastrement(tableauTrie);
                chrono.Stop();
                long millisec = chrono.ElapsedMilliseconds;
                for (int i = 0; i < tableauTrie.Length; i++)
                {
                    double temp = tableauTrie[i];
                    phrase = phrase + temp.ToString() + " | ";
                }
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode encastrement";
            }

            static void tousLesTris(double[] tableau, double[] tableauTrie, out string phrase)
            {
                tableauTrie = tableau;

                Fonctions mesOutils = new Fonctions();
                phrase = string.Empty;
                Stopwatch chrono = new Stopwatch();
                chrono.Start();
                mesOutils.intuitif(tableauTrie);
                chrono.Stop();
                long millisec = chrono.ElapsedMilliseconds;
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode intuitif";

                //-------------------------

                tableauTrie = tableau;
                chrono = new Stopwatch();
                chrono.Start();
                mesOutils.selection(tableauTrie);
                chrono.Stop();
                millisec = chrono.ElapsedMilliseconds;
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode selection";

                //--------------------------

                tableauTrie = tableau;
                chrono = new Stopwatch();
                chrono.Start();
                mesOutils.bulle(tableauTrie);
                chrono.Stop();
                millisec = chrono.ElapsedMilliseconds;
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode bulle";

                //--------------------------

                tableauTrie = tableau;
                chrono = new Stopwatch();
                chrono.Start();
                mesOutils.shell(tableauTrie);
                chrono.Stop();
                millisec = chrono.ElapsedMilliseconds;
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode shell";

                //--------------------------

                tableauTrie = tableau;
                chrono = new Stopwatch();
                chrono.Start();
                mesOutils.encastrement(tableauTrie);
                chrono.Stop();
                millisec = chrono.ElapsedMilliseconds;
                phrase = phrase + "\n il a fallut " + millisec + " millisecondes pour trier ce tableau avec la méthode encastrement";
            }
        }
    }
}