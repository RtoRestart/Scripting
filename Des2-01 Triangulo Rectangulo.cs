using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Des2_01_TrianguloRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, a;

            double c, y, z;

            Console.WriteLine("Ingrese los siguientes datos correspondientes al triangulo rectangulo que se desea evaluar");
            Console.Write("t = ");
            t = int.Parse(Console.ReadLine());
            Console.Write("a° = ");
            a = int.Parse(Console.ReadLine());

            y = t * Math.Sin(a);
            z = t * Math.Cos(a);
            c = Math.Atan2(y,z);
            

            //Se pasa de radianes a grado los angulos

            c = (c * 180) / Math.PI;

            Console.WriteLine("El valor del angulo C es = " + c);
            Console.WriteLine("El valor del cateto Y = " + y);
            Console.WriteLine("El valor del cateto Z es = " + z);

        }
    }
}
