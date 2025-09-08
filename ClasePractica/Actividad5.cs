using System;

public class Actividad5
{
    public static void Ejercicios()
    {

        Console.Write("Ingresa un número: ");
        if (!int.TryParse(Console.ReadLine(), out int numero))
        {
            Console.WriteLine("Entrada inválida");
        }
        else
        {
            if (numero > 0)
                Console.WriteLine("El número es positivo.");
            else if (numero < 0)
                Console.WriteLine("El número es negativo.");
            else
                Console.WriteLine("El número es cero.");
        }

    
        Console.Write("\nIngresa un número del 1 al 7 para el día de la semana: ");
        if (!int.TryParse(Console.ReadLine(), out int dia))
        {
            Console.WriteLine("Entrada inválida");
        }
        else
        {
            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                case 4: Console.WriteLine("Jueves"); break;
                case 5: Console.WriteLine("Viernes"); break;
                case 6: Console.WriteLine("Sábado"); break;
                case 7: Console.WriteLine("Domingo"); break;
                default: Console.WriteLine("Número fuera de rango"); break;
            }
        }


        Console.Write("\nIngresa la calificación del estudiante (0-100): ");
        if (!double.TryParse(Console.ReadLine(), out double calificacion))
        {
            Console.WriteLine("Entrada inválida");
        }
        else
        {
            if (calificacion >= 70)
                Console.WriteLine("Aprobado");
            else if (calificacion >= 50)
                Console.WriteLine("Recuperación");
            else
                Console.WriteLine("Reprobado");
        }

    
        int calInt = (int)calificacion; //Conversion implicita cast
        switch (calInt)
        {
            case >= 70 and <= 100:
                Console.WriteLine("Aprobado");
                break;
            case >= 50 and <= 69:
                Console.WriteLine("Recuperación");
                break;
            case >= 0 and <= 49:
                Console.WriteLine("Reprobado");
                break;
            default:
                Console.WriteLine("Calificación fuera de rango");
                break;
        }
    }
}
