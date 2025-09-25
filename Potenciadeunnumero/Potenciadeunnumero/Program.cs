using System;
namespace Potenciadeunnumero1
{
    internal class Potenciadeunnumero
    {
        static void Main(string[] args)
        {
            double baseNum = 2;
            double exponente = 3;
            Console.WriteLine("Ingrese una base para la potencia");
            baseNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un exponente para la potencia");
            baseNum = Convert.ToDouble(Console.ReadLine());
            double resultado = Math.Pow(baseNum, exponente);
            Console.WriteLine($"El resultado de su potencia es: {resultado}");
        }
    }
}