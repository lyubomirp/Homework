using System;

namespace AdvertismentMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string[] people = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };



            var rnd = new Random();

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"{phrases[rnd.Next(0, phrases.Length - 1)]} {events[rnd.Next(0, events.Length - 1)]}. {people[rnd.Next(0, people.Length - 1)]} – {cities[rnd.Next(0, cities.Length - 1)]}");
            }
            
        }
    }
}
