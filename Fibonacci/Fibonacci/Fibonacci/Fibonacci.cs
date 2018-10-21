using System;

namespace Fibonacci
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            int number;

            Console.Write("Which Fibonacci number you want to obtain : ");

            var result = int.TryParse(Console.ReadLine(), out number);

            Console.WriteLine("The {0} Fibonacci number is: {1}" , number, Fibb(number));
            Console.ReadLine();

        }

        protected static int Fibb(int index)
        {
            if (index <= 2)
            {
                return 1;
            }

            var f1 = Fibb(index - 1);
            var f2 = Fibb(index - 2);

            return f1 + f2;
        }
    }
}
