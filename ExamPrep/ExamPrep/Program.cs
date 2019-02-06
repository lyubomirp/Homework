using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            GetUserInput();
        }




        static void GetUserInput()
        {
            int gamesLost = int.Parse(Console.ReadLine());

            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            CalculateRageExpenses(gamesLost, headsetPrice, mousePrice, keyboardPrice, displayPrice);
        }



        static void CalculateRageExpenses(int games, double headset, double mouse, double keyboard, double display)
        {
            double expenses = 0.0;
            int keyboardCount = 0;
            for (int i = 1; i <= games; i++)
            {
                if (i % 2 == 0)
                {
                    expenses += headset;
                }
                if (i % 3 == 0)
                {
                    expenses += mouse;
                }
                if (i % 3 == 0 && i%2==0)
                {
                    keyboardCount++;
                    expenses += keyboard;
                    if (keyboardCount >= 2)
                    {
                        expenses += display;
                        keyboardCount = 0;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
