using System;

public class Condicionales
{
    public static void Ejemplos()
    {
        int edad = 25;
        bool esEstudiante = true;

        // 1. if
        if (edad >= 18)
        {
            Console.WriteLine("Eres mayor de edad.");
        }

        // 2. if-else
        if (esEstudiante)
        {
            Console.WriteLine("Eres estudiante.");
        }
        else
        {
            Console.WriteLine("No eres estudiante.");
        }

        // 3. if-else if-else
        if (edad < 18)
        {
            Console.WriteLine("Menor de edad.");
        }
        else if (edad >= 18 && edad < 65)
        {
            Console.WriteLine("Adulto.");
        }
        else
        {
            Console.WriteLine("Adulto mayor.");
        }

        // 4. Operadores lógicos
        int nota = 85;
        if (nota >= 70 && esEstudiante)
        {
            Console.WriteLine("Aprobaste el curso.");
        }

        if (nota < 70 || !esEstudiante)
        {
            Console.WriteLine("No aprobaste o no eres estudiante.");
        }

        // 5. switch
        int dia = 3;
        switch (dia)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            case 4:
                Console.WriteLine("Jueves");
                break;
            case 5:
                Console.WriteLine("Viernes");
                break;
            default:
                Console.WriteLine("Fin de semana");
                break;
        }
    }
}
