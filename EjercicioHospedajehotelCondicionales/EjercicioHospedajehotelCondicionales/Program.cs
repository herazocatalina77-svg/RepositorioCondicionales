using System;
namespace CondicionalesHospedaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            Console.WriteLine($"Ingrese el nombre");
            nombre = (Console.ReadLine());
            int num1 = 0;
            Console.WriteLine($"Ingrese la cantidad de noches que se va a quedar");
            num1 = Int32.Parse(Console.ReadLine());
            if (num1 > 3)
            {
                Console.WriteLine($"El precio total de su hospedaje sera");
                double num2 = num1 * 200;
                double num3 = num2 * 0.83;
                Console.WriteLine(num3);
            }
            else
            {
                Console.WriteLine($"El precio total de su hospedaje sera");
                double num4 = num1 * 200;
                double num5 = num4 * 0.88;
                Console.WriteLine(num5);
            }
        }
    }
}