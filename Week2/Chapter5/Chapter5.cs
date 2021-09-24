using System;

namespace Chapter5
{

    

    class Chapter5
    {

        public static void Number_Two()
        {
            Console.WriteLine("Enter Number 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 3:");
            int c = int.Parse(Console.ReadLine());
            
            if (a == 0 || b == 0 || c == 0) 
            {
                Console.WriteLine("The product is 0");
                return;
            }
            
            if ( a > 0)
            {
                if (b < 0 && c > 0 || b > 0 && c < 0)
                {
                    Console.WriteLine("The product will be negative");
                }
                else if (b < 0 && c < 0)
                {
                    Console.WriteLine("The product will be positive");
                }
                
                else if (b > 0 && b > 0)
                {
                    Console.WriteLine("The product will be positive");
                }
            }

            if (a < 0)
            {
                if (b < 0 && c > 0 || b > 0 && c < 0)
                {
                    Console.WriteLine("The product will be positive");
                }
                else if (b < 0 && c < 0)
                {
                    Console.WriteLine("The product will be negative");
                }
                else if (b > 0 && c > 0)
                {
                    Console.WriteLine("The product will be negative");
                }
            }
            return;
        }

        public static void Number_Five()
        {
            Console.WriteLine("\nEnter a single digit as a number");
            int dig = int.Parse(Console.ReadLine());

            switch(dig)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Not a valid input");
                    break;
            }
            return;
        }

        public static void Number_Eight()
        {
            Console.WriteLine("\nEnter a selection: 1 for Int 2 for Double 3 for String");
            int select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Enter an Int");
                    int inputInt = int.Parse(Console.ReadLine());
                    inputInt++;
                    Console.WriteLine(inputInt);
                    break;

                case 2:
                    Console.WriteLine("Enter a Double");
                    double inputDbl = double.Parse(Console.ReadLine());
                    inputDbl++;
                    Console.WriteLine(inputDbl);
                    break;
                case 3:
                    Console.WriteLine("Enter a String");
                    string inputString = Console.ReadLine();
                    inputString += "*";
                    Console.WriteLine(inputString);
                    break;
            }


        }

        static void Main(string[] args)
        {
            Number_Two();
            Number_Five();
            Number_Eight();
        }
    }
}
