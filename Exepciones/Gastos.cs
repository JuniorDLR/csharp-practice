using System;

class ProgramGastos
{
    public static void Gastos()
    {
        Console.Write("Ingrese el costo total (C$): ");
        double costoTotal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el número de participantes: ");
        int participantes = Convert.ToInt32(Console.ReadLine());
        try
        {

            if (participantes == 0)
            {
                throw new DivideByZeroException();
            }

            double costoPorPersona = costoTotal / participantes;
            Console.WriteLine($"El costo por persona es: C${costoPorPersona}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("No hay participantes confirmados. Actualice la lista antes de calcular.");
            Console.WriteLine($"[LOG] Error: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada inválida. Por favor ingrese solo números.");
        }
    }
}
