using System;
using System.Collections.Generic;

class ProgramaVentas
{
    static string[] vendedores = new string[3];    
    static double[,] ventas = new double[3, 3];    
    static Queue<double> colaTotales = new Queue<double>(); 

    static void Practica()
    {
        RegistrarDatos();   
        MostrarResumen();  
    }

    static void RegistrarDatos()
    {
        Console.WriteLine("=== REGISTRO DE VENTAS ===\n");

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Ingrese el nombre del vendedor {i + 1}: ");
            vendedores[i] = Console.ReadLine();

            Console.WriteLine($"Ingrese las ventas mensuales de {vendedores[i]}:");

            for (int j = 0; j < 3; j++)
            {
                Console.Write($"  Mes {j + 1}: ");
                ventas[i, j] = double.Parse(Console.ReadLine());
            }

            double total = CalcularTotal(i);
            colaTotales.Enqueue(total);
            Console.WriteLine();
        }
    }


    static double CalcularTotal(int fila)
    {
        double total = 0;
        for (int j = 0; j < 3; j++)
        {
            total += ventas[fila, j];
        }
        return total;
    }
    static void MostrarResumen()
    {
        Console.WriteLine("=== RESUMEN DE VENTAS ===\n");
        double totalGeneral = 0;
        int index = 0;

        foreach (double total in colaTotales)
        {
            Console.WriteLine($"Vendedor: {vendedores[index]}");
            Console.Write("Ventas: ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{ventas[index, j]}  ");
            }
            Console.WriteLine($"\nTotal vendido: {total}\n");
            totalGeneral += total;
            index++;
        }

        Console.WriteLine($"TOTAL GENERAL DEL TRIMESTRE: {totalGeneral}\n");

        Console.WriteLine("=== CONTENIDO DE LA COLA ===");
        foreach (double t in colaTotales)
        {
            Console.WriteLine($"Total en cola: {t}");
        }
    }
}
