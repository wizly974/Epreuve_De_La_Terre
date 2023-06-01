namespace Terre03.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length == 0) 
            {
                Console.WriteLine("Error no argument provided");
            }
            var character = (int)(args[0][0]);
            for (var i = character;i <= 122;i++)
            {
                var alphabetFromCharacter = (char)(i);
                Console.Write(alphabetFromCharacter);
            }
        }
    }
}