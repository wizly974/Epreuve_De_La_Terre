namespace Terre03.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || !int.TryParse(args[0], out int argument))
            {
                Console.WriteLine("Tu ne me la mettras pas a l'envers.");
                return;
            }

            if (argument % 2 == 0)
            {
                Console.WriteLine("Pair.");
            }
            else
                Console.WriteLine("Impair");
        }
    }
}