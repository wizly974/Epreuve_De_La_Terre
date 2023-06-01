namespace Terre07.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2 || !int.TryParse(args[0], out var theBase) || !int.TryParse(args[1], out var exponent) || Math.Sign(exponent) < 0)
            {
                Console.WriteLine("Error.");
                return;
            }
            else
            {
                Console.WriteLine(Math.Pow(theBase, exponent));
            }
        }
    }
}