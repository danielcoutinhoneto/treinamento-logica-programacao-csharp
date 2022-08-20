using System;

namespace atividade_1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int dist, calTemp;

            dist = Convert.ToInt32(Console.ReadLine());

            calTemp = dist * 2;

            Console.WriteLine($"{calTemp} minutos");
        }
    }
}
