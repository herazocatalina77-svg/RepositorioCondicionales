using System;
namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            Console.WriteLine("Ingrese edad");
            edad = Int32.Parse(Console.ReadLine());
            if (edad < 18)
            {
                //Verdadero
                Console.WriteLine("Bienvenido al sitio web");
            }
            else
            {
                //falso
                Console.WriteLine("No es apto para este sitio web");
            }
        }
    }
}