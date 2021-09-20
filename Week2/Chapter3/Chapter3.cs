using System;

namespace Chapter3
{
    class Chapter3
    {
        static void Main(string[] args)
        {
            //#3
            int num;
            Console.WriteLine("Enter a number");
            num = Int32.Parse(Console.ReadLine());

            num /= 100;
            num %= 10;
            if (num == 7)
             {

                Console.WriteLine("The third digit is 7!");

            }
            else
            {
                Console.WriteLine("The third digit is not 7...");
            }

            //#7
            double weight;

            Console.WriteLine("Enter a weight in lbs");
            weight = double.Parse(Console.ReadLine());

            weight *= 0.17;
            Console.WriteLine("The weight on the moon would be {0} lbs", weight);


        }
    }
}
