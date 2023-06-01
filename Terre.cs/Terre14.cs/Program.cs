using System.Collections.Generic;
using System.Xml.Linq;

namespace Terre14.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Error");
                return;
            }
            var numbers = new List<int>();
                foreach (var arg in args)
                {
                    if (!int.TryParse(arg, out var number))
                    {
                        Console.WriteLine("Error");
                        return;
                    }
                    numbers.Add(number);
                }
                for (var i = 0; i < numbers.Count - 1; i++)
                {
                    var element = numbers[i + 1];
                    if (numbers[i] > element)
                    {
                        Console.WriteLine("Not sort");
                        return;
                    }
                }
                        Console.WriteLine("Sort");
        }
    }
}