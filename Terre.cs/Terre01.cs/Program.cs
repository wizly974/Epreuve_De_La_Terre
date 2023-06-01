using System.Reflection;

namespace Terre01.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nom du fichier
            var assembly = Assembly.GetExecutingAssembly().Location;
            var fileName = Path.GetFileNameWithoutExtension(assembly);
            Console.WriteLine(assembly);
            Console.WriteLine();
            Console.WriteLine(fileName);
            Console.WriteLine();
            // Nom du dossier
            var folderName = Assembly.GetExecutingAssembly().GetName().Name;
            Console.WriteLine(folderName);
            Console.WriteLine();
            Console.WriteLine(Path.GetFileNameWithoutExtension(fileName)); 
        }
    }
}

