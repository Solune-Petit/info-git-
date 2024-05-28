namespace _5TTI_Petit_S_ExerciePreparatoireExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fonctions mesOutils = new fonctions();

            string cle;
            string msg;

            Console.WriteLine("cryptage par (jsp le nom)\n\n\n\n\nquel est votre clé ?");
            cle = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("quel est votre message ?");
            msg = Console.ReadLine();
            Console.Clear();

            string message_final = mesOutils.control(msg, cle);
            Console.WriteLine(message_final);
            Console.ReadKey();
        }
    }
}
