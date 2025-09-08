using System;

public class Metodos
{
    // Método estático sin parámetros y sin retorno
    public static void Saludar()
    {
        Console.WriteLine("Hola desde un método estático!");
    }

    // Método estático con parámetros y sin retorno
    public static void SaludarPersona(string nombre)
    {
        Console.WriteLine($"Hola, {nombre}!");
    }

    // Método estático con parámetros y retorno
    public static int Sumar(int a, int b)
    {
        return a + b;
    }

    // Sobrecarga de métodos (mismo nombre, diferentes parámetros)
    public static int Sumar(int a, int b, int c)
    {
        return a + b + c;
    }

    public static double Sumar(double a, double b)
    {
        return a + b;
    }

    // Método de instancia (necesita crear objeto)
    public void Despedir(string nombre)
    {
        Console.WriteLine($"Adiós, {nombre}!");
    }

    // Ejemplo de uso
    public static void Ejemplos()
    {
        // Llamadas a métodos estáticos
        Saludar();
        SaludarPersona("Juan");

        int suma1 = Sumar(5, 10);
        int suma2 = Sumar(1, 2, 3);
        double suma3 = Sumar(2.5, 3.7);

        Console.WriteLine($"Suma 5 + 10 = {suma1}");
        Console.WriteLine($"Suma 1 + 2 + 3 = {suma2}");
        Console.WriteLine($"Suma 2.5 + 3.7 = {suma3}");

        // Llamada a método de instancia
        Metodos obj = new Metodos();
        obj.Despedir("Ana");
    }
}
