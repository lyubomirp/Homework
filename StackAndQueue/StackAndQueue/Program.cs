using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> newstack = new Stack<int>();

            int[] n = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            foreach(var num in n)
            {
                newstack.Push(num);
            }

            foreach(var element in newstack)
            {
                Console.WriteLine(element); 
            }
        }
    }
}
