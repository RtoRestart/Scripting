using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resumen_Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ORDEN DE MAYOR A MENOR
            string[] a = { "s", "l", "m", "k", "m" };
            int[] b = { 1, 2, 1, 5, 4 };
            string tmpA;
            int tmpB;

            for (int s = 1; s < a.Length; s++)
            {
                for (int i = 1; i < a.Length - 1; i++)
                {
                    if (b[i + 1] > b[i])
                    {
                        tmpA = a[i];
                        tmpB = b[i];
                        a[i] = a[i + 1];
                        a[i + 1] = tmpA;
                        b[i] = b[i + 1];
                        b[i + 1] = tmpB;

                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("\na: " + a[i]);
                Console.WriteLine("b: " + b[i]);
            }
            */


            /*  ORDEN MENOR A MAYOR
            string[] a = { "s", "l", "m", "k", "m" };
            int[] b = { 1, 2, 1, 5, 4 };
            string tmpA;
            int tmpB;

            for (int s = 1; s < a.Length; s++)
            {
                for (int i = 1; i < a.Length - 1; i++)
                {
                    if (b[i + 1] < b[i])
                    {
                        tmpA = a[i];
                        tmpB = b[i];
                        a[i] = a[i + 1];
                        a[i + 1] = tmpA;
                        b[i] = b[i + 1];
                        b[i + 1] = tmpB;

                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("\na: " + a[i]);
                Console.WriteLine("b: " + b[i]);
            }
            */

            /* MEDIA(PROM) Y DESVIACION ESTANDAR
            string[] a = { "s", "l", "m", "k", "m" };
            int[] b = { 1, 2, 1, 5, 4 };

            double media = 0, dE = 0;

            for (int i = 0; i < b.Length; i++)
            {
                media = media + b[i];
            }
            media = media / b.Length;

            for (int i = 0; i < a.Length; i++)
            {
                dE = dE + Math.Pow((b[i] - media), 2);
            }
            dE = Math.Sqrt(dE / b.Length);
            Console.WriteLine("media: " + media + "\nDesviación Est: " + dE);
            */

            /* DESVIACION INDIVIDUAL ARRAY
            string[] a = { "s", "l", "m", "k", "m" };
            int[] b = { 1, 2, 1, 5, 4 };

            string tmpA;
            double tmpB;

            double media = 0;
            double[] dI = new double[a.Length]; //dI = desviacion Individual

            for (int i = 0; i < b.Length; i++)
            {
                media = media + b[i];
            }
            media = media / b.Length;

            for (int i = 0; i < a.Length; i++)
            {
                dI[i] = Math.Sqrt(((Math.Pow((b[i] - media), 2)) / a.Length));
            }

            for (int s = 0; s < a.Length - 1; s++)
            {
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (dI[i + 1] > dI[i])
                    {
                        tmpA = a[i];
                        tmpB = dI[i];
                        a[i] = a[i + 1];
                        a[i + 1] = tmpA;
                        dI[i] = dI[i + 1];
                        dI[i + 1] = tmpB;

                    }
                }
            }
            */

            /* NUMERO DE PALABRAS EN FRASE
            string texto = "habia una vez un niggachin caminando por la calle y se mando un mega dab, y se convirtio en el nigga mas feliz del mundo nigga";
            string palabra = "nigga ";

            int count = 0;

            if (palabra.Length > 0)
            {

                for (int i = 0; i < texto.Length - palabra.Length + 1; i++)
                {
                    bool check = true;
                    for (int o = 0; o < palabra.Length; o++)
                    {
                        if (texto[i + o] != palabra[o])
                        {
                            check = false;
                        }
                    }
                        if (check)  count++;
                }

            }

            Console.WriteLine(count);
            */
        }
    }
}
