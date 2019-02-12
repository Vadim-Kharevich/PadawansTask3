using System;

namespace PadawansTask3
{
    public static class IntegerExtensions
    {
        public static int Gcd(int a, int b)
        {
            int r = -1;
            while (r != 0)
            {
                r = a % b;
                if (r == 0)
                    break;
                a = b;
                b = r;
            }
            return b;
        }
    }
}
