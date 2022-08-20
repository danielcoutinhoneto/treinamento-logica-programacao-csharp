using System;

namespace atividade_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora_inicial, hora_final, calc;

            string[] duracao = Console.ReadLine().Split(' ');

            hora_inicial = Convert.ToInt32(duracao[0]);
            hora_final = Convert.ToInt32(duracao[1]);

            if (hora_final > hora_inicial)
            {
                calc = hora_final - hora_inicial;
            }
            else
            {
                calc = 24 - hora_inicial + hora_final;
            }

            Console.WriteLine($"O JOGO DUROU {calc} HORA(S)");
        }
    }
}
