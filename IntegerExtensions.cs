using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            if (b == 0 )
            {
                throw new DivideByZeroException();
            }
            if (a == 0 && b == 0)
            {
                throw new ArgumentException();
            }
            int r = -1;
            while (r != 0)
            {
                r = a % b;
                if (r == 0)
                    break;
                a = b;
                b = r;
            }
            if (b < 0)
                b *= -1;
            return b;
        }
    }
}
