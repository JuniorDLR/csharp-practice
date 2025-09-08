using System;

public class ManejoExcepciones
{
    public static void ExceptionPractice()
    {
        string nombre;
        int whatsapp;
        
        try
        {
            Console.Write("Ingrese el nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese número de whatsapp: ");
            whatsapp = int.Parse(Console.ReadLine());
            
            //Tratar el NULL
            if (string.IsNullOrWhiteSpace(nombre))
            {
                nombre = null;
            }
            
            //Normalizar
            string nombreN = nombre.ToUpper().Trim();
            int nombreL = nombreN.Length;
            
            
            Console.WriteLine($"Nombre: {nombreN}");
            Console.WriteLine($"Longitud del nombre: {nombreL}");
            Console.WriteLine($"Whatsapp: {whatsapp}");
        }
        
        catch (NullReferenceException)
        {
            Console.WriteLine("El nombre no puede quedar vacío");
        }
        finally
        {
            Console.WriteLine("Programa Finalizado");
        } 
    }
}