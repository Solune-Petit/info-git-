//commentaires
// jaune ||  _bleu  || rouge, vert, mauve, gris
//   1   ||    2    ||  3     4      5     6
//possibillité de faire en sorte que quand l'utillisateur entre une couleur, elle se change en cette couleur sur la console
//vérification des entrées
//entrées multiples pour entrer dans un var

using System.Threading;

namespace _5TTI_Solune_P_Mathias_S_mastermind
{
internal class Program
{
    static void Main(string[] args)
    {

        //int test = rnd.Next(0, 5);

        //while (test != 0)
        //{
        //test = rnd.Next(0, 5);
        //Console.WriteLine(test);
        //}

        //string test = "3152";

        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.WriteLine(test[0]);
        //Console.ForegroundColor= ConsoleColor.Green;
        //Console.Write(test[1]);
        //Console.ForegroundColor=ConsoleColor.Yellow;
        //Console.Write(test[2]);
        //Console.ForegroundColor = ConsoleColor.Red;
        //Console.Write(test[3]);

        string restart = "y";
        while (restart != "n")
        {
            Random rnd = new Random();
            ConsoleKeyInfo keyInfo;
            string[] Uinput;
            string[] combination;
            int difficulty = 0;
            int[] nbrcolors = new int[6];
            int nbrYellow = 0;
            int nbrGreen = 0;
            int nbrBlue = 0;
            int nbrRed = 0;
            int nbrGrey = 0;
            int nbrMagenta = 0;



            while (difficulty != 1 && difficulty != 2 && difficulty != 3)
            {
                Console.WriteLine("Quelle difficulté voulez-vous choisir ?\n1 pour quatre pions | 2 pour cinq pions | 3 pour six pions");
                string input = Console.ReadLine();
                int.TryParse(input, out difficulty);
            }

            difficulty += 3;

            combination = new string[difficulty];
            Uinput = new string[difficulty];

            for (int i = 0; i < difficulty; i++)
            {
                int tempInt = rnd.Next(0, 5);
                combination[i] = tempInt.ToString();
            }

            countColor(combination, ref nbrcolors);

            Console.Clear();
            string tester = "";
            Console.ForegroundColor = ConsoleColor.White;
            for (int j = 0; j < combination.Length; j++)
            {
                tester += combination[j].ToString();
            }
            Console.WriteLine(tester);
            Console.ReadKey();
            //loading();


            for (int i = 0; i < difficulty; i++)
            {
                string tempOut = "";
                Console.WriteLine("devine la combinaison");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("   1   ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("   2   ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("   3   ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("   4   ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("   5   ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("   6\n\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                for (int j = 0; j < Uinput.Length; j++)
                {
                    tempOut += Uinput[j];
                }
                Console.WriteLine(tempOut);
                keyInfo = Console.ReadKey();
                Console.Write("   ");
                Uinput[i] = keyInfo.KeyChar.ToString();
                Console.Write("   ");
                Console.Clear();
            }

            Console.WriteLine("press any key to proceed");
            Console.ReadKey();
            Console.Clear();

            checker(combination, Uinput, nbrcolors);

            Console.WriteLine("restart ?");
            restart = Console.ReadLine();
        }
    }

    static void countColor(string[] combination, ref int[] nbrcolors)
    {
        string tempj;
        nbrcolors = new int[6];
        for (int i = 0; i < combination.Length; i++)
        {
            for (int j = 0; j < combination.Length + 1; j++)
            {
                tempj = j.ToString();
                if (combination[i] == tempj)
                    {
                        nbrcolors[j] ++;
                    }
            }
        }
    }

        static void checker(string[] combination, string[] Uinput, int[] nbrcolors)
        {
            string tempOut = "";
            for (int i = 0; i < combination.Length; i++)
            {
                int nbrPosI = int.Parse(Uinput[i]);
                if (Uinput[i] == combination[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    tempOut = Uinput[i];
                    Console.Write(tempOut);
                    Console.ForegroundColor = ConsoleColor.White;
                    int nbrColorsUinput;
                }
                else
                {
                    for (int j = 0; j < Uinput.Length; j++)
                    {
                        if (Uinput[i] == combination[j])
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            tempOut = Uinput[i];
                            Console.Write(tempOut);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    tempOut = Uinput[i];
                    Console.Write(tempOut);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            static void countColor(string[] combination, ref int[] nbrColors)
            {
                for (int i = 0; i < combination.Length; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {

                    }
                }
            }

            static void loading()
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("loading");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("|");
                Thread.Sleep(10);
                Console.Write("|");
                Thread.Sleep(25);
                Console.Write("|");
                Thread.Sleep(50);
                Console.Write("|");
                Thread.Sleep(100);
                Console.Write("|");
                Thread.Sleep(100);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("|");
                Thread.Sleep(200);
                Console.Write("|");
                Thread.Sleep(300);
                Console.Write("|");
                Thread.Sleep(400);
                Console.Write("|");
                Thread.Sleep(500);
                Console.Write("|");
                Thread.Sleep(600);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("|");
                Thread.Sleep(700);
                Console.Write("|");
                Thread.Sleep(800);
                Console.Write("|");
                Thread.Sleep(900);
                Console.Write("|");
                Thread.Sleep(1000);
                Console.WriteLine("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("100% done \npress any key to proceed");
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }
    }
}