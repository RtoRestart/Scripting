using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validacion_ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0, b=0, suma, contador=0;
            Random aleatorio = new Random();

            while (contador <= 2)
            {
                a = aleatorio.Next(0,11);
                b = aleatorio.Next(0,11);
                Console.WriteLine("Ingrese el resultado de la siguiente suma \n"  + a + " + " + b + ":" );
                suma = int.Parse(Console.ReadLine());
                contador++;
                if (a + b == suma) break;
                else Console.WriteLine("\n Error, la respuesta ingresada es incorrecta");
            }
            if (contador == 3) Console.WriteLine("\n \n Error, se han acabado los intentos");
            else Console.WriteLine("\n \n Inicio del Programa");
        }
    }
}
