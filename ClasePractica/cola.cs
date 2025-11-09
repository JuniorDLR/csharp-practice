using System;
using System.Collections.Generic;
using System.Linq;

namespace BancoUniversitario
{
    class Estudiante
    {
        public int Turno { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public string Tramite { get; set; }

        public override string ToString()
        {
            return $"Turno: {Turno} | Nombre: {Nombre} | Carrera: {Carrera} | Trámite: {Tramite}";
        }
    }

    class Program
    {
        static Queue<Estudiante> cola = new Queue<Estudiante>();
        static int contadorTurnos = 1;

        public static void Practica()
        {
            int opcion;
            do
            {
                MostrarMenu();
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("\nIngrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        RegistrarEstudiante();
                        break;
                    case 2:
                        AtenderEstudiante();
                        break;
                    case 3:
                        MostrarSiguiente();
                        break;
                    case 4:
                        MostrarCantidad();
                        break;
                    case 5:
                        MostrarCola();
                        break;
                    case 6:
                        VaciarCola();
                        break;
                    case 7:
                        BuscarPorNombre();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

            } while (opcion != 0);
        }

        static void MostrarMenu()
        {
            Console.WriteLine("===== BANCO UNIVERSITARIO =====");
            Console.WriteLine("1. Registrar estudiante (Enqueue)");
            Console.WriteLine("2. Atender estudiante (Dequeue)");
            Console.WriteLine("3. Ver próximo estudiante (Peek)");
            Console.WriteLine("4. Consultar cantidad en cola (Count)");
            Console.WriteLine("5. Mostrar todos en espera");
            Console.WriteLine("6. Vaciar cola");
            Console.WriteLine("7. Buscar estudiante por nombre");
            Console.WriteLine("0. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void RegistrarEstudiante()
        {
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la carrera: ");
            string carrera = Console.ReadLine();
            Console.Write("Ingrese el trámite: ");
            string tramite = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(carrera) ||
                string.IsNullOrWhiteSpace(tramite))
            {
                Console.WriteLine("Todos los campos son obligatorios.");
                return;
            }

            Estudiante nuevo = new Estudiante
            {
                Turno = contadorTurnos++,
                Nombre = nombre.Trim(),
                Carrera = carrera.Trim(),
                Tramite = tramite.Trim()
            };

            cola.Enqueue(nuevo);
            Console.WriteLine($"\nEstudiante registrado con éxito. Su turno es: {nuevo.Turno}");
        }

        static void AtenderEstudiante()
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("No hay estudiantes en la cola.");
                return;
            }

            Estudiante atendido = cola.Dequeue();
            Console.WriteLine($"\nAtendiendo a: {atendido}");
        }

        static void MostrarSiguiente()
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("No hay estudiantes en la cola.");
                return;
            }

            Estudiante siguiente = cola.Peek();
            Console.WriteLine($"\nPróximo estudiante: {siguiente}");
        }

        static void MostrarCantidad()
        {
            Console.WriteLine($"\nEstudiantes en espera: {cola.Count}");
        }

        static void MostrarCola()
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("No hay estudiantes en la cola.");
                return;
            }

            Console.WriteLine("\nLista de estudiantes en espera:");
            foreach (var estudiante in cola)
            {
                Console.WriteLine(estudiante);
            }
        }

        static void VaciarCola()
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("La cola ya está vacía.");
                return;
            }

            cola.Clear();
            Console.WriteLine("Cola vaciada correctamente.");
        }

        static void BuscarPorNombre()
        {
            if (cola.Count == 0)
            {
                Console.WriteLine("No hay estudiantes en la cola.");
                return;
            }

            Console.Write("Ingrese el nombre a buscar: ");
            string nombreBuscar = Console.ReadLine().Trim();

            var resultado = cola.FirstOrDefault(e => e.Nombre.Equals(nombreBuscar, StringComparison.OrdinalIgnoreCase));

            if (resultado != null)
            {
                Console.WriteLine($"\nEstudiante encontrado: {resultado}");
            }
            else
            {
                Console.WriteLine("No se encontró ningún estudiante con ese nombre.");
            }
        }
    }
}
