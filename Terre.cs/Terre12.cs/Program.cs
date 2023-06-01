namespace Terre12.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var format24 = args[0].Split(':');
            if (format24.Length != 2 || !int.TryParse(format24[0],out var hours) || !int.TryParse(format24[1].Substring(0,2),out var minutes) || hours < 0 || hours > 12 || minutes < 0 || minutes >= 60)
            {
                Console.WriteLine("Error: Please provide a time in 12h format as an argument.");
            }
            else
            {
                var amPm = format24[1].Substring(2);
                if (amPm == "AM")
                {
                    if (hours == 12)
                    {
                        hours = 0;
                    }
                }
                else if (amPm == "PM")
                {
                    if (hours != 12)
                    {
                        hours += 12;
                    }
                }
                else
                {
                    Console.WriteLine("Error: Incorrect time format.");
                }
                Console.WriteLine($"{hours.ToString("00")}:{minutes.ToString("00")}");
            }
        }
    }
}
