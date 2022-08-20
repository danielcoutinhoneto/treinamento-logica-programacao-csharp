using System;
using System.Globalization;

namespace atividade_1037
{
    class Program
    {
        static void Main(string[] args)
        {
            // REFATORAÇÃO DO CÓDIGO
            double valor;

            valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0.0 || valor > 100.0)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25.0)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor <= 50.0)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (valor <= 75.0)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else
            {
                Console.WriteLine("Intervalo (75,100]");
            }

            /*
             * FORMA INICIAL 
             * 
            double valor, intervalo;

            valor = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor < 0 || valor > 100 )
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (valor <= 25.0000)
            {
                intervalo = 0.25;
                Console.WriteLine($"[{intervalo.ToString("F2")}]");
            }
            else if (valor <= 50.0000000)
            {
                intervalo = 25.50;
                Console.WriteLine($"({intervalo.ToString("F2")}]");
            }
            else if (valor <= 75.0000000)
            {
                intervalo = 50.75;
                Console.WriteLine($"({intervalo.ToString("F2")}]");
            }
            else
            {
                intervalo = 75.100;
                Console.WriteLine($"({intervalo.ToString("F3")}]");
            }
            */
        }
    }
}
