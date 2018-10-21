namespace Fraction
{
    class Helper
    {
        private static bool IsDivadibleBy(int number, int divider)
        {
            return number % divider == 0;
        }

        private static int GetMinimumValue(int x, int y)
        {
            return x < y ? x : y;
        }

        public static int FindingDivider(int divident, int divisor)
        {
            int min = GetMinimumValue(divident, divisor);
            for (int i = min; i >= 1; i--)
            {
                if (IsDivadibleBy(divident, i) && IsDivadibleBy(divisor, i))
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
