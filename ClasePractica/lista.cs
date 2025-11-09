using System;
using System.Collections;
namespace Lista
{
    internal class Miercoles
    {   public static List<string> softwares = new List<string>(){"Visual Studio", "Android Studio", "Netflix"};
        public static void Practica()
        {
            int Opcion;
            do
            {   Console.Clear();
                Console.WriteLine("\nBienvenido al catalogo de softwares universitario\n");
                Console.WriteLine("1. Agregar softwares");
                Console.WriteLine("2. Ver el catalogo de softwares");
                Console.WriteLine("3. Eliminar versiones obsoletas");
                Console.WriteLine("4. Consultar disponibilidad");
                Console.WriteLine("5. Modificar nombre de un programa");
                Console.WriteLine("6. Salir del programa");
                Console.Write("Elige una opcion: ");
                Opcion = Convert.ToInt32(Console.ReadLine());
                switch (Opcion)
                {
                    case 1:
                        Agregar();
                        break;
                    case 2:
                        Visualizar();
                        break;
                    case 3:
                        Eliminar();
                        break;
                    case 4:
                        Consulta_disponibilidad();
                        break;
                    case 5:
                        Modificar();
                        break;
                    case 6:
                        Console.WriteLine("Saliendo del programa");
                        break;
                    default:
                        Console.WriteLine("Ingrese un numero dentro del rango(1-6)");
                        break;
                }
                Console.Write("Precione enter para continuar");
                Console.ReadKey();
            } while (Opcion != 6);
        }
        static void Agregar()
        {
            Console.WriteLine("\nHa selccionado agregar softwares\n");
            Console.Write("Ingrese el sowftware: ");
            string software = Console.ReadLine()!;
            softwares.Add(software);
        }
        
        static void Visualizar()
        {   if (softwares.Count > 0)
            {
                int contador = 1;
                Console.WriteLine("\nHa seleccionado visualziar el catalogo de softwares\n");

                foreach (string software in softwares)
                {
                    Console.WriteLine($"{contador}. {software}");
                    contador += 1;

                }
                Console.WriteLine("");
            }

            else
            {
                Console.WriteLine("\nEl catalogo esta vacio\n");
            }
        }
        static void Eliminar()
        {
            bool encontrado = false;
            Console.WriteLine("\nHa seleccionado eliminar versiones obsoletas\n");
            if (softwares.Count > 0)
            {
                Console.Write("Ingrese el software a eliminar: ");
                string eliminar = Console.ReadLine()!;

                for (int i = 0; i < softwares.Count; i++)
                {
                    if (softwares[i].ToLower() == eliminar.ToLower())
                    {
                        softwares.RemoveAt(i);
                        encontrado = true;
                        Console.WriteLine("[!]Eliminado exitosamente");
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("Software no encontrado");
                }
            }
            else
            {
                Console.WriteLine("\nEl catalogo esta vacio\n");
            }
        }
        static void Modificar()
        {   bool encontrado = false;
            if (softwares.Count > 0)
            {
                Console.WriteLine("\nHa seleccionado modificar un nombre\n");
                Console.Write("Ingrese el nombre del software: ");
                string software = Console.ReadLine()!;
                for (int i = 0; i < softwares.Count; i++)
                {
                    if (softwares[i].ToLower() == software.ToLower())
                    {
                        Console.Write("Ingrese el nuevo nombre: ");
                        string modificar = Console.ReadLine()!;
                        softwares[i] = modificar;
                        encontrado = true;
                        Console.WriteLine("[!] Modificado exitosamente");
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("Software no encontrado");
                }
            }
            else
            {
                Console.WriteLine("Catalogo vacio");
            }
        }
        static void Consulta_disponibilidad()
        {
            Console.WriteLine("\nHa seleccionado Consultar disponibilidad\n");
            bool encontrado = false;
            if (softwares.Count > 0)
            {
                Console.Write("Ingrese el nombre del software: ");
                string software = Console.ReadLine()!;
                for (int i = 0; i < softwares.Count; i++)
                {
                    if (softwares[i].ToLower() == software.ToLower())
                    {
                        Console.WriteLine($"El programa {software} esta disponible");
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine($"El software {software} no esta disponible");
                }
            }
            else
            {
                Console.WriteLine("Catalogo vacio");
            }
        }
    }
}