namespace detecteur_de_touches
{
    internal class Program
    {
        public class Example
        {
            public static void Main()
            {

                while (true)
                {

                    if (Console.ReadKey().Key != ConsoleKey.Q)
                    {
                        Console.Clear();
                        Console.WriteLine("Q pressé");
                    }
                    else if (Console.ReadKey().Key != ConsoleKey.Z)
                    {
                        Console.Clear();
                        Console.WriteLine("Z press");
                    }
                }
            }
        }
    }
}