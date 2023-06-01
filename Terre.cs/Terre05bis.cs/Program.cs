namespace Terre05bis.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inverser une chaîne à partir d'une invite de commande utilisateur.
            Console.Write("Enter double quote (\"\") around sentence: ");
            var input = Console.ReadLine();

            if (input == null || !input.StartsWith("\"") || !input.EndsWith("\"") || input.Length < 3)
            {
                Console.WriteLine("Error");
                return;
            }
            else
            {
                var sentence = input.Substring(1, input.Length - 2);

                if (string.IsNullOrWhiteSpace(sentence))
                {
                    Console.WriteLine("Error.");
                }
                else
                {
                    var array = new char[sentence.Length];
                    for (int i = array.Length; i > 0; i--)
                    {
                        array[sentence.Length - i] = sentence[i - 1];
                    }
                    var reversedsentence = new string(array);
                    Console.WriteLine(reversedsentence);
                }
            }
        }
    }
}
