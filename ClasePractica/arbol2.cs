using System;

public class ArbolBinario
{
    public class Nodo
    {
        public string Nombre;
        public Nodo? Izquierdo;
        public Nodo? Derecho;

        public Nodo(string nombre)
        {
            Nombre = nombre;
        }
    }

    public Nodo? Raiz;

    public ArbolBinario()
    {
        Raiz = null;
    }
}


public class ArbolMain
{
    public static void ArbolPractica()
    {
        ArbolBinario arbol = new ArbolBinario();
        bool salir = true;

        while (salir)
        {
            Console.WriteLine("=== Directorios de estudiantes ===");
            Console.WriteLine("1.Insertar estudiantes");
            Console.WriteLine("2.Buscar estudiantes");
            Console.WriteLine("3.Mostrar nombres (P reorden)");
            Console.WriteLine("4.Mostrar nombres (Inorden)");
            Console.WriteLine("5.Mostrar nombres (Postrden)");
            Console.WriteLine("6.Verificar el arbol vacio");
            Console.WriteLine("7.Salir");
            Console.Write("Elige una opcion: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Insertar(arbol);
                    break;

                case 2:
                    BuscarEstudiantes(arbol);
                    break;

                case 3:
                    MostrarPreOrden(arbol);
                    break;

                case 4:
                    MostrarInOrden(arbol);
                    break;

                case 5:
                    MostrarPostOrden(arbol);
                    break;

                case 6:
                    VerificarArbolVacio(arbol);
                    break;

                case 7:
                    Console.WriteLine("Saliendo del programa...");
                    salir = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }

        }

    }

    public static void BuscarEstudiantes(ArbolBinario arbol)
    {
        if (arbol.Raiz == null)
        {
            Console.WriteLine("No se puede realizar la busqueda por que el arbol esta vacio!");
            return;
        }

        while (true)
        {
            Console.Write("Ingrese el nombre a buscar: ");
            string? nombreBuscar = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(nombreBuscar))
            {
                Console.WriteLine("Nombre vacio!");
                continue;
            }
            bool encontrado = EncontrarNombre(nombreBuscar, arbol.Raiz);

            Console.WriteLine(encontrado ? "Nombre encontrado" : "Nombre no encontrado");
            break;

        }
    }

    public static bool EncontrarNombre(string nombreBuscar, ArbolBinario.Nodo? actual)
    {
        if (actual == null)
            return false;

        int resultado = string.Compare(nombreBuscar, actual.Nombre, true);

        if (resultado == 0)
            return true;
        else if (resultado < 0)
            return EncontrarNombre(nombreBuscar, actual.Izquierdo);
        else
            return EncontrarNombre(nombreBuscar, actual.Derecho);
    }

    public static void MostrarPreOrden(ArbolBinario arbol)
    {
        if (arbol.Raiz == null)
        {
            Console.WriteLine("El árbol está vacío.");
            return;
        }
        PreOrden(arbol.Raiz);
    }

    private static void PreOrden(ArbolBinario.Nodo? actual)
    {
        if (actual == null) return;

        Console.WriteLine(actual.Nombre);    // Raíz
        PreOrden(actual.Izquierdo);          // Izquierda
        PreOrden(actual.Derecho);            //  Derecha
    }


    public static void MostrarInOrden(ArbolBinario arbol)
    {
        if (arbol.Raiz == null)
        {
            Console.WriteLine("El árbol está vacío.");
            return;
        }
        InOrden(arbol.Raiz);
    }

    private static void InOrden(ArbolBinario.Nodo? actual)
    {
        if (actual == null) return;

        InOrden(actual.Izquierdo);           // Izquierda
        Console.WriteLine(actual.Nombre);    // Raíz
        InOrden(actual.Derecho);             // Derecha
    }


    public static void MostrarPostOrden(ArbolBinario arbol)
    {
        if (arbol.Raiz == null)
        {
            Console.WriteLine("El árbol está vacío.");
            return;
        }
        PostOrden(arbol.Raiz);
    }

    private static void PostOrden(ArbolBinario.Nodo? actual)
    {
        if (actual == null) return;

        PostOrden(actual.Izquierdo);         // Izquierda
        PostOrden(actual.Derecho);           // Derecha
        Console.WriteLine(actual.Nombre);    // Raíz
    }


    public static void VerificarArbolVacio(ArbolBinario arbol)
    {
        Console.WriteLine(arbol.Raiz == null ? "El arbol esta vacio" : "El arbol tiene datos");
    }
    public static void Insertar(ArbolBinario arbol)
    {
        Console.WriteLine("\n=== Registro de Estudiantes ===");
        Console.Write("Ingrese un nombre: ");
        string? nombre = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nombre))
        {
            Console.WriteLine("Nombre vacío, intente de nuevo.");
            return;
        }

        if (arbol.Raiz == null)
        {
            arbol.Raiz = new ArbolBinario.Nodo(nombre);
            Console.WriteLine($"'{nombre}' agregado como raíz del árbol.");
            return;
        }
        else
        {
            InsertarRecursivo(arbol.Raiz, nombre);
            return;
        }
    }


    private static void InsertarRecursivo(ArbolBinario.Nodo actual, string nombre)
    {
        int resultado = string.Compare(nombre, actual.Nombre, true);

        if (resultado < 0)
        {

            if (actual.Izquierdo == null)
            {
                actual.Izquierdo = new ArbolBinario.Nodo(nombre);
                Console.WriteLine($"'{nombre}' agregado a la izquierda de '{actual.Nombre}'.");
            }
            else
            {
                InsertarRecursivo(actual.Izquierdo, nombre);
            }
        }
        else if (resultado > 0)
        {

            if (actual.Derecho == null)
            {
                actual.Derecho = new ArbolBinario.Nodo(nombre);
                Console.WriteLine($"'{nombre}' agregado a la derecha de '{actual.Nombre}'.");
            }
            else
            {
                InsertarRecursivo(actual.Derecho, nombre);
            }
        }
        else
        {
            Console.WriteLine($"El nombre '{nombre}' ya existe en el árbol.");

        }
    }
}
