using System;

namespace SumOfIntegers
{
    class SumOfIntegers
    {
        static void Main(string[] args)
        {
            int integer;

            Console.Write("Type some big integer number: ");

            var resultParsed = int.TryParse(Console.ReadLine(), out integer);

            int result = SumOfIntegerLoop(integer);
            int result2 = SumOfIntegerRecursion(integer);


            Console.WriteLine("Sum of the integers is {0} - loop ", result);
            Console.WriteLine("Sum of the integers is {0} - recursion", result2);


            Console.ReadLine();
        }

        private static int SumOfIntegerLoop(int n)
        {
            var sumOfInteger = 0;

            for (var i = n; i > 0; i--)
            {

                var restOfDivide = n % 10;
                sumOfInteger = sumOfInteger + restOfDivide;
                n = n / 10;

            }
            return sumOfInteger;
        }

        private static int SumOfIntegerRecursion(int n)
        {
            if (n / 10 == 0)
            {
                return n;
            }

            var sum = SumOfIntegerRecursion(n % 10) + SumOfIntegerRecursion(n / 10);
            return sum;
        }
    }
}
