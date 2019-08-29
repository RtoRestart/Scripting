using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int nDatos = 0;
            int nMayor = 0;
            int idMayor = 0;
            int nMenor = 0;
            int idMenor = 0;
            int sumEdades = 0;


            double promEdades;
            double sumDesv = 0;
            double desvEst = 0;
            double cercanoprom = 0;

            int idcercano = 0;

            Console.WriteLine("Ingresar Cantidad de datos: " );
            nDatos = int.Parse(Console.ReadLine());

            string[] nombre = new string[nDatos];
            int[] edad = new int[nDatos];



            for (int i = 0; i < nDatos; i++)
            {
                Console.WriteLine("Ingresar Nombre de: " + (i + 1));
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingresar edad de: " + (i + 1));
                edad[i] = int.Parse(Console.ReadLine());

                sumEdades += edad[i];
            }

            promEdades = (sumEdades / nDatos);
            nMenor = edad[0];

            for (int i = 0; i < nDatos; i++)
            {
                if (edad[i] > nMayor)
                {
                    nMayor = edad[i];
                    idMayor = i;
                }
                if (edad[i] < nMenor)
                {
                    nMenor = edad[i];
                    idMenor = i;
                }

                sumDesv += Math.Pow((edad[i] - promEdades), 2);
                

            }
            desvEst = Math.Pow(sumDesv / nDatos, 1 / 2);

            cercanoprom = Math.Abs(edad[0] - promEdades);

            for (int i = 0; i < nDatos; i++)
            {
                if (Math.Abs(edad[i]-promEdades) < cercanoprom)
                {
                    cercanoprom = Math.Abs(edad[i] - promEdades);
                    idcercano = i;
                }
                    
            }

            Console.WriteLine("La persona de mayor edad es: " + nombre[idMayor] + " con edad de: " + nMayor);
            Console.WriteLine("La persona de menor edad es: " + nombre[idMenor] + " con edad de: " + nMenor);
            Console.WriteLine("El promedio de las edades es de: " + promEdades);
            Console.WriteLine("La desviacion estandar es: " + desvEst);
            Console.WriteLine("La persona con edad mas cercana al promedio es: " + nombre[idcercano]);

           
            


        }
    }
}
