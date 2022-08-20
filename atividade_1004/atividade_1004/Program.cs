using System;

namespace atividade_1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int VAL1, VAL2, PROD;

            VAL1 = int.Parse(Console.ReadLine());

            VAL2 = int.Parse(Console.ReadLine());

            PROD = VAL1 * VAL2;

            Console.WriteLine($"PROD = {PROD}");
        }
    }
}
