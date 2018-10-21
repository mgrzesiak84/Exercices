using System;

namespace Fraction
{
    class Fraction
    {
        static void Main(string[] args)
        {
            var licznik = 12;
            var mianownik = 36;

            FractionObject a = new FractionObject(licznik, mianownik);
            Console.WriteLine(a.ToString());
            Console.Write("Fraction reprezentation of two numbers {0} and {1} is: {2}",licznik, mianownik, FractionObject.Fraction_Normalizaing(licznik, mianownik));
            Console.ReadLine();
        }
    }
}
