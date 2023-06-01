namespace Terre13.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3 || !int.TryParse(args[0],out var number1) || !int.TryParse(args[1], out var number2)|| !int.TryParse(args[2],out var number3)) 
            {
                Console.WriteLine("Error.");
            }
            else
            {
                if ((number1 > number2 && number1 < number3) || number1 < number2 && number1 > number3)
                {
                    Console.WriteLine(number1);
                }
                else if ((number2 > number1 && number2 < number3) || number2 < number1 && number2 > number3)
                {
                    Console.WriteLine(number2);
                }
                else if ((number3 > number1 && number3 < number2) || number3 < number1 && number3 > number2)
                {
                    Console.WriteLine(number3);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
        }
    }
}