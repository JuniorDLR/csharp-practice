using System;
using System.Data;

public class Examen2
{
    public static List<Persona> personas = new List<Persona>();
    public struct Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }

    }
    public static void Practica()
    {

        bool salir = false;
        int opcion;

        while (!salir)
        {
            Console.WriteLine("1.Agregar persona");
            Console.WriteLine("2.Mostrar personas");
            Console.WriteLine("3.Eliminar persona");
            Console.WriteLine("4.Editar persona");
            Console.WriteLine("5.Salir");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    AgregarPersona(personas);
                    break;
                case 2:
                    MostrarPersonas(personas);
                    break;
                case 3:
                    EliminarPersona(personas);
                    break;
                case 4:
                    EditarPersona(personas);
                    break;
                case 5:
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

        }

    }


     static void MostrarPersonas(List<Persona> lista)
    {
        Console.WriteLine("\n--- Lista de personas ---");
        if (lista.Count == 0)
        {
            Console.WriteLine("No hay personas registradas.");
            return;
        }

        for (int i = 0; i < lista.Count; i++)
        {
            var p = lista[i];
            Console.WriteLine($"{i + 1}. {p.nombre} {p.apellido}, {p.edad} años");
        }
    }

    public static void EliminarPersona(List<Persona> personas)
    {

    }

    public static void EditarPersona(List<Persona> personas)
    {

    }

    public static void AgregarPersona(List<Persona> personas)
    {
        List<string> encabezado = new List<string>() { "nombre", "apellido", "edad" };
        Persona persona = new Persona();

        foreach (var enca in encabezado)
        {

            if (enca == "nombre")
            {
                string input;
                do
                {
                    Console.WriteLine($"Ingrese su {enca}");
                    input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        Console.WriteLine("EL CAMPO NO PUEDE QUEDAR VACIO!");
                } while (string.IsNullOrWhiteSpace(input));
                persona.nombre = input;
            }
            else if (enca == "apellido")
            {

                string input;
                do
                {
                    Console.WriteLine($"Ingrese su {enca}");
                    input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input))
                        Console.WriteLine("EL CAMPO NO PUEDE QUEDAR VACIO!");
                } while (string.IsNullOrWhiteSpace(input));
                persona.apellido = input;
            }
            else
            {
                int edad;
                do
                {
                    string input;
                    Console.WriteLine("Ingrese su edad: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out edad) || edad <= 0)
                    {
                        Console.WriteLine("Edad invalida, debe de ser numero positivo");
                    }
                    else
                    {
                        persona.edad = edad;
                        break;
                    }


                } while (true);
            }

         
        }
        personas.Add(persona);
        Console.WriteLine("DATOS GUARDADO EXITOSAMENTE!");


    }


}