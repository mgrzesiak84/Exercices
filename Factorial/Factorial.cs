using System;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Type an integer number: ");
            var resultParsed = int.TryParse(Console.ReadLine(), out n);

            var result = FactorialLoop(n);
            var result2 = FactorialRecursion(n);

            Console.WriteLine("Factorial of the number {0} is equal: {1} - loop", n, result);
            Console.WriteLine("Factorial of the number {0} is equal: {1} - recursion", n, result2);

            Console.ReadLine();
        }

        private static int FactorialLoop(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result = result * i;
            }

            return result;
        }

        private static int FactorialRecursion(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * FactorialRecursion(n - 1);
        }
    }
}
