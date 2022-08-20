using System;
using System.Globalization;

namespace atividade_1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double Area, Raio;
            double N = 3.14159;


            Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = N * Raio * Raio;

            Console.WriteLine("A=" + Area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
