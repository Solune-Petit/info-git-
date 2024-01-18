namespace click_1
{
    using System;
    using System.IO;

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            bool continuer = true;
            int compteur = LireCompteur(); // Récupération de la valeur du compteur à partir du fichier
            bool check = true;
            string change = "";

            while (check)
            {
                Console.WriteLine("il y a t'il du changement ?");
                change = Console.ReadLine();
                Console.Clear();
                if (change == "y")
                {
                    Console.WriteLine("quel est la valeur ?");
                    compteur = int.Parse(Console.ReadLine());
                    SauvegarderCompteur(compteur);
                    check = false;
                    Console.Clear();
                }
                else if (change == "n")
                {
                    Console.WriteLine("pas de changements. reprise du comptage");
                    Thread.Sleep(1000);
                    Console.Clear();
                    check = false;
                }
                else if (change == "stop")
                {
                    input = change;
                    break;
                }
                else if (change != "y" || change != "n")
                {
                    check = true;
                }
            }



            if (input != "stop")
            {
                while (continuer)
                {
                    Console.WriteLine("'stop' pour quitter");
                    input = Console.ReadLine();
                    Console.Clear();

                    if (input == "stop")
                    {
                        continuer = false;
                    }
                    else if (input == "")
                    {
                        compteur++;
                        Console.WriteLine("Le compteur est à : " + compteur);
                        SauvegarderCompteur(compteur); // Appel de la méthode pour sauvegarder le compteur dans un fichier
                    }
                }

                rapelle(compteur);
                Thread.Sleep(3000);
            }
        }

        static int LireCompteur()
        {
            string fichier = "compteur.txt";
            if (File.Exists(fichier))
            {
                string contenu = File.ReadAllText(fichier);
                if (int.TryParse(contenu, out int compteur))
                {
                    return compteur;
                }
            }
            return 0; // Valeur par défaut si le fichier n'existe pas ou ne contient pas une valeur valide
        }

        static void SauvegarderCompteur(int compteur)
        {
            string fichier = "compteur.txt";
            File.WriteAllText(fichier, compteur.ToString());
        }

        static void rapelle(int compteur)
        {
            Console.Write("N'oubliez pas de mettre ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(compteur);
            Console.ResetColor();
            Console.Write(" dans la calculatrice à la valeur '");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("M");
            Console.ResetColor();
            Console.Write("'.");
        }
    }
}