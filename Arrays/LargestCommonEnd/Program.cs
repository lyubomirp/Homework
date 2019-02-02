using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine()
                .Split()
                .ToArray();
            string[] secondInput = Console.ReadLine()
                .Split()
                .ToArray();

            CommonEndCheck(firstInput, secondInput);

        }



        static void CommonEndCheck(string[] first, string[] second)
        {
            int leftToRight = 0;
            int rightToLeft = 0;
            for (int i = 0; i < Math.Min(first.Length, second.Length); i++)
            {
                if (first[leftToRight].SequenceEqual(second[leftToRight]) || first[leftToRight+i].SequenceEqual(second[leftToRight+i])){
                    leftToRight++;
                } else
                {
                    break;
                }
            }
            for (int j = 1; j < Math.Min(first.Length, second.Length); j++)
            {
                if (first[first.Length-1-rightToLeft].SequenceEqual(second[second.Length-1-rightToLeft]) || first[first.Length - 1 - j].SequenceEqual(second[second.Length - 1 - j]))
                {
                    rightToLeft++;
                } else
                {
                    break;
                }
            }
            leftToRight -= 1;
            rightToLeft -= 1;
            Console.WriteLine(leftToRight>rightToLeft? leftToRight : rightToLeft);
        }
    }
}
