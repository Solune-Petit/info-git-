using System.Diagnostics.Contracts;

namespace dettermineLeTarifAssurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("programme pour détermier un contract d'assurance ");

            double age;
            double obtenuPermis;
            double nbAccident;
            double anneeAnciennete;
            string contrat = null;
            string message;
            string reccommancer;


            do
            {
                Console.WriteLine("quel est votre âge ?");
                age = double.Parse(Console.ReadLine());
                Console.WriteLine("depuis combien de temps avez-vous votre permis ?");
                obtenuPermis = double.Parse(Console.ReadLine());
                Console.WriteLine("combiens d'accidents avez-vous eu ???");
                nbAccident = double.Parse(Console.ReadLine());
                Console.WriteLine("depuis combiens de temps êtes vous dans la compagnie ???");
                anneeAnciennete = double.Parse(Console.ReadLine());

                Determine(age, obtenuPermis, nbAccident, anneeAnciennete, out contrat);

                message = "vous avez le contrat " + contrat;
                Console.WriteLine(message);
                Console.WriteLine("voulez-vous recommancer ??? (T = oui / F = non");
                reccommancer = Console.ReadLine();


            } while (reccommancer == "T");

        }

        public static void Determine(double age, double obtenuPermis, double nbAccident, double anneeAnciennete, out string contrat) 
        { 
            
            if ((age < 25) && (obtenuPermis < 2))
            {

                if (nbAccident == 0)
                {
                    contrat = "rouge";
                }
                else
                {
                    contrat = "reffusé";
                }
            }
            if (((age < 25) && (obtenuPermis > 2)) || ((age <= 25) && (obtenuPermis < 2)))
            {
                if (nbAccident == 0)
                {
                    contrat = "orange";
                }
                else if (nbAccident == 1)
                {
                    contrat = "rouge";
                }
                else
                {
                    contrat = "reffusé";
                }
            }
            else
            {
                if (nbAccident == 0)
                {
                    contrat = "vert";
                }
                else if (nbAccident == 1)
                {
                    contrat = "orange";
                }
                else if (nbAccident == 2)
                {
                    contrat = "Rouge";
                }
                else
                {
                    contrat = "reffusé";
                }
            }
        }
    }
}