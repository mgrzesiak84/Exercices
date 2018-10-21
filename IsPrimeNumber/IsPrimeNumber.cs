using System;

namespace IsPrimeNumber
{
    class IsPrimeNumber
    {
        static void Main(string[] args)
        {

            Console.Write("Enter an integer number : ");

            string consoleString = Console.ReadLine();

            int number = 0;

            bool result = int.TryParse(consoleString, out number);

            number = number < 0 ? Math.Abs(number) : number;

            if (result)
            {
                int numberOfDivides = 0;
                if (number == 0)
                {
                    return;
                }

                for (int i = 2; i < number; i++)
                {
                    int divide = number % i;

                    if (divide == 0)
                    {
                        Console.WriteLine("Divides by : " + i);
                        numberOfDivides++;
                    }
                }
                Console.WriteLine(numberOfDivides > 0 ? "Is not a Prime" : "Is a Prime");
            }

            else
            {
                Console.WriteLine("It is not an integer number.");
            }

            Console.Read();
        }
    }
}
