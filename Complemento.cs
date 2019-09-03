using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos_Complemento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 3, 6, 6, 9, 12, 12, 15, 18 };
            int[] b = { 0, 2, 2, 4, 6, 6, 8, 10, 12, 14, 16, 18 };
            int[] u = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            //conjuntos
            Console.WriteLine("Conjunto A:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("\nConjunto B:");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }

            for (int i = 0; i < u.Length; i++)
            {
                //checkeo repetidos en a y b (no deben estar repetidos)
                bool check = false;
                for (int o = 0; o < a.Length; o++)
                {
                    if (u[i] == a[o]) check = true;
                }
				for (int o = 0; o < b.Length; o++)
                {
                    if (u[i] == b[o]) check = true;
                }

                if (check) u[i] = -1;
                
            }
            int contInvalidos = 0;
            for (int i = 0; i < u.Length; i++)
            {
                if (u[i] == -1)
                {
                    contInvalidos++;
                }
            }
            //nuevo array excluyendo los -1s
            int[] complemento = new int[u.Length - contInvalidos];
            int f = 0;
            for (int i = 0; i < u.Length; i++)
            {
                if (u[i] != -1)
                {
                    complemento[f] = u[i];
                    f++;
                }
            }

            //output
            Console.WriteLine("\nComplemento:");
            for (int i = 0; i < complemento.Length; i++)
            {
                Console.WriteLine(complemento[i]);
            }
        }
    }
}
