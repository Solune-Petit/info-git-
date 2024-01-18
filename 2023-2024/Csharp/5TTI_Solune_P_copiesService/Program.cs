using System.Reflection.Metadata;

namespace _5TTI_Solune_P_copiesService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nbrCopies;    // contient le nombre de photocopies demandé
            double prix10 = 0.1; // contient le prix pour 10 photocopies
            double prix20 = 0.09;// contient le prix pour 20 photocopies
            double prix30 = 0.08;// contient le prix pour 30 photocopies
            double cout;         // contient ce que vas coûter les photocopies
            string message = ""; // contient le message
            string recommancer = "true";

            while (recommancer == "true")
            {

                Console.WriteLine("combiens de photo copies voulez vous ?");
                nbrCopies = double.Parse(Console.ReadLine());

                if (nbrCopies <= 10)
                {
                    cout = nbrCopies * prix10;
                } else if (nbrCopies <= 20)
                {
                    cout = prix10 * 10;
                    cout = cout + (nbrCopies - 10) * prix20;
                }
                else
                {
                    cout = prix10 * 10 + prix20 * 10;
                    cout = cout + (nbrCopies - 20) * prix30;
                }

                message = "pour " + nbrCopies + " vas vous coûter " + cout + " €";

                Console.WriteLine(message);
                Console.WriteLine("voulez vous recommancer true/false ?");
                Console.ReadLine(recommancer);
            }
        }
    }
}