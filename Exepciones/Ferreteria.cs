using System;
using System.Globalization;
class ProgramFerreteria
{
    public static void Ferreteria()
    {
        try
        {
            Console.Write("Ingrese la fecha de entrega (formato dd/MM/yyyy): ");
            string entrada = Console.ReadLine();

            DateTime fechaEntrega = DateTime.ParseExact(entrada,"dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.WriteLine($"Fecha de entrega registrada correctamente: {fechaEntrega:dd/MM/yyyy}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Formato inválido. Use exactamente dd/MM/yyyy (ej. 05/09/2025).");
            Console.WriteLine($"[LOG] Error: {ex.Message}");
        }
    }
}
