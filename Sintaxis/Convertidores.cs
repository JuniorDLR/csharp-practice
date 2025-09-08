using System;

public class Convertidores
{
    public static void Ejemplos()
    {
        // Convert
        int numeroInt = Convert.ToInt32("123");
        double numeroDouble = Convert.ToDouble("123.45");
        string numeroStr = Convert.ToString(789);

        Console.WriteLine($"Convert.ToInt32: {numeroInt}");
        Console.WriteLine($"Convert.ToDouble: {numeroDouble}");
        Console.WriteLine($"Convert.ToString: {numeroStr}");

        // Parse
        int edad = int.Parse("25");
        double precio = double.Parse("99.99");

        Console.WriteLine($"int.Parse: {edad}");
        Console.WriteLine($"double.Parse: {precio}");

        // TryParse
        string entrada = "50";
        if (int.TryParse(entrada, out int resultado))
        {
            Console.WriteLine($"int.TryParse exitoso: {resultado}");
        }
        else
        {
            Console.WriteLine("int.TryParse fallido");
        }

        // Ejemplo dinámico con TryParse
        string entradaFail = "abc";
        if (double.TryParse(entradaFail, out double resultadoFail))
        {
            Console.WriteLine($"double.TryParse exitoso: {resultadoFail}");
        }
        else
        {
            Console.WriteLine("double.TryParse fallido");
        }
    }
}
