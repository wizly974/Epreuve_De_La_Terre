namespace Terre08.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2 || !int.TryParse(args[0], out var theBase) || !int.TryParse(args[1], out var exponent))
            {
                Console.WriteLine("Error: Arguments not available.");
            }
            else
            {
                var powerOfNumber = 1;
                for (var i = 1; i <= exponent; i++)
                {
                    powerOfNumber*= theBase;
                }
                Console.WriteLine(powerOfNumber);
            }
        }
    }
}