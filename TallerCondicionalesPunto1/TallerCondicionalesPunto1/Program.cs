using System;
using System.Diagnostics.CodeAnalysis;
public class TallerCondicionalesPunto1
{
    static void Main(string[] args)
    {
        //Ingresar tres numeros e identificar el mayor
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;

        Console.WriteLine("Ingrese el numero 1:");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el numero 2:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el numero 3:");
        num3 = Convert.ToInt32(Console.ReadLine());
        //verificar duplicados
        switch ((num1, num2, num3))
        {
            case var (a, b, c) when (a == b || a == c):
                Console.WriteLine("No se pueden usar numeros iguales");
                break;
        }
        //Identificar el orden
        switch ((num1, num2, num3))
        {
            case var (a, b, c) when (a > b && b > c)://num1>num2>num3
                Console.WriteLine($"{num1},{num2},{num3}");
                break;
            case var (a, b, c) when (a > b && c > b)://num1>num3>num2
                Console.WriteLine($"{num1},{num3},{num2}");
                break;
            case var (a, b, c) when (b > a && a > c)://num2>num1>num3
                Console.WriteLine($"{num2},{num1},{num3}");
                break;
            case var (a, b, c) when (b > a && c > a)://num2>num3>num1
                Console.WriteLine($"{num2},{num3},{num1}");
                break;
            case var (a, b, c) when (c > a && a > b)://num3>num1>num2
                Console.WriteLine($"{num3},{num1},{num2}");
                break;
            case var (a, b, c) when (c > a && b > a): //num3>num2>num1
                Console.WriteLine($"{num3},{num2},{num1}");
                break;

        }
    }
}
