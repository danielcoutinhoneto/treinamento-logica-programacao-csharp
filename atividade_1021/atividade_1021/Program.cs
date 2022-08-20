using System;
using System.Globalization;

namespace atividade_1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, notas_100, notas_50, notas_20, notas_10, notas_5, notas_2;
            double moedas_1, moedas_050, moedas_025, moedas_010, moedas_005, moedas_001;

            n = Convert.ToDouble(Console.ReadLine());

            // NOTAS

            notas_100 = (n - n % 100) / 100;
            n = n % 100;

            notas_50 = (n - n % 50) / 50;
            n = n % 50;

            notas_20 = (n - n % 20) / 20;
            n = n % 20;

            notas_10 = (n - n % 10) / 10;
            n = n % 10;

            notas_5 = (n - n % 5) / 5;
            n = n % 5;

            notas_2 = (n - n % 2) / 2;
            n = n % 2;

            // MOEDAS

            moedas_1 = (n - n % 1.00) / 1.00;
            n = n % 1.00;

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{notas_100} nota (s) de R$ 100,00");
            Console.WriteLine($"{notas_50} nota (s) de R$ 50,00");
            Console.WriteLine($"{notas_20} nota (s) de R$ 20,00");
            Console.WriteLine($"{notas_10} nota (s) de R$ 10,00");
            Console.WriteLine($"{notas_5} nota (s) de R$ 5,00");
            Console.WriteLine($"{notas_2} nota (s) de R$ 2,00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{moedas_1} moeda (s) de R$ 1.00");



            /*
            cem = n / 100;
            resto = n % 100;

            cinq = resto / 50;
            vinte = resto / 20;

            Console.WriteLine(cem);
            Console.WriteLine(cinq);
            Console.WriteLine(vinte);
            */
        }
    }
}
