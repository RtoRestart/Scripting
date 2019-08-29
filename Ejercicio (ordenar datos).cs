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
            string[] nombres = { "s", "l", "m", "k", "m" };
            int[] notas = { 1, 2, 1, 5, 4 };
            string tmpNom;
            int tmpNot;

            for (int s = 0; s < nombres.Length - 1; s++)
            {
            for (int i = 0; i < nombres.Length - 1; i++)
            {
                if (notas[i + 1] > notas[i])
                {
                    tmpNom = nombres[i];
                    tmpNot = notas[i];
                    nombres[i] = nombres[i + 1];
                    nombres[i + 1] = tmpNom;
                    notas[i] = notas[i + 1];
                    notas[i + 1] = tmpNot;

                }
            }
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("\nNombre: " + nombres[i]);
                Console.WriteLine("Puntaje: " + notas[i]);
            }
        }
    }
}
