using System;
public static class Productos
{
    static string nombre;
    static int cantidad;
    static int PrecioU;
    static double subtotal;
    static double impuesto;
    static double total;
    static int repeticiones;

    static void Practica()
    {
        Console.Write("Cuantos productos comprará?: ");
        repeticiones = int.Parse(Console.ReadLine());
        for (int i = 1; i <= repeticiones; i++)
        {
            EntradaDatos();
            Calculos();
            Impresion();
        }

    }

    public static void EntradaDatos()
    {
        Console.Write("Escriba el nombre del producto: ");
        nombre = Console.ReadLine();
        Console.Write("Ingrese la cantidad: ");
        cantidad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio unitario: ");
        PrecioU = int.Parse(Console.ReadLine());

    }
    public static void Calculos()
    {
        subtotal = cantidad * PrecioU;
        impuesto = subtotal * 0.15;
        total = subtotal + impuesto;
    }
    public static void Impresion()
    {
        Console.WriteLine("Factura de ventas\n");
        Console.WriteLine($"Nombre del pruducto: {nombre}");
        Console.WriteLine($"Cantidad de productos: {cantidad}");
        Console.WriteLine($"Precio Unitario: {PrecioU}");
        Console.WriteLine($"Impuesto: 0.15%");
        Console.WriteLine($"Subtotal: {subtotal}");
        Console.WriteLine($"Total: {total}");
    }
}