namespace calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pour se faire plez \n ------------------------------------------------------------------------------------------------------------");

            string calcul = null;
            int nbrNbrs;
            double[] tableNbrs;

            Console.WriteLine("quel est le type de calcule que vous voulez faire (multiplier) ???");
            calcul = Console.ReadLine();
            Console.WriteLine("combiens de nombres voulez-vous dans votre calcul ?");
            nbrNbrs = int.Parse(Console.ReadLine());
            tableNbrs = new double[nbrNbrs];

            if (calcul == "multiplier")
            {
                for (int i = 0; i == nbrNbrs; i++)
                {
                    Console.WriteLine("quel est le nombre " + i + " ?");
                    tableNbrs[i] = double.Parse(Console.ReadLine());
                }
                multiplier(tableNbrs, out string message);
            }
        }

        static void multiplier(double[] tableNbrs, out string message)
        {
            double result =  * nbr2;
            message = "la réponse de "+ nbr1 + " * " + nbr2 + " est égale à " + result.ToString();
        }
    }
}