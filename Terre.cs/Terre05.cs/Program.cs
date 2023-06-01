namespace Terre05.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inverser une chaîne à partir d'argument passé en ligne de commande. 
            if (args.Length != 1)
            {
                Console.WriteLine("Error");
                return;
            }
            else
            {
                var argument = new char[args[0].Length];
                for (int i = argument.Length; i > 0; i--)
                {
                    argument[args[0].Length - i] = args[0][i - 1];
                }
                Console.WriteLine(argument);
            }
        }
    }
}