using System;

class Errores()
{
    public static void Ejercicio()
    {
        int nota1, nota2, nota3;
        Console.WriteLine("Ingrese la primera nota: ");
        nota1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota: ");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota: ");
        nota3 = Convert.ToInt32(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3) / 3;
        Console.WriteLine("El promedio es: " + promedio);

    }

    public static void Producto()
    {
        Console.WriteLine("Ingrese el precio del producto: ");
        string? precio = Console.ReadLine();
        double totalDouble = Convert.ToDouble(precio);
        double total = totalDouble * 1.15;
        Console.WriteLine("Total con IVA: " + total);


    }

    public static void Factorial()
    {
        Console.WriteLine("Ingrese un numero: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int factorial = 0;
        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;

        }
        Console.WriteLine("El factorial es: " + factorial);
    }

    public static void Edad()
    {
        Console.WriteLine("Ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }
    }

    public static void NumeroPI()
    {
        Console.WriteLine("Ingrese un numero: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("El numero es par");
        }
        else
        {
            Console.WriteLine("El numero es impar");
        }
    }

    public static void Rectangulo()
    {
        Console.Write("Ingrese el largo: ");
        double ancho = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el ancho: ");
        double largo = Convert.ToDouble(Console.ReadLine());


        double area = ancho * largo;

        Console.WriteLine("El area del rectangulo es: " + area);

    }
}