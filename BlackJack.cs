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
            int carta = 0, total = 0;
            string continuar = "s";
            carta = aleatorio.Next(1, 11);
            total += carta;
            Console.WriteLine("░░░░█▐▄▒▒▒▌▌▒▒▌░▌▒▐▐▐▒▒▐▒▒▌▒▀▄▀▄░ \n ░░░█▐▒▒▀▀▌░▀▀▀░░▀▀▀░░▀▀▄▌▌▐▒▒▒▌▐░ \n ░░▐▒▒▀▀▄▐░▀▀▄▄░░░░░░░░░░░▐▒▌▒▒▐░▌ \n ░░▐▒▌▒▒▒▌░▄▄▄▄█▄░░░░░░░▄▄▄▐▐▄▄▀░░ \n ░░▌▐▒▒▒▐░░░░░░░░░░░░░▀█▄░░░░▌▌░░░ \n ▄▀▒▒▌▒▒▐░░░░░░░▄░░▄░░░░░▀▀░░▌▌░░░ \n ▄▄▀▒▐▒▒▐░░░░░░░▐▀▀▀▄▄▀░░░░░░▌▌░░░ \n ░░░░█▌▒▒▌░░░░░▐▒▒▒▒▒▌░░░░░░▐▐▒▀▀▄ \n ░░▄▀▒▒▒▒▐░░░░░▐▒▒▒▒▐░░░░░▄█▄▒▐▒▒▒ \n ▄▀▒▒▒▒▒▄██▀▄▄░░▀▄▄▀░░▄▄▀█▄░█▀▒▒▒▒\n");

            Console.Write("*Se toman dos cartas* \n Las carta revelan los numeros: " + carta);

            carta = aleatorio.Next(1, 11);
            total += carta;
            Console.WriteLine(", " + carta);
            Console.WriteLine("El total es: " + total);


            Console.WriteLine("Desea tomar una carta? (s/n)");
            continuar = Console.ReadLine();

            while (continuar == "s" && total < 21 )
            {
                carta = aleatorio.Next(1, 11);
                total += carta;
                Console.WriteLine("*Se toma un carta de la baraja* \n La carta revela el numero: " + carta);
                Console.WriteLine("El total es: " + total);
                if (total < 21)
                { 
                    Console.WriteLine("Desea tomar otra carta? (s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    if (total == 21)
                    {
                        Console.WriteLine("Felicitaciones has ganado");
                    }
                    else
                    {
                        Console.WriteLine("Has perdido");
                    }
                }
            }
            if (continuar != "s")
            {
                Console.WriteLine("Tu puntaje es de: " + total);
                Console.WriteLine("te faltaron " + (21 - total) + " puntos para un BlackJack");
            }

        }
    }
}
