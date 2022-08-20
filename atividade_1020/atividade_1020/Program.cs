using System;

namespace atividade_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalDias,resto, ano, mes, dia; // tira a variavel resto e subtitui no lugar das outras as que estão comentadas

            Console.WriteLine("Informe sua idade em dias");
            totalDias = Convert.ToInt32(Console.ReadLine());

            ano = totalDias / 365;
            resto = totalDias % 365;

            mes = resto / 30;  // Subtitui por essa => (totalDias % 365) / 30;
            dia = resto % 30; // Subtitui por essa =>  (totalDias % 365) % 30;

            Console.WriteLine($"{ano} ano(s)");
            Console.WriteLine($"{mes} mes(es)");
            Console.WriteLine($"{dia} dia(s)");

        }
    }
}
