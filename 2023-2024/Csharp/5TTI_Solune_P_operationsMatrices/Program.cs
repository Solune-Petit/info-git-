namespace _5TTI_Solune_P_operationsMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Uinput;
            int[,] matrice1 = null;
            int[,] matrice2 = null;
            int[,] matriceFinal = null;


            ColorChanger.yellow();
            Console.WriteLine("Bienvenu dans les opérations de mattrices ! \n Que voulez-vous faire ?");
            ColorChanger.cyan();
            do
            {
                Console.WriteLine("  • 1 : générer une matrice aléatoire (au choix de votre taille)\n  • 2 : additionner 2 matrices au choix\n  • 3 : multiplier 2 matrices aux choix\n  • 4 : concaténer 2 matrices au choix");
                ColorChanger.white();
                Uinput = Console.ReadKey().ToString();
            } while (Uinput != "1" || Uinput != "2" || Uinput != "3" || Uinput!= "4");

            //do
            //{
            //    ColorChanger.yellow();
            //    Console.WriteLine("Bienvenu dans les opérations de matrices ! \n veuillez confirmer votre choix");

            //    if (Uinput == "1")
            //    {

            //    }
            //} while (Uinput != "1" || Uinput != "2" || Uinput != "3" || Uinput != "4");

            if (Uinput == "1")
            {
                int M1Dim1;
                int M1Dim2;
                int M2Dim1;
                int M2Dim2;

                do
                {
                    Console.WriteLine("combiens de lignes voulez vous ? (entre 1 et 9 inclus)");
                    M1Dim1 = int.Parse(Console.ReadLine());
                } while (M1Dim1 <= 1 && M1Dim1 >= 10);

                do
                {
                    Console.WriteLine("combiens de lignes voulez vous ? (entre 1 et 9 inclus)");
                    M1Dim2 = int.Parse(Console.ReadLine());
                } while (M1Dim2 <= 1 && M1Dim2 >= 10);

                do
                {
                    Console.WriteLine("combiens de lignes voulez vous ? (entre 1 et 9 inclus)");
                    M2Dim1 = int.Parse(Console.ReadLine());
                } while (M2Dim1 <= 1 && M2Dim1 >= 10);

                do
                {
                    Console.WriteLine("combiens de lignes voulez vous ? (entre 1 et 9 inclus)");
                    M2Dim2 = int.Parse(Console.ReadLine());
                } while (M2Dim2 <= 1 && M2Dim2 >= 10);

                Functions.creationMatrices(matrice1, matrice2, M1Dim1, M1Dim2, M2Dim1, M2Dim2);
            
            
            }else if (Uinput == "2")
            {
                Functions.ConcatenerMatrices(matrice1, matrice2, matriceFinal);
            }
        }
    }
}
