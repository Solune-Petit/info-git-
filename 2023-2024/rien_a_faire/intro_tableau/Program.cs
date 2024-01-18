namespace intro_tableau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] t = new int[8];
            string mess = "";

            for (int i = 0; i < t.Length;  i++)
            {
                t[i] = i + 1;
                mess += t[i];
            }
            Console.WriteLine(mess);
        }
    }
}