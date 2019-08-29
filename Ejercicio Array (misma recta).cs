using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] cx = { 0, 1, 2, 3 };
            double[] cy = { 0, 1, 2, 3 };

            double[] m = new double[3];
            double[] b = new double[3];
            double[] d = new double[3];

            double dmayor=0;

            int mrecta = 0;
            int i = 0;

            while (i <= 2)
            {
            m[i] =(cy[i + 1] - cy[i]) / (cx[i + 1] - cy[i]);
            b[i] = (cy[i] - m[i] * cx[i]);
            d[i] = (Math.Sqrt(Math.Pow((cx[i + 1] - cx[i]), 2) + (Math.Pow((cy[i + 1] - cy[i]), 2))));

            if (d[i] > dmayor) { dmayor = d[i]; }

            i++;
            }

            i = 0;

            while (i < 2)
            {
            if (m[i] == m[i+1] && b[i] == b[i+1])
                {
                    mrecta = 1;
                }
            else { mrecta = 0; }
                   
            i++;
            }

            if (mrecta == 1) { Console.WriteLine("Los segmentos pertenecen a la misma recta"); }
            else { Console.WriteLine("Los segmentos NO pertenecen a la misma recta"); }

            Console.WriteLine(dmayor);

        }
    }
}
