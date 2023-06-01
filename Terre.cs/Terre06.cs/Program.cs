namespace Terre06.cs
{
    internal class Program
    {
        public static bool AllIsDigit(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            if (args.Length != 1 || AllIsDigit(args[0]))
            {
                Console.WriteLine("Error.");
                return;
            }
            else
            {
                Console.WriteLine(args[0].Length);
            }
        }
    }
}