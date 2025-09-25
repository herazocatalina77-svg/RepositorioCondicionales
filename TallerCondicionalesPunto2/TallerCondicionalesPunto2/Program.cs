using System;
public class Tiki
{
    static void Main(string[] args)
    {
        Console.WriteLine("Eres el personaje de un juego, tienes la posibilidad de disparar pero primero miremos que tantas municiones tienes");
        int numero;
        Random rnd = new Random();
        numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5 
        Console.WriteLine(numero);
        Console.WriteLine("Inserta I si eres Invencible");
        char letra = Console.ReadLine()[0];
        if (letra == 'i' && numero > 1)
        {
            Console.WriteLine($"El jugador está disparando");
        }
        else
        {
            Console.WriteLine($"Pailas, vuelva a compilar el codigo");
        }
    }
}