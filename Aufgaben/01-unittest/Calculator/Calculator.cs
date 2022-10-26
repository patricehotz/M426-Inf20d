using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int multiplicator, int multiplier)
        {
            return multiplicator * multiplier;
        }

        public int Divide(int mommy, int divider)
        {
            if (mommy == 0 || divider == 0)
            {
                throw new ArgumentException();
            }
            return mommy / divider;
        }
    }
}
