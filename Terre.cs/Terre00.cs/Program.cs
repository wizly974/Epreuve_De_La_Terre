using System;


namespace Terre00.cs
{
    internal class Program
    {
    static void Main(string[] args)
    {
        char alphabet;
        for (var i = 97; i <= 122; i++) 
        {
            alphabet = Convert.ToChar(i);
            Console.Write(alphabet);
        }
    }
    }
}