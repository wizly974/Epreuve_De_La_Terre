namespace Terre11.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var format12 = args[0].Split(':');
            const int MidNight = 0;
            const int MidDay = 12;
            const int MaxHour = 23;
            const int MaxMinute = 59;
            if (format12.Length != 2 || !int.TryParse(format12[0], out var hours) || !int.TryParse(format12[1], out var minutes) || hours >= MaxHour || hours < 0|| minutes > MaxMinute || minutes < 0)
            {
                Console.WriteLine("Error");
                return;
            }
            else if (hours == MidNight|| hours == MidDay || hours > MidDay)
            {
                if (hours == MidNight && minutes == 0)
                {
                    Console.WriteLine("{0:D2}:{1:D2}AM", hours, minutes);
                }
                else if (hours == MidNight && minutes <= MaxMinute)
                {
                    Console.WriteLine("{0:D2}:{1}AM", hours, minutes);
                }
                else if (hours == MidDay && minutes == 0)
                {
                    Console.WriteLine("{0}:{1:D2}PM", hours, minutes);
                }
                else if (hours == MidDay && minutes <= MaxMinute)
                {
                    Console.WriteLine("{0}:{1}PM", hours, minutes);
                }
                else
                {
                    hours -= 12;
                    Console.WriteLine("{0}:{1}PM", hours, minutes);
                }
            }
            else
            {
                Console.WriteLine("{0}:{1}AM", hours, minutes);
            }
        }
    }
}