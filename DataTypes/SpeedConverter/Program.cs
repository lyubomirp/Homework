using System;

namespace SpeedConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float dist = float.Parse(Console.ReadLine());
            float hrs = float.Parse(Console.ReadLine());
            float min = float.Parse(Console.ReadLine());
            float sec = float.Parse(Console.ReadLine());

            float fullTime = (hrs * 3600.0f) + (min * 60.0f) + sec;

            float metersPS = dist / fullTime;
            float kmph =  metersPS*3.6f;
            float milesph = metersPS* 2.237414f;

            Console.WriteLine($"{metersPS:G7}");
            Console.WriteLine($"{kmph:G7}");
            Console.WriteLine($"{milesph:G7}");
        }
    }
}
