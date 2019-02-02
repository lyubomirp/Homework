using System;

namespace DataTypesFit
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            sbyte a = 0;
            byte b = 0;
            short c = 0;
            ushort d = 0;
            int e = 0;
            uint f = 0;
            long g = 0;

            string result = $"{input} can fit in: ";


            if (sbyte.TryParse(input, out a))
            {
                result += Environment.NewLine + "* sbyte";
            }
            if (byte.TryParse(input, out b))
            {
                result += Environment.NewLine + "* byte";
            }
            if (short.TryParse(input, out c))
            {
                result += Environment.NewLine + "* short";
            }
            if (ushort.TryParse(input, out d))
            {
                result += Environment.NewLine + "* ushort";
            }
            if (int.TryParse(input, out e))
            {
                result += Environment.NewLine + "* int";
            }
            if (uint.TryParse(input, out f))
            {
                result += Environment.NewLine + "* uint";
            }
            if (long.TryParse(input, out g))
            {
                result += Environment.NewLine + "* long";
            }

            if (result == $"{input} can fit in: ")
            {
                result = $"{input} can't fit in any type";
                Console.WriteLine(result);
            } else
            {
                Console.WriteLine(result);
            }
        }
    }
}
