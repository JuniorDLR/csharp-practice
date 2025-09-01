using System;

public class Actividad3
{
    public static void Ejercicios()
    {
        while (true)
        {
            Console.WriteLine("\n--- Menu Principal ---");
            Console.WriteLine("1. Calculadora");
            Console.WriteLine("2. Mensaje personalizado");
            Console.WriteLine("3. Area de un rectangulo");
            Console.WriteLine("4. Salir");
            Console.Write("Opcion: ");
            string? opcion = Console.ReadLine();
            int convertOption;

            if (IsNull(opcion))
            {
                Console.WriteLine("El valor no puede quedar vacio!");
                continue;
            }
            try
            {
                convertOption = Convert.ToInt32(opcion);
            }
            catch
            {
                Console.WriteLine("Debes de ingresar un numero valido!");
                continue;
            }

            switch (convertOption)
            {
                case 1:
                    Calculadora();
                    break;
                case 2:
                    MensajePersonalizado();
                    break;
                case 3:
                    AreaRectangulo();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción no valida!");
                    break;
            }
        }
    }

    public static bool IsNull(string? opcion)
    {
        return string.IsNullOrEmpty(opcion);
    }

    public static void AreaRectangulo()
    {
        Console.Write("Ingresa la base: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa la altura: ");
        double h = Convert.ToDouble(Console.ReadLine());

        double area = b * h;
        Console.WriteLine($"El área del rectángulo es: {area}");
    }

    public static void Calculadora()
    {
        while (true)
        {
            Console.WriteLine("\n--- Calculadora ---");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Regresar al menú principal");

            Console.Write("Opcion: ");
            string? opcion = Console.ReadLine();
            int convertOption;

            if (IsNull(opcion))
            {
                Console.WriteLine("El valor no puede quedar vacio!");
                continue;
            }

            try
            {
                convertOption = Convert.ToInt32(opcion);
            }
            catch
            {
                Console.WriteLine("Debes de ingresar un numero valido!");
                continue;
            }

            switch (convertOption)
            {
                case 1:
                    Console.WriteLine($"Resultado: {Operation('S')}");
                    break;
                case 2:
                    Console.WriteLine($"Resultado: {Operation('R')}");
                    break;
                case 3:
                    Console.WriteLine($"Resultado: {Operation('M')}");
                    break;
                case 4:
                    Console.WriteLine($"Resultado: {Operation('D')}");
                    break;
                case 5:
                    return; 
                default:
                    Console.WriteLine("Opción no valida!");
                    continue;
            }
        }
    }

    public static double Operation(char op)
    {
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        switch (op)
        {
            case 'S':
                return num1 + num2;
            case 'R':
                return num1 - num2;
            case 'M':
                return num1 * num2;
            case 'D':
                if (num2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre 0");
                    return 0.0;
                }
                return num1 / num2;
            default:
                Console.WriteLine("Operación invalida!");
                return 0.0;
        }
    }

    public static void MensajePersonalizado()
    {
        Console.Write("Escribe un nombre: ");
        string? nombre = Console.ReadLine();

        if (string.IsNullOrEmpty(nombre))
        {
            Console.WriteLine("Error: Campo vacio!");
        }
        else
        {
            Console.WriteLine($"Hola {nombre}!");
        }
    }
}
