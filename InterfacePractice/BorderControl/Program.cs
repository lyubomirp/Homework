using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    class Program
    {
        static List<IBuyable> identifiabls;

        static void Main(string[] args)
        {
            identifiabls = new List<IBuyable>();
            int count = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < count; i++)
            {
                string[] inputData = Console.ReadLine()
                .Split();
                FeedInput(inputData);
            }

            string buyer = Console.ReadLine();

            while(buyer != "End")
            {
                IBuyable tuBuy = identifiabls.Find(x => x.Name == buyer);
                if (tuBuy != null)
                {
                    tuBuy.BuyFood();
                }
               buyer = Console.ReadLine();
            }

            Console.WriteLine(identifiabls.Sum(x=>x.GetFood));
        }



        private static void FeedInput(string[] inputData)
        {
            switch (inputData.Length)
            {
                case 3:
                    Rebel rebel = new Rebel(inputData[0], int.Parse(inputData[1]), inputData[2]);
                    identifiabls.Add(rebel);
                    break;
                case 4:
                    Citizen citizen = new Citizen(inputData[0], int.Parse(inputData[1]), inputData[2], inputData[3]);
                    identifiabls.Add(citizen);
                    break;
                default:
                    break;
            }
        }
    }
}
