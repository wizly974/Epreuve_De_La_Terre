namespace Terre04bis.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numerator: ");
            var input1 = Console.ReadLine();
            Console.Write("Enter a denominator: ");
            var input2 = Console.ReadLine();

            if (!int.TryParse(input1, out var numerator) || !int.TryParse(input2, out var denominator) || denominator == 0 || numerator < denominator)
            {
                Console.WriteLine("Erreur");
                return;
            }
            else
            {
                var result = numerator / denominator;
                var rest = numerator % denominator;
                Console.WriteLine("Resultat: {0}", result);
                Console.WriteLine("Reste: {0}", rest);
            }
        }
    }
}