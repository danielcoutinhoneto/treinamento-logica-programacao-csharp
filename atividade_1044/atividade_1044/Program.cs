
using System;

namespace atividade_1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            string[] multiplos = Console.ReadLine().Split(' ');

            n = Convert.ToInt32(multiplos[0]);
            m = Convert.ToInt32(multiplos[1]);

            if (m % n == 0 || n % m == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
