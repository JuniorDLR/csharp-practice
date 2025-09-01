using System;



public class Actividad7()
{
    public static void Promedio()
    {
        int cantidad = 5;
        List<double> notas = new List<double>();

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese la nota {i}: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double nota))
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Entrada invalida, se agregara 0");
                notas.Add(0);
            }
        }

        Console.WriteLine("\nNotas ingresadas:");
        double promedio = 0.0;
        foreach (var n in notas)
        {
            Console.WriteLine(n);
            promedio += n;
        }
        Console.WriteLine($"Promedio: {promedio / cantidad}");
    }


    public static void Municipales()
    {
        string[] municipales = ["El viejo", "Corinto", "Somotillo", "Chichigalpa"];
        //var lista = new List<string>() { "A","B","C"};
        foreach (var m in municipales)
        {
            Console.WriteLine($"Proyectos de agua ejecutando en: {m}");
        }
    }
}