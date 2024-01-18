namespace concatenation_carre_etoiles_et_condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taille;
            string result;
            
            Console.WriteLine("Hello, World!");

            Thread.Sleep(1000);

            
            Console.WriteLine("carré de combien ?");
            taille = int.Parse(Console.ReadLine());
            Console.Clear();

            //carré simple
            etoiles(taille, out result);
            Console.WriteLine(result);

            //carré avec diagonale de sens "\"
            diagonaleDroiteGauche(taille, out result);
            Console.WriteLine(result);

            //carré avec diagonale de sens "/"
            diagonaleGaucheDroite(taille, out result);
            Console.WriteLine(result);

            //carré avec pyramide grace à chatGPT
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("version ChatGPT");
            Console.ForegroundColor= ConsoleColor.White;
            
            pyramideChatGPT(taille, out result);
            Console.WriteLine(result);

            //carré avec pyramide version prof
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("version prof");
            Console.ForegroundColor= ConsoleColor.White;

            pyramideProf(taille, out result);
            Console.WriteLine(result);
            

        }

        static void etoiles(int taille, out string result)
        {
            result = "";
            for (int l = 1; l < (taille + 1); l++)
            {
                for (int c = 1; c < (taille + 1); c++)
                {
                    result += "*";
                }
                result += "\n";
            }
        }

        static void diagonaleDroiteGauche(int taille, out string result)
        {
            result = "";
            for (int l = 1; l < (taille + 1); l++)
            {
                for (int c = 1; c < (taille + 1); c++)
                {
                    if (l == c)
                    {
                        result += "0";
                    }
                    else
                    {
                        result += "*";
                    }
                }
                result += "\n";
            }
        }

        static void diagonaleGaucheDroite(int taille, out string result)
        {
            result = "";
            for (int l = 1; l < (taille + 1); l++)
            {
                for (int c = 1; c < (taille + 1); c++)
                {
                    if (c == taille - (l - 1))
                    {
                        result += "0";
                    }
                    else
                    {
                        result += "*";
                    }
                }
                result += "\n";
            }
        }
        static void pyramideChatGPT(int taille, out string result)
        {
            result = "";
            for (int l = 0; l < taille; l++)
            {
                for (int c = 0; c < taille - l - 1; c++)
                {
                    result += "*"; // Print leading spaces
                }
                for (int c = 0; c < 2 * l + 1; c++)
                {
                    result += "0"; // Print stars
                }
                for (int c = 0; c < taille - l - 1; c++)
                {
                    result += "*"; // Print trailing spaces on the right side
                }
                result += "\n"; // Move to the next line
            }
        }

        static void pyramideProf(int taille, out string result)
        {
            result = "";
            for (int l = 1; l < (taille + 1); l++)
            {
                for (int c = 1; c < ((taille * 2) + 1); c++)
                {
                    if (c >= taille - (l - 1) || c <= taille + (l - 1))
                    {
                        result += "0";
                    }
                    else
                    {
                        result += "*";
                    }
                }
                result += "\n";
            }
        }
    }
}