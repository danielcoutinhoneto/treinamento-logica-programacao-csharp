using System;
using System.Globalization;

namespace ativivdade_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVend;
            double salaFixo, totalVend, ganho;

            nomeVend = Console.ReadLine();
            salaFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalVend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ganho = ((totalVend * 15) /100) + salaFixo; // FORMULA DO CALCULO DA PORCENTAGEM É A PARTE QUE ESTÃO NOS PARENTESES 


            Console.WriteLine($"TOTAL = R$ {ganho.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
