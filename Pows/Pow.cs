using System;

namespace Pows
{
    public class Pow
    {
        static void Main(string[] args)
        {

            Console.Write("Set base of the power: ");

            string _base = Console.ReadLine();

            int baseParsed;

            bool result = int.TryParse(_base, out baseParsed);

            if (result)
            {
                Console.Write("Set exponent of the power: ");

                int exponentParsed;
                bool result2 = int.TryParse(Console.ReadLine(), out exponentParsed);

                if (result2)
                {
                    Console.WriteLine("Pow is equal {0}" , Math.Pow(baseParsed, exponentParsed));
                }
                else
                {
                    Console.Write("Exponent of the power is not an integer number !");
                }
            }

            else
            {

                Console.Write("Base of the power is not an integer number !");

            }

            Console.ReadKey();

        }
    }
}
