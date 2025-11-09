using System;
using System.IO.Compression;

public struct Estudiante
{
    public string Nombre;
    public int edad;
    public double nota;

}
internal class ArreglosBii
{
    public static void Practica()
    {
        int cantidad;
        Console.Write("Ingrese el numero de estudiantes a registrar: ");
        cantidad = Convert.ToInt32(Console.ReadLine());
        Estudiante[] estudiante = new Estudiante[cantidad];

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Nombre: ");
            estudiante[i].Nombre = Console.ReadLine()!;
            Console.Write("edad: ");
            int edad1 = Convert.ToInt32(Console.ReadLine());

            if (edad1 > 0 || edad1 < 100)
            {
                estudiante[i].edad = edad1;
            }

            else
            {
                Console.WriteLine("Edad fuera del rango");
            }

            Console.Write("Notas: ");
            estudiante[i].nota = Convert.ToDouble(Console.ReadLine());
        }

        Console.WriteLine("Lista de estudiantes\n");

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Nombre: {estudiante[i].Nombre} ");
            Console.WriteLine($"Edad: {estudiante[i].edad} ");
            Console.WriteLine($"Nota: {estudiante[i].nota:F2} ");
        }

        Console.WriteLine("Modificaciones de un estudiante\n");

        Console.Write("Ingrese el nombre del estudiante: ");
        string Nom = Console.ReadLine()!;
        bool encontrado = false;

        for (int i = 0; i < cantidad; i++)
        {
            if (estudiante[i].Nombre.ToLower() == Nom.ToLower())
            {
                Console.Write("Ingrese el nuevo nombre: ");
                estudiante[i].Nombre = Console.ReadLine()!;
                encontrado = true;
            }
        }
        if (!encontrado)
        {
            Console.WriteLine("Estudiante no encontrado");
        }


        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Nombre: {estudiante[i].Nombre} ");
            Console.WriteLine($"Edad: {estudiante[i].edad} ");
            Console.WriteLine($"Nota: {estudiante[i].nota:F2} \n");
        }


        Console.WriteLine("Eliminación de un estudiante\n");

        Console.Write("Ingrese el nombre del estudiante: ");
        string Nom1 = Console.ReadLine()!;
        bool encontrado1 = false;

        for (int i = 0; i < cantidad; i++)
        {
            if (estudiante[i].Nombre.ToLower() == Nom1.ToLower())
            {
                for (int j = i; j < cantidad - 1; j++)
                {
                    estudiante[j] = estudiante[j + 1];
                }
                cantidad--;
                encontrado1 = true; 
                break;
            }
        }
        if (!encontrado1)
        {
            Console.WriteLine("Estudiante no encontrado");
        }


        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Nombre: {estudiante[i].Nombre} ");
            Console.WriteLine($"Edad: {estudiante[i].edad} ");
            Console.WriteLine($"Nota: {estudiante[i].nota:F2} \n");
        }
    }
}