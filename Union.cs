using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conjuntos_Union
{
    class Union
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 3, 6, 6, 9, 12, 12, 15, 18 };
            int[] b = { 0, 2, 2, 4, 6, 6, 8, 10, 12, 14, 16, 18 };
            int[] u = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 , 19, 20, 21, 22, 23, 24, 25, 26 ,27, 28, 29, 30 };
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

            int[] union = new int[a.Length + b.Length];
            //primer conjunto excluyendo repetidos en a
            for (int i = 0; i < a.Length; i++)
            {
                //checkeo repetidos en a (no deben estar repetidos)
                bool check = false;
                for (int o = 0; o < i; o++)
                {
                    if (a[i] == a[o]) check = true;
                }
                if (!check) union[i] = a[i];
                else union[i] = -1;
            }
            //agregar segundo conjunto excluyendo repetidos en a
            for (int i = 0; i < b.Length; i++)
            {
                //checkeo repetidos en a y b(no deben estar repetidos)
                bool check = false;
                for (int o = 0; o < a.Length; o++)
                {
                    if (b[i] == a[o]) check = true;
                }
                for (int o = 0; o < i; o++)
                {
                    if (b[i] == b[o]) check = true;
                }
                //pass
                if (!check) union[i + a.Length] = b[i];
                else union[i + a.Length] = -1;
            }
            // -1 son los repetidos
            int contRepetidos = 0;
            for (int i = 0; i < union.Length; i++)
            {
                if(union[i] == -1)
                {
                    contRepetidos++;
                }
            }
            int[] union2 = new int[union.Length - contRepetidos];
            int f = 0;
            for (int i = 0; i < union.Length; i++)
            {
                if (union[i] != -1)
                {
                    union2[f] = union[i];
                    f++;
                }
            }
            //ordenar
            int temp = 0;
            for (int i = 0; i < union2.Length; i++)
            {
                for (int o = 0; o < union2.Length - 1; o++)
                {
                    if (union2[o] > union2[o + 1])
                    {
                        temp = union2[o];
                        union2[o] = union2[o + 1];
                        union2[o + 1] = temp;
                    }
                }
            } 
            //output
            Console.WriteLine("\nUnion:");
            for (int i = 0; i < union2.Length; i++) 
            {
                Console.WriteLine(union2[i]);
            }
        }
    }
}