using System;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            string[] thirdInput = Console.ReadLine().Split();

            Tuple<string, string,string> tuple = new Tuple<string,string,string>();
            Tuple<string, int, bool> tuple2 = new Tuple<string,int,bool>();
            Tuple<string, double, string> tuple3 = new Tuple<string,double,string>();

            tuple.FirstItem = firstInput[0]+" "+firstInput[1];
            tuple.SecondItem = firstInput[2];
            tuple.ThirdItem = firstInput[3];

            tuple2.FirstItem = secondInput[0];
            tuple2.SecondItem = int.Parse(secondInput[1]);
            switch (secondInput[2].ToLower())
            {
                case "drunk":
                    tuple2.ThirdItem = true;
                    break;
                case "not":
                    tuple2.ThirdItem = false;
                    break;
            }

            tuple3.FirstItem = thirdInput[0];
            tuple3.SecondItem = double.Parse(thirdInput[1]);
            tuple3.ThirdItem = thirdInput[2];

            Console.WriteLine(tuple.ToString());
            Console.WriteLine(tuple2.ToString());
            Console.WriteLine(tuple3.ToString());
        }
    }
}
