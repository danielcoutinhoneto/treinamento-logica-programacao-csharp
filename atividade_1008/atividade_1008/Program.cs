using System;
using System.Globalization;

namespace atividade_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numF, numH;
            double valHora, valTra;

            numF = Convert.ToInt32(Console.ReadLine());
            numH = Convert.ToInt32(Console.ReadLine());
            valHora = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            valTra = numH * valHora;

            Console.WriteLine($"NUMBER = {numF}");
            Console.WriteLine($"SALARY = U$ {valTra.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
