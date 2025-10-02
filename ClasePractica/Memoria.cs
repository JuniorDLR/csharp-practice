using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
class Memoria
{
    public static void Practica()
    {
        string nombre = "";
        int cantidad = 0;
        double PrecioU = 0;
        double impuesto = 0;
        double valorimpuesto, subtotal, total;
        LeerDato(ref nombre, ref cantidad, ref PrecioU, ref impuesto);
        CalculoFactura(cantidad, PrecioU, impuesto, out valorimpuesto, out subtotal, out total);
        MostrarFactura( nombre,  cantidad,  PrecioU,  subtotal,  valorimpuesto,  total);
    }
    static void LeerDato(ref string nombre, ref int cantidad, ref double PrecioU, ref double impuesto)
    {
        Console.Write("Nombre: ");
        nombre = Console.ReadLine();
        Console.Write("Cantidad: ");
        cantidad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Precio Unitario: ");
        PrecioU = Convert.ToDouble(Console.ReadLine());
        Console.Write("Impuesto: ");
        impuesto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\n");
        
    }
    static void CalculoFactura(int cantidad, double PrecioU, double impuesto, out double valorimpuesto, out double subtotal, out double total)
    {
        subtotal = cantidad * PrecioU;
        valorimpuesto = subtotal * (impuesto / 100);
        total = subtotal + valorimpuesto; 
    }
    static void MostrarFactura(string nombre, int cantidad, double PrecioU, double subtotal, double valorimpuesto, double total)
    {
        Console.WriteLine("*** FACTURA ***");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine($"Precio Unitario: {PrecioU}");
        Console.WriteLine($"Subtotal: {subtotal}");
        Console.WriteLine($"Valor impuesto: {valorimpuesto}");
        Console.WriteLine($"Total: {total}");
    }
}