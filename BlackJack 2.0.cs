using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int carta = 0, jugador, nJug = 0, primPuesto = 0, segPuesto = 0;
            string continuar = "s";


            Console.WriteLine("░░░░█▐▄▒▒▒▌▌▒▒▌░▌▒▐▐▐▒▒▐▒▒▌▒▀▄▀▄░ \n ░░░█▐▒▒▀▀▌░▀▀▀░░▀▀▀░░▀▀▄▌▌▐▒▒▒▌▐░ \n ░░▐▒▒▀▀▄▐░▀▀▄▄░░░░░░░░░░░▐▒▌▒▒▐░▌ \n ░░▐▒▌▒▒▒▌░▄▄▄▄█▄░░░░░░░▄▄▄▐▐▄▄▀░░ \n ░░▌▐▒▒▒▐░░░░░░░░░░░░░▀█▄░░░░▌▌░░░ \n ▄▀▒▒▌▒▒▐░░░░░░░▄░░▄░░░░░▀▀░░▌▌░░░ \n ▄▄▀▒▐▒▒▐░░░░░░░▐▀▀▀▄▄▀░░░░░░▌▌░░░ \n ░░░░█▌▒▒▌░░░░░▐▒▒▒▒▒▌░░░░░░▐▐▒▀▀▄ \n ░░▄▀▒▒▒▒▐░░░░░▐▒▒▒▒▐░░░░░▄█▄▒▐▒▒▒ \n ▄▀▒▒▒▒▒▄██▀▄▄░░▀▄▄▀░░▄▄▀█▄░█▀▒▒▒▒\n");

            Console.WriteLine("Ingrese el número de jugadores (Min 2, Max 5): ");
            nJug = int.Parse(Console.ReadLine());
            while (nJug < 2 || nJug > 5)
            {
                Console.WriteLine("Error, Min 2, Max 5 jugadores");
                nJug = int.Parse(Console.ReadLine());
            }

            int[] puntajes = new int[nJug];

            for (jugador=0; jugador<nJug; jugador++ )
            {
                puntajes[jugador] = 0;
                carta = aleatorio.Next(1, 11);
                puntajes[jugador] += carta;

                Console.WriteLine("\n\nBienvenido jugador: " + (jugador + 1));
                Console.Write("*Se toman dos cartas* \n Las carta revelan los numeros: " + carta);

                carta = aleatorio.Next(1, 11);
                puntajes[jugador] += carta;
                Console.WriteLine(", " + carta);
                Console.WriteLine("El total es: " + puntajes[jugador]);


                Console.WriteLine("Desea tomar una carta? (s/n)");
                continuar = Console.ReadLine();

                while (continuar == "s" && puntajes[jugador] < 21)
                {
                    carta = aleatorio.Next(1, 11);
                    puntajes[jugador] += carta;
                    Console.WriteLine("\n*Se toma un carta de la baraja* \n La carta revela el numero: " + carta);
                    Console.WriteLine("El total es: " + puntajes[jugador]);
                    if (puntajes[jugador] < 21)
                    {
                        Console.WriteLine("Desea tomar otra carta? (s/n)");
                        continuar = Console.ReadLine();
                    }
                    else
                    {
                        if (puntajes[jugador] == 21) //pierde jugador
                        {
                            Console.WriteLine("Felicitaciones has ganado");
                        }
                        else
                        {
                            Console.WriteLine("Has perdido");
                            puntajes[jugador] = 0;
                            break;
                        }
                    }
                }
                if (continuar != "s")
                {
                    Console.WriteLine("Tu puntaje es de: " + puntajes[jugador]);
                    Console.WriteLine("te faltaron " + (21 - puntajes[jugador]) + " puntos para un BlackJack");
                }
            }

            for (int i = 0; i < nJug; i++)
            {
                if (puntajes[i] > puntajes[primPuesto])
                {
                    primPuesto = i;
                }

            }
            for (int i = 0; i < nJug; i++)
            {
                if (puntajes[i] > puntajes[segPuesto] && i != primPuesto)
                {
                    segPuesto = i;
                }

            }
            Console.WriteLine("El ganador es el jugador: " + (primPuesto + 1) + " con un puntaje de: " + (puntajes[primPuesto]));
            Console.WriteLine("Y el segundo puesto es para el jugador: " + (segPuesto + 1) + " con un puntaje de: " + (puntajes[segPuesto]));






        }
    }
}
