using System;
public class Program
{
    static void Main(string[] args)
    {
        int num1 = 0; //coordenada 1 en x
        int num2 = 0; //coordenada 1 en y
        int num3 = 0; //coordenada 2 en x
        int num4 = 0; //coordenada 2 en y
        int num5 = 0; //coordenada 3 en x
        int num6 = 0; //coordenada 3 en y

        Console.WriteLine("Ingrese la coordenada 1 en x");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la coordenada 1 en y");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la coordenada 2 en x");
        num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la coordenada 2 en y");
        num4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la coordenada 3 en x");
        num5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la coordenada 3 en y");
        num6 = Convert.ToInt32(Console.ReadLine());
        //operación de la ecuación es entre coordenada 1 y coordenada 2

        int num7 = num3 - num1;
        int num8 = num7 * num7;
        int num9 = num4 - num2;
        int num10 = num9 * num9;
        int num11 = num8 + num10;
        double raiz = Math.Sqrt(num11);
        Console.WriteLine($"El resultado de la distancia entre la coordenada 1 y 2 es:{raiz}");
        //operación de la ecuación entre la coordenada 2 y 3
        int num12 = num5 - num3;
        int num13 = num12 * num12;
        int num14 = num6 - num4;
        int num15 = num14 * num14;
        int num16 = num13 + num15;
        double raiz1 = Math.Sqrt(num16);
        Console.WriteLine($"El resultado de la distancia entre la coordenada 2 y 3 es:{raiz1}");
        //operación de la ecuación entre la coordenada 3 y 1
        int num17 = num5 - num1;
        int num18 = num17 * num17;
        int num19 = num6 - num2;
        int num20 = num19 * num19;
        int num21 = num18 + num20;
        double raiz2 = Math.Sqrt(num21);
        Console.WriteLine($"El resultado de la distancia entre la coordenada 1 y 3 es:{raiz2}");
        //Comprobación de que es un triángulo
        Console.WriteLine($"Los numeros de la coordenada 1 son: ({num1},{num2})");
        Console.WriteLine($"Los numeros de la coordenada 2 son: ({num3},{num4})");
        Console.WriteLine($"Los numeros de la coordenada 3 son: ({num5},{num6})");
        Console.WriteLine($"Las condiciones que hay para identificar un triangulo, son que ninguna de las distancias puede dar cero, y que la suma de que dos distancias no puede dar la distancia restante, teniendo eso en cuenta deducimos que:");
        if (raiz == 0 || raiz1 == 0 || raiz2 == 0)
        {
            Console.WriteLine($"En base a las coordenadas dadas anteriormente se puede deducir que no es un triangulo");
        }
        else
        {
            if (raiz + raiz1 == raiz2 || raiz1 + raiz == raiz2 || raiz2 + raiz1 == raiz)
            {
                //Verdadero
                Console.WriteLine($"En base a las coordenadas dadas anteriormente se puede deducir que no es un triángulo");
            }
            else
            {
                Console.WriteLine($"En base a las coordenadas dadas anteriormente se puede deducir que es un triángulo");
            }
        }
    }

}
