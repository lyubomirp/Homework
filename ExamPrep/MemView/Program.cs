using System;
using System.Collections.Generic;
using System.Linq;

namespace MemView
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<string> result = new List<string>();

            while (input != "Visual Studio crash")
            {
                string[] brokenInput = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Where(x => x != "0" && x.Length < 5)
                    .ToArray();

                foreach(var item in brokenInput)
                {
                    result.Add(item);
                }

                input = Console.ReadLine();
            }



            for (int i = 0; i < result.Count; i+=0)
            {
                string result2 = string.Empty;

                for (int j = 1; j <= int.Parse(result[i]); j++)
                {
                    result2 += (char)int.Parse(result[i+j]);
                }

                i += int.Parse(result[i])+1;

                Console.WriteLine(result2);
            }

        }
    }
}
