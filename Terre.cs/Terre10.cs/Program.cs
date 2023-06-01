namespace Terre10.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1 || !double.TryParse(args[0], out var number) || number <= 1)
            {
                Console.WriteLine("Error");
            }
            else
            {
                var aproximatevalue = number / 2;
                for (var i = number; i != 0; i--)
                {
                    aproximatevalue = (aproximatevalue + (number / aproximatevalue)) / 2;
                }
                var squareroot = aproximatevalue;
                var prime = true;
                for (var i = 2; i <= squareroot; i++)
                {
                    if (number % 2 == 0)
                    {
                        prime = false;
                        break;
                    }
                    prime = true;
                }
                if (prime == false)
                {
                    Console.WriteLine("No, {0} is not a prime number.", number);
                }
                else
                {
                    Console.WriteLine("Yes, {0} is a prime number", number);
                }
            }
        }
    }
}