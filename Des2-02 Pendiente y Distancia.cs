using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2;

            double m, dist;

            Console.WriteLine("Ingrese el valor de: ");
            Console.Write("x1 = ");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("x2= ");
            x2 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = int.Parse(Console.ReadLine());

            m = (y2 - y1) / (x2 - x1);
            dist = Math.Sqrt((Math.Pow(x2 - x1,2)) + Math.Pow(y2 - y1,2));

            Console.WriteLine("La pendiente de la recta que pasa por las dos coordenadas es = " + m);
            Console.WriteLine("La distancia entre las dos coordenadas es = " + dist);
        }
    }
}
