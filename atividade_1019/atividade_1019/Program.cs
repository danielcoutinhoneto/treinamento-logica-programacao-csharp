using System;

namespace atividade_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, horas, minutos, segundos; // incluir a variável resto

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            // resto = N % 3600;
            minutos = (N % 3600) / 60;  //subtituiria por minutos = resto / 60;
            segundos = (N % 3600) % 60; //subtituiria por segundos = resto % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}
