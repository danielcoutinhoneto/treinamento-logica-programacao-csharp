using System;
using System.Globalization;

namespace atividade_1048_reducao_cod
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_antigo;

            salario_antigo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double percentual;
            if (salario_antigo <= 400.00)
            {
                percentual = 15;
            }
            else if (salario_antigo <= 800.00)
            {
                percentual = 12;
            }
            else if (salario_antigo <= 1200.00)
            {
                percentual = 10;
            }
            else if (salario_antigo <= 2000.00)
            {
                percentual = 7;
            }
            else
            {
                percentual = 4;
            }

            double val_reajuste = (salario_antigo * percentual) / 100.0;
            double salario_novo = salario_antigo + val_reajuste;

            Console.WriteLine($"Novo salario: {salario_novo.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Reajuste ganho: {val_reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Em percentual: {percentual}%");

        }
    }
}
