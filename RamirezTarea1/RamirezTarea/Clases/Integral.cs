using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamirezTareaIntegral
{
    class Integral
    {

        public static long Fact(int n)
        {
            long f = 1;
            if (n == 0)
                return 1;
            for (int i = 1; i <= n; i++)
            {
                f *= i;

            }
            return f;

        }
        public static long SumFact(int n)
        {

            long a = 0, s = 0;

            for (int i = 1; i <= n; i++)
            {
                a = Fact(i);
                s += a;

            }
            return s;
        }
    }
}