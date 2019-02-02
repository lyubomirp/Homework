using System;

namespace TheaThePhotog
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong picturesTaken = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            ulong percentGood = ulong.Parse(Console.ReadLine());
            ulong uploadTime = ulong.Parse(Console.ReadLine());

            double percentage = (double)percentGood / 100;
            double goodPictures = Math.Ceiling(picturesTaken * percentage);
            ulong timeForUpload = uploadTime * (ulong)goodPictures;
            ulong timeForFilter = picturesTaken * filterTime;
            ulong seconds = timeForUpload + timeForFilter;
            ulong totalMinutes = seconds / 60;
            ulong secondsLeft = seconds % 60;
            ulong totalHours = totalMinutes / 60;
            ulong minutesLeft = totalMinutes % 60;
            ulong hoursLeft = totalHours % 24;
            ulong days = totalHours / 24;

            Console.WriteLine($"{days}:{hoursLeft:d2}:{minutesLeft:d2}:{secondsLeft:d2}");
        }
    }
}
