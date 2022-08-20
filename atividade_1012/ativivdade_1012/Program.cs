using System;
using System.Globalization;

namespace ativivdade_1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double valA, valB, valC, areaTri, areaCir, areaTra, 
                areaQua, areaRet;
            string[] vet; // AJUDA A COLOCAR TODAS AS VARIAVEIS DIGITADAS EM UMA ÚNICA LINHA, CONFORME PEDE A BAIXO.
                          

            vet = Console.ReadLine().Split(' ');
            valA = double.Parse(vet[0], CultureInfo.InvariantCulture); //OU DESSA FORMA =>  valA = Convert.ToDouble(vet[0], CultureInfo.InvariantCulture);
            valB = double.Parse(vet[1], CultureInfo.InvariantCulture); //OU DESSA FORMA =>  valB = Convert.ToDouble(vet[1], CultureInfo.InvariantCulture);
            valC = double.Parse(vet[2], CultureInfo.InvariantCulture); //OU DESSA FORMA =>  valC = Convert.ToDouble(vet[2], CultureInfo.InvariantCulture);

            areaTri = valA * valC / 2.0; //FORMULA Matematica A = b.h/2
            areaCir = 3.14159 * Math.Pow(valC, 2); //FORMULA Matematica A = Pi * r²
            areaTra = (valA + valB)*valC / 2; //FORMULA Matematica A = (Base Maior + Base Menor) * h / 2
            areaQua = Math.Pow(valB, 2); //FORMULA Matematica A = Lado * Lado * Lado * Lado
            areaRet = valA * valB; //FORMULA Matematica A = Base * Altura

            
            Console.WriteLine($"TRIANGULO: {areaTri.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO: {areaCir.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO: {areaTra.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO: {areaQua.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO: {areaRet.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
