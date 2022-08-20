using System;
using System.Globalization;

namespace atividade_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA;

            A = Convert.ToDouble(Console.ReadLine(), CultureInfo.CurrentCulture);
            B = Convert.ToDouble(Console.ReadLine(), CultureInfo.CurrentCulture);

            MEDIA = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {MEDIA.ToString("F5", CultureInfo.CurrentCulture)}");
        }
    }
}
