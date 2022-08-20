using System;
using System.Globalization;

namespace ativivdade_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, Volume, pi = 3.14159; ;

            R = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Volume = (double)(4.0 / 3) * pi * Math.Pow(R, 3);

            Console.WriteLine($"VOLUME = {Volume.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
