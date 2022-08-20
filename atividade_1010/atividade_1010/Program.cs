
using System;
using System.Globalization;

namespace atividade_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para ler vários dados na mesma linha

            int codPe1, numPe1, codPe2, numPe2;
            double valPe1, valPe2, valPg;

            string[] vet = Console.ReadLine().Split(' ');
            codPe1 = int.Parse(vet[0]);
            numPe1 = int.Parse(vet[1]);
            valPe1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            vet = Console.ReadLine().Split(' ');
            codPe2 = Convert.ToInt32(vet[0]);
            numPe2 = Convert.ToInt32(vet[1]);
            valPe2 = Convert.ToDouble(vet[2], CultureInfo.InvariantCulture);

            valPg = numPe1 * valPe1 + numPe2 * valPe2;

            Console.WriteLine($"VALOR A PAGAR: R$ {valPg.ToString("F2", CultureInfo.InvariantCulture)}");


            /*
             * Para ler vários dados em linhas distintas
             *  
            int codPe1, numPe1, codPe2, numPe2;
            double valPe1, valPe2, valPg;

            codPe1 = Convert.ToInt32(Console.ReadLine());
            numPe1 = Convert.ToInt32(Console.ReadLine());
            valPe1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            codPe2 = Convert.ToInt32(Console.ReadLine());
            numPe2 = Convert.ToInt32(Console.ReadLine());
            valPe2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            valPg = numPe1 * valPe1 + numPe2 * valPe2;

            Console.WriteLine($"VALOR A PAGAR: R$ {valPg.ToString("F2", CultureInfo.InvariantCulture)}");

            */


        }
    }
}
