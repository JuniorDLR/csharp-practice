using System;

public class Bidimencionales
{
   public  static void Practica()
    {

        int filas;
        int columnas;

        Console.WriteLine("--- Creador de Matrices ---");
        
 
        Console.Write("Ingrese el número de filas que desea: ");
        filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de columnas que desea: ");
        columnas = int.Parse(Console.ReadLine());

 
        int[,] matriz = new int[filas, columnas];

        Console.WriteLine($"\nPor favor, ingrese los valores para la matriz de {filas}x{columnas}:");

        for (int i = 0; i < filas; i++) 
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write($"Ingrese el valor para la posición [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

      
        Console.WriteLine("\nLa matriz que ingresaste es:");
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}