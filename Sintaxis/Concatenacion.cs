using System;

public class Concatenacion
{
    public static void Ejemplos()
    {
        string nombre = "Juan";
        int edad = 25;

        // 1. Concatenación con +
        string mensaje1 = "Hola " + nombre + ", tienes " + edad + " años.";
        Console.WriteLine(mensaje1);

        // 2. Interpolación de cadenas ($)
        string mensaje2 = $"Hola {nombre}, tienes {edad} años.";
        Console.WriteLine(mensaje2);

        // 3. String.Format
        string mensaje3 = string.Format("Hola {0}, tienes {1} años.", nombre, edad);
        Console.WriteLine(mensaje3);

        // 4. Concat de la clase String
        string mensaje4 = string.Concat("Hola ", nombre, ", tienes ", edad, " años.");
        Console.WriteLine(mensaje4);

        // 5. StringBuilder (útil para muchas concatenaciones)
        var sb = new System.Text.StringBuilder();
        sb.Append("Hola ");
        sb.Append(nombre);
        sb.Append(", tienes ");
        sb.Append(edad);
        sb.Append(" años.");
        Console.WriteLine(sb.ToString());
    }
}
