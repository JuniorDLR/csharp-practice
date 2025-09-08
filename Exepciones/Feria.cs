using System;

public class ProgramFeria
{
  public  static void Feria()
    {
        try
        {
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el número de WhatsApp: ");
            string whatsapp = Console.ReadLine();

           
            if (string.IsNullOrWhiteSpace(nombre))
            {
                nombre = null;
            }

            // Intentamos normalizar el nombre
            string nombreMayusculas = nombre.ToUpper();  
            int longitudNombre = nombre.Length;       

            Console.WriteLine($"Nombre en mayúsculas: {nombreMayusculas}");
            Console.WriteLine($"Longitud del nombre: {longitudNombre}");
            Console.WriteLine($"WhatsApp: {whatsapp}");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Nombre no proporcionado. No es posible normalizar los datos del cliente.");
            Console.WriteLine($"[LOG] Error: {ex.Message}");
        }
    }
}
