using System;



public class Actividad7()
{
    public static void Promedio()
    {
        int cantidad = 5;
        List<double> notas = new List<double>();

        for (int i = 1; i <= cantidad; i++)
        {
            Console.Write($"Ingrese la nota {i}: ");
            string? input = Console.ReadLine();

            if (double.TryParse(input, out double nota))
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Entrada invalida, se agregara 0");
                notas.Add(0);
            }
        }

        Console.WriteLine("\nNotas ingresadas:");
        double promedio = 0.0;
        foreach (var n in notas)
        {
            Console.WriteLine(n);
            promedio += n;
        }
        Console.WriteLine($"Promedio: {promedio / cantidad}");
    }


    public static void Municipales()
    {
        string[] municipales = ["El viejo", "Corinto", "Somotillo", "Chichigalpa"];
        //var lista = new List<string>() { "A","B","C"};
        foreach (var m in municipales)
        {
            Console.WriteLine($"Proyectos de agua ejecutando en: {m}");
        }
    }

    public static void Inventario()
    {
        int quintales = 50;

        while (quintales > 0)
        {
            Console.WriteLine($"\nQuintales disponibles: {quintales}");
            Console.Write("Ingrese la cantidad de quintales que desea comprar: ");
            int compra;


            if (!int.TryParse(Console.ReadLine(), out compra) || compra <= 0)
            {
                Console.WriteLine("Debe ingresar un número válido mayor a 0.");
                continue;
            }


            if (compra > quintales)
            {
                Console.WriteLine("No hay suficientes quintales disponibles.");
                continue;
            }

            quintales -= compra;
            Console.WriteLine($"Has comprado {compra} quintales. Te quedan {quintales}.");

            Console.Write("¿Desea comprar más? (S/N): ");
            string? condicion = Console.ReadLine();

            if (string.IsNullOrEmpty(condicion) || condicion.ToUpper() == "N")
            {
                Console.WriteLine("Gracias por su compra.");
                break;
            }
        }

        if (quintales == 0)
        {
            Console.WriteLine("Se acabaron los quintales.");
        }
    }


public static void RegistroPagos()
{
    decimal pago;       
    decimal total = 0;  

    do
    {
        Console.Write("Ingrese el monto del pago (0 para salir): ");
        
        if (!decimal.TryParse(Console.ReadLine(), out pago) || pago < 0)
        {
            Console.WriteLine("Por favor ingrese un monto válido (número positivo o 0).");
            pago = -1; 
            continue;
        }

        if (pago > 0)
        {
            total += pago;
            Console.WriteLine($"Pago registrado: {pago:C}. Total acumulado: {total:C}");
        }

    } while (pago != 0); 

    Console.WriteLine($"\nRegistro finalizado. Total acumulado: {total:C}");
}


}