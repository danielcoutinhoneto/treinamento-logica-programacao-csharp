using System;
using System.Globalization;

namespace atividade_1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, quant;
            double val;
            string [] vet = Console.ReadLine().Split(' ');

            cod = Convert.ToInt32(vet[0]);
            quant = Convert.ToInt32(vet[1]);

            if (cod == 1)
            {
                val = 4.00 * quant;
                Console.WriteLine($"Total: R$ {val.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 2)
            {
                val = 4.50 * quant;
                Console.WriteLine($"Total: R$ {val.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 3)
            {
                val = 5.00 * quant;
                Console.WriteLine($"Total: R$ {val.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 4)
            {
                val = 2.00 * quant;
                Console.WriteLine($"Total: R$ {val.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            else if (cod == 5)
            {
                val = 1.50 * quant;
                Console.WriteLine($"Total: R$ {val.ToString("F2",CultureInfo.InvariantCulture)}");
            }
        }
    }
}
