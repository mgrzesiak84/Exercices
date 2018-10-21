using System;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            if (number > 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    for (int k = i; k <= number; k++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Christmas tree is not possible to create.");
            }

            Console.ReadLine();
        }

    }
}
