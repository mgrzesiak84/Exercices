using System;

namespace Fraction
{
    public class FractionObject

    {
        // constructor

        public FractionObject(int counter, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Attempt divide by zero.");
            }
            _counter = counter;
            _denominator = denominator;
        }

        public FractionObject(int newCounter)
        {
            this.newCounter = newCounter;
        }

        // fields
        public int _counter;
        public int _denominator;
        private int newCounter;

        // properties

        public int Counter => _counter;

        public int Denominator => _denominator;

        // methods

        public static FractionObject Fraction_Normalizaing(int counter, int denominator)
        {
            int divider = Helper.FindingDivider(counter, denominator);
            int newCounter = counter / divider;
            int newDenominator = denominator / divider;

            if (newDenominator == 1)
            {
                return new FractionObject(newCounter);
            }

            return new FractionObject(newCounter, newDenominator);

        }

        public override string ToString()
        {
            return $" \n {Counter} \r\n - \r\n {Denominator} ";
        }
    }
}