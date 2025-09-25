using System;
namespace Ejerccicio
{
    public class Clasetrecedeagosto
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int sueldo = 0;
            Console.WriteLine("Ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());
            if (sueldo > 3000)
            {
                //Verdadero
                Console.WriteLine($"La persona {nombre} , debe abonar impuestos");
            }
            else
            {
                //False
                Console.WriteLine($"La persona {nombre} , no abona impuestos");
            }
        }
    }
}