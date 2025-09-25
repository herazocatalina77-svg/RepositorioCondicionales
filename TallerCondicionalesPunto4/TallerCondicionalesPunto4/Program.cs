using System;

public class Tallercondicionalespunto4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Presiona la letra I o D del teclado");
        char letra = Console.ReadLine()[0];

        if (letra == 'd' || letra == 'D')
        {
            Console.WriteLine($"El personaje se mueve a la derecha");
        }
        else if (letra == 'i' || letra == 'I')
        {

            Console.WriteLine($"El personaje se está moviendo a la izquierda");
        }
        else
        {
            Console.WriteLine($"No te puedes mover en otra dirección");
        }
    }
}