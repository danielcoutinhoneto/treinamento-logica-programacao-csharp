using System;

namespace atividade_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC, maiorVa_Vb, maior;
            string[] vet;

            vet = Console.ReadLine().Split(' ');
            valorA = Convert.ToInt32(vet[0]);
            valorB = Convert.ToInt32(vet[1]);
            valorC = Convert.ToInt32(vet[2]);

            maiorVa_Vb = (valorA + valorB + Math.Abs(valorA -valorB) / 2);
            maior = Math.Abs(maiorVa_Vb - valorC);

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}
