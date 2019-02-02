using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotationIndex = int.Parse(Console.ReadLine());

            RotateRight(input, rotationIndex);
        }


        static void RotateRight(int[] inputNums, int rotations)
        {
            int[] sumArray = new int[inputNums.Length];
            int[] rotatedArray = new int[inputNums.Length];
            int numLast = 0;

            for (int i = 0; i < rotations; i++)
            {

                for (int k = 0; k < inputNums.Length; k++)
                {
                    numLast = inputNums[inputNums.Length - 1];
                    for (int j = 0; j < inputNums.Length-1; j++)
                    {
                        rotatedArray[j + 1] = inputNums[j];
                    }
                    rotatedArray[0] = numLast;

                    sumArray[k] += rotatedArray[k];
                    
                }
                inputNums = (int[])rotatedArray.Clone();
            }
            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.Write($"{sumArray[i]} ");
            }
        }
    }
}
