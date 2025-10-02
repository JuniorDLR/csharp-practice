public class Modularidad
{
    public static void IMC()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("----Calculadora de IMC----");
        Console.WriteLine("--------------------------\n");

        double peso = SolicitarDato("Ingrese su peso (kg): ");
        double altura = SolicitarDato("Ingrese su altura (m): ");

        double imc = CalcularImc(peso, altura);

        Console.WriteLine($"Su IMC es de: {imc:F2}");
        ClasificarImc(imc);
    }

    private static double SolicitarDato(string mensaje)
    {
        double valor = 0;
        bool valido;

        do
        {
            Console.Write(mensaje);
            string? input = Console.ReadLine();

            if (input == null)
            {
                Console.WriteLine("La entrada no puede ser nula. Intente de nuevo.");
                valido = false;
                continue;
            }

            valido = double.TryParse(input, out valor) && valor > 0;

            if (!valido)
            {
                Console.WriteLine("Número inválido: Ingrese un número positivo");
            }

        } while (!valido);

        return valor;
    }

    private static double CalcularImc(double peso, double altura)
    {
        return peso / (altura * altura);
    }

    private static void ClasificarImc(double imc)
    {
        switch (imc)
        {
            case double n when n < 18.5:
                Console.WriteLine("Clasificación: Bajo peso");
                break;

            case double n when n < 25:
                Console.WriteLine("Clasificación: Peso normal");
                break;

            case double n when n < 30:
                Console.WriteLine("Clasificación: Sobrepeso");
                break;

            default:
                Console.WriteLine("Clasificación: Obesidad");
                break;
        }
    }
}
