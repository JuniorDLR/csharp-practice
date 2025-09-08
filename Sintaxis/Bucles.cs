using System;

public class Bucles
{
    public static void Ejemplos()
    {
        // 1. Bucle for
        Console.WriteLine("Bucle for:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"i = {i}");
        }

        // 2. Bucle foreach (ideal para colecciones)
        Console.WriteLine("\nBucle foreach:");
        string[] nombres = { "Juan", "Ana", "Luis" };
        foreach (var nombre in nombres)
        {
            Console.WriteLine(nombre);
        }

        // 3. Bucle while
        Console.WriteLine("\nBucle while:");
        int contadorWhile = 0;
        while (contadorWhile < 3)
        {
            Console.WriteLine($"contadorWhile = {contadorWhile}");
            contadorWhile++;
        }

        // 4. Bucle do-while (se ejecuta al menos una vez)
        Console.WriteLine("\nBucle do-while:");
        int contadorDo = 0;
        do
        {
            Console.WriteLine($"contadorDo = {contadorDo}");
            contadorDo++;
        } while (contadorDo < 3);

        // 5. Bucle anidado (for dentro de for)
        Console.WriteLine("\nBucle anidado:");
        for (int fila = 1; fila <= 3; fila++)
        {
            for (int col = 1; col <= 2; col++)
            {
                Console.WriteLine($"Fila {fila}, Columna {col}");
            }
        }
    }
}
