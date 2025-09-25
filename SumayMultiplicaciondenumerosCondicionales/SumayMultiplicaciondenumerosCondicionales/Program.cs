using System;
namespace SumayMultiplicacionNumeros
{
    internal class Program
    {
        static void Third(string[] args)
        {
            int num1 = 0;
            Console.WriteLine("Ingrese numero1");
            num1 = Int32.Parse(Console.ReadLine());
            int num2 = 0;
            Console.WriteLine("Ingrese numero2");
            num2 = Int32.Parse(Console.ReadLine());
            if (num2 < num1)
            {
                //Verdadero
                Console.WriteLine($"Suma");
                int num3 = num1 + num2;
                Console.WriteLine(num3);
                Console.WriteLine($"Resta");
                int num4 = num1 - num2;
                Console.WriteLine(num4);
            }
            else
            {
                int num5 = num1 * num2;
                Console.WriteLine(num5);
                int num6 = num1 / num2;
                Console.WriteLine(num6);
            }
        }
    }
}