using System;

namespace atividade_1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, X;

            //Console.WriteLine("Digite o primeiro valor.");
            A = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o segundo valor.");
            B = int.Parse(Console.ReadLine());

            X = A + B;
            
            Console.WriteLine($"X = {X}");
        }
    }
}
