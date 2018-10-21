using System;

namespace TheBiggestDivider
{
    public class TheBiggestDivider
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer number: ");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer number: ");
            var secondNumber = int.Parse(Console.ReadLine());

            int divider = FindBiggestDivider(firstNumber, secondNumber);
            Console.WriteLine("The biggest divider of {0} and {1} is {2}", firstNumber, secondNumber, divider);
            Wait();
        }

        private static void Wait()
        {
            Console.ReadLine();
        }

        private static int FindBiggestDivider(int a, int b)
        {
            var min = GetMinimumValue(a, b);

            for (int i = min; i >= 1; i--)
            {
                if (IsDivadibleBy(a, i) && IsDivadibleBy(b, i))
                {
                    return i;
                }
            }

            return 1;
        }

        private static bool IsDivadibleBy(int number, int divider)
        {
            return number % divider == 0;
        }

        private static int GetMinimumValue(int x, int y)
        {
            return x < y ? x : y;
        }
    }
}
