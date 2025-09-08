using System;

public class ProgramFacturacion
{
    public static void Facturacion()
    {
        try
        {
            Console.Write("Ingrese la cantidad (entero): ");
            int cantidad = int.Parse(Console.ReadLine()); 

            Console.Write("Ingrese el precio unitario (decimal): ");
            decimal precioUnitario = decimal.Parse(Console.ReadLine()); 

            decimal subtotal = cantidad * precioUnitario;
            decimal iva = 0.15m * subtotal;
            decimal total = subtotal + iva;

            Console.WriteLine($"Subtotal: C${subtotal:F2}");
            Console.WriteLine($"IVA (15%): C${iva:F2}");
            Console.WriteLine($"Total: C${total:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Use solo números (ej. 10 o 199.99).");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Número demasiado grande. Intente con valores más pequeños.");
        }
    }
}
