using System;

class Arreglos
{
    public static void Practica()
    {   
        int opcion;

        do
        {
            Console.WriteLine("1. Captura y impresion de valores por teclado");
            Console.WriteLine("2. Inicializacion de arreglo e impresión");
            Console.WriteLine("3. Estadisticas de notas de estudiantes");
            Console.WriteLine("4. Salir");
            Console.Write("Elija una opcion: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    ArreglosValores();
                    break;
                case 2:
                    Inicializacion();
                    break;
                case 3:
                    Estadisticas();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Número inválido [X]");
                    break;
            }

        } while (opcion != 4);
    }

    static void ArreglosValores()
    {
        int[] valores = new int[3];
        Console.WriteLine("Ha seleccionado captura e impresión de datos.\n");

        for (int i = 0; i < valores.Length; i++)  
        {
            Console.Write($"Digite el valor {i + 1}: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nLista de valores capturados:");
        for (int i = 0; i < valores.Length; i++)  
        {
            Console.WriteLine($"Número {i + 1}: {valores[i]}");
        }
    }

    static void Inicializacion()
    {
        int[] arreglo = new int[3] { 5, 15, 50 };

        Console.WriteLine("\nLista de valores inicializados:");
        for (int i = 0; i < arreglo.Length; i++)  
        {
            Console.WriteLine($"Número {i + 1}: {arreglo[i]}");
        }
    }

    static void Estadisticas()
    {
        double[] estadistica = new double[3];
        double promedio = 0, suma = 0, notamax = 0, notamin = 0;

        Console.WriteLine("Estadísticas de las notas de los estudiantes:");

        for (int i = 0; i < estadistica.Length; i++)  
        {
            Console.Write($"Ingrese la nota {i + 1}: ");
            estadistica[i] = Convert.ToDouble(Console.ReadLine());
            suma += estadistica[i];
        }

        Console.WriteLine("\nImpresión de notas:");
        for (int i = 0; i < estadistica.Length; i++)  
        {
            Console.WriteLine($"Nota {i + 1}: {estadistica[i]}");
        }

        promedio = suma / estadistica.Length;
        notamax = estadistica[0];
        notamin = estadistica[0];

        for (int i = 0; i < estadistica.Length; i++)
        {
            if (estadistica[i] > notamax)
            {
                notamax = estadistica[i];
            }
            else if (estadistica[i] < notamin)
            {
                notamin = estadistica[i];
            }
        }

        Console.WriteLine($"\nNota promedio: {promedio}");
        Console.WriteLine($"Nota máxima: {notamax}");
        Console.WriteLine($"Nota mínima: {notamin}");
    }
}