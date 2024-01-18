namespace _5TTI_Petit_S_resolutionTrinomeSecondDegre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;
            double delta;
            double rep1;
            double rep2;
            string message = "";

            Console.WriteLine("quel est le premier nombre ??");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("quel est le deuxième nombre ??");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("quel est le troisième nombre ??");
            c = double.Parse(Console.ReadLine());

            delta = Math.Sqrt(b) - 4 * a * c;

            if (delta < 0)
            {
                message = "il n'y as pas de racines";
            }else if (delta == 0)
            {
                rep1 = -b / (2 * a);
                message = "la solution est" + rep1;
            } else if (delta > 0)
            {
                rep1 = (-b + delta) / (2 * a);
                rep2 = (-b - delta) / (2 * a);
                message = "les solutions sont " + rep1 + ";" + rep2;
            }
            
            Console.WriteLine(message);
        }   
    }
}