using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos_Interseccion
{
    class Interseccion
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

            int[] interseccion = new int[b.Length];
            //exclusion numeros
            for (int i = 0; i < b.Length; i++)
            {
                //checkeo de repeticion en b (no se debe repetir)
                bool check = false;
                for (int o = 0; o < i; o++)
                {
                    if (b[i] == b[o]) check = true;
                }
                //pass
                if (!check)
                {
                    //checkeo de interseccion en a (debe intersectar)
                    check = false;
                    for (int v = 0; v < a.Length; v++)
                    {
                        if (b[i] == a[v]) check = true;
                    }
                    if (!check) interseccion[i] = -1;
                    //pass
                    else interseccion[i] = b[i];
                }
                else interseccion[i] = -1;
            }
            // -1 son los repetidos en b o no estan en a (invalidos)

            int contInvalidos = 0;
            for (int i = 0; i < interseccion.Length; i++)
            {
                if (interseccion[i] == -1)
                {
                    contInvalidos++;
                }
            }
            //nuevo array excluyendo los -1s
            int[] interseccion2 = new int[interseccion.Length - contInvalidos];
            int f = 0;
            for (int i = 0; i < interseccion.Length; i++)
            {
                if (interseccion[i] != -1)
                {
                    interseccion2[f] = interseccion[i];
                    f++;
                }
            }
            //ordenar
            int temp = 0;
            for (int i = 0; i < interseccion2.Length; i++)
            {
                for (int o = 0; o < interseccion2.Length - 1; o++)
                {
                    if (interseccion2[o] > interseccion2[o + 1])
                    {
                        temp = interseccion2[o];
                        interseccion2[o] = interseccion2[o + 1];
                        interseccion2[o + 1] = temp;
                    }
                }
            }
            //output
            Console.WriteLine("\nInterseccion:");
            for (int i = 0; i < interseccion2.Length; i++)
            {
                Console.WriteLine(interseccion2[i]);
            }
        }
    }
}
