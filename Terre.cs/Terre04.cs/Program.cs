namespace Terre04.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2 || !int.TryParse(args[0], out var numerator) || !int.TryParse(args[1], out var denominator) || denominator == 0 || numerator < denominator)
            {
                Console.WriteLine("Error.");
                return;
            }
            var result = numerator / denominator;
            var rest = numerator % denominator;

            Console.WriteLine("Result: {0} ", result);
            Console.WriteLine("Rest: {0} ", rest);
        }
    }
}