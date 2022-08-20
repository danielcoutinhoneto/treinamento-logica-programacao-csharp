using System;
using System.Globalization;

namespace atividade_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario_antigo, salario_novo, reajuste;

            salario_antigo = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario_antigo <= 400.00)
            {
                int percentual = 15;
                salario_novo = ((salario_antigo * percentual) / 100) + salario_antigo;
                reajuste = (salario_antigo * percentual) / 100;
                Console.WriteLine($"Novo salario: {salario_novo.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
            else if (salario_antigo >= 400.01 && salario_antigo <= 800.00)
            {
                int percentual = 12;
                salario_novo = ((salario_antigo * percentual) / 100) + salario_antigo;
                reajuste = (salario_antigo * percentual) / 100;
                Console.WriteLine($"Novo salario: {salario_novo.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
            else if (salario_antigo >= 800.01 && salario_antigo <= 1200.00)
            {
                int percentual = 10;
                salario_novo = ((salario_antigo * percentual) / 100) + salario_antigo;
                reajuste = (salario_antigo * percentual) / 100;
                Console.WriteLine($"Novo salario: {salario_novo.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
            else if (salario_antigo >= 1200.01 && salario_antigo <= 2000.00)
            {
                int percentual = 7;
                salario_novo = ((salario_antigo * percentual) / 100) + salario_antigo;
                reajuste = (salario_antigo * percentual) / 100;
                Console.WriteLine($"Novo salario: {salario_novo.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
            else if (salario_antigo > 2000.00)
            {
                int percentual = 4;
                salario_novo = ((salario_antigo * percentual) / 100) + salario_antigo;
                reajuste = (salario_antigo * percentual) /100;
                Console.WriteLine($"Novo salario: {salario_novo.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"Em percentual: {percentual} %");
            }
        }
    }
}