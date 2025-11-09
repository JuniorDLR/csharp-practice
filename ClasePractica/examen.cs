using System;
using System.Collections.Generic;

public class Examen
{

    public struct Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
    }

    public static void Practica()
    {
        List<string> encabezado = new List<string>() { "nombre", "apellido", "edad" };
        List<Persona> personas = new List<Persona>();

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"\nDatos de la persona {i + 1}");
            Persona persona = new Persona();

            foreach (var enca in encabezado)
            {
                if (enca == "nombre")
                {
                    string input;
                    do
                    {
                        Console.Write($"Ingrese su {enca}: ");
                        input = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(input))
                            Console.WriteLine("El nombre no puede estar vacío");
                    } while (string.IsNullOrWhiteSpace(input));

                    persona.nombre = input;
                }
                else if (enca == "apellido")
                {
                    string input;
                    do
                    {
                        Console.Write($"Ingrese su {enca}: ");
                        input = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(input))
                            Console.WriteLine("El apellido no puede estar vacío");
                    } while (string.IsNullOrWhiteSpace(input));

                    persona.apellido = input;
                }
                else // edad
                {
                    int edad;
                    do
                    {
                        Console.Write($"Ingrese su {enca}: ");
                        string input = Console.ReadLine();
                        if (!int.TryParse(input, out edad) || edad <= 0)
                            Console.WriteLine("Edad inválida, debe ser un número positivo");
                        else
                            break;
                    } while (true);

                    persona.edad = edad;
                }
            }

            personas.Add(persona);
        }

        Console.WriteLine("\n--- Mostrando datos ---");
        foreach (var per in personas)
        {
            Console.WriteLine($"Nombre: {per.nombre}, Apellido: {per.apellido}, Edad: {per.edad}");
        }
    }


}
