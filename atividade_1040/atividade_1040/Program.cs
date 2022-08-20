using System;
using System.Globalization;

namespace atividade_1040
{
    class Program
    {
        static void Main(string[] args)
        {
            float N1, N2, N3, N4, exame, media, media_exame;

            string [] vet = Console.ReadLine().Split(' ');

            N1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            N2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            N3 = Convert.ToSingle(vet[2], CultureInfo.InvariantCulture);
            N4 = Convert.ToSingle(vet[3], CultureInfo.InvariantCulture);

            media = ((N1 * 2) + (N2 * 3) + (N3 * 4) + (N4 * 1)) / 10;

            if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else if (media < 5.0)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno reprovado");
                return;
            }
            else if (media >= 7.0)
            {
                Console.WriteLine($"Media: {media.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Aluno aprovado");
                return;
            }
            else 
            {
                Console.WriteLine("Aluno em exame.");

                exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {exame.ToString("F1", CultureInfo.InvariantCulture)}");

                media_exame = (exame + media) / 2;
                if (media_exame >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine($"Media final: {media_exame.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
