namespace Terre09.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Racine carré
            if (args.Length != 1 || !double.TryParse(args[0], out double number)|| number < 0)
            {
                Console.WriteLine("Error: No argument available.");
            }
            else
            {
                var squareRoot = number / 2;
                // Fonction numérique utilisé f(x) = (x+(a/x))/2
                for (double i = number; i != 0; i--)
                {
                    squareRoot = (squareRoot + (number / squareRoot)) / 2;
                }
                Console.WriteLine(squareRoot);
            }
        }
    }
}