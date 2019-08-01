using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculodetarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int salario;
            double smmlv;

            Console.Write("Ingrese el valor de su salario = ");
            salario = int.Parse(Console.ReadLine());
            smmlv = 828116;

            if (salario < 2*smmlv)
            {
                Console.WriteLine("Debe de pagar la tarifa A");
            }
            else if (salario < 4*smmlv)
            {
                Console.WriteLine("Debe de pagar la tarifa B");
            }
            else
            {
                Console.WriteLine("Debe de pagar la tarifa C");
            }
        }
    }
}
