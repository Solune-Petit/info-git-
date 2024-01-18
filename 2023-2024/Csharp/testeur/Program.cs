namespace testeur
{
    internal class Program
    {
        //static void Main()
        //{
        //    int n;
        //    Console.Write("Enter the number of rows for the inverted triangle: ");
        //    if (int.TryParse(Console.ReadLine(), out n))
        //    {
        //        if (n < 1)
        //        {
        //            Console.WriteLine("Please enter a positive number.");
        //        }
        //        else
        //        {
        //            PrintInvertedTriangle(n);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //    }
        //}

        //static void PrintInvertedTriangle(int n)
        //{
        //    for (int i = 9; i >= 1; i--)
        //    {
        //        for (int j = 1; j <= 9 - i; j++)
        //        {
        //            Console.Write(" "); // Print leading spaces
        //        }
        //        for (int j = 1; j <= 2 * i - 1; j++)
        //        {
        //            Console.Write(i); // Print stars
        //        }
        //        Console.WriteLine(); // Move to the next line
        //    }
        //}

        //public static bool isEven(int n)
        //{
        //    return (n % 2 == 0);
        //}

        //// Driver code 
        //public static void Main()
        //{
        //    int n = 101;
        //    Console.WriteLine("nombre");
        //    n = int.Parse(Console.ReadLine());


        //if (isEven(n) == true)
        //    {
        //        Console.WriteLine("Even");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Odd");
        //    }
        //}

        public static void Main()
        {
            for (int i = 0; i < 8; i++)
            {
                int[] table1[i] = int.Parse(Console.ReadLine());
                if (table1[i] == (table1[i] >> 1) << 1)
                {
                    Console.WriteLine("paire");
                }
                else
                {
                    Console.WriteLine("impaire");
                }
            }
        }
    }
}