using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamirezTareaSerie
{
    class Serie
    {
        public static double CalcularSerie(int i, int n)
        {
            double A = 0;
            double T = 0;
            while (i <= n)
            {
                A += ((Math.Pow(2, i + 1)) - (Math.Pow(2, i))) / (i + 1);
                i++;
            }
            T = T + A;


            return T;
        }
    }
}