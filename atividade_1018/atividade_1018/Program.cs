using System;

namespace atividade_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            // MEU MODELO

            int N, deco_100, deco_50, deco_20, deco_10, deco_5, deco_2, deco_1;

            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{N}");

            deco_100 = (N - N % 100) / 100;
            N = N % 100;

            deco_50 = (N - N % 50) / 50;
            N = N % 50;

            deco_20 = (N - N % 20) / 20;
            N = N % 20;

            deco_10 = (N - N % 10) / 10;
            N = N % 10;

            deco_5 = (N - N % 5) / 5;
            N = N % 5;

            deco_2 = (N - N % 2) / 2;
            N = N % 2;

            deco_1 = (N - N % 1) / 1;
            N = N % 1;

            
            Console.WriteLine($"{deco_100} nota(s) de R$ 100,00");
            Console.WriteLine($"{deco_50} nota(s) de R$ 50,00");
            Console.WriteLine($"{deco_20} nota(s) de R$ 20,00");
            Console.WriteLine($"{deco_10} nota(s) de R$ 10,00");
            Console.WriteLine($"{deco_5} nota(s) de R$ 5,00"); 
            Console.WriteLine($"{deco_2} nota(s) de R$ 2,00");
            Console.WriteLine($"{deco_1} nota(s) de R$ 1,00");

           

            /*
             * MODELO DO PROFESSOR
             * 

            int N, quociente, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");
            *
            */
        }
    }
}
