using System;

public class TiposDeDatos
{
    public static void ImprimirTipos()
    {
        // Enteros
        byte edadByte = 25;
        sbyte tempSB = -100;
        short anioShort = 2025;
        ushort distUS = 50000;
        int edadInt = 30;
        uint puntosUI = 4000;
        long poblacionL = 8000000000;
        ulong estrellasUL = 100000000000;

        // Decimales
        float piF = 3.14f;
        double piD = 3.14159265359;
        decimal saldoDec = 1500.75m;

        // Texto y caracteres
        char letraC = 'J';
        string nombreStr = "Junior";

        // Booleanos
        bool logueadoB = true;
        bool activoB = false;

        // Nullables
        int? edadNull = null;

        // Inferencia y dinámico
        var ciudadVar = "Managua";
        dynamic valorDyn = 25;

        // Object
        object objO = "Soy un objeto";

        // Impresión
        Console.WriteLine($"byte: {edadByte}");
        Console.WriteLine($"sbyte: {tempSB}");
        Console.WriteLine($"short: {anioShort}");
        Console.WriteLine($"ushort: {distUS}");
        Console.WriteLine($"int: {edadInt}");
        Console.WriteLine($"uint: {puntosUI}");
        Console.WriteLine($"long: {poblacionL}");
        Console.WriteLine($"ulong: {estrellasUL}");
        Console.WriteLine($"float: {piF}");
        Console.WriteLine($"double: {piD}");
        Console.WriteLine($"decimal: {saldoDec}");
        Console.WriteLine($"char: {letraC}");
        Console.WriteLine($"string: {nombreStr}");
        Console.WriteLine($"bool (true): {logueadoB}");
        Console.WriteLine($"bool (false): {activoB}");
        Console.WriteLine($"nullable int: {edadNull}");
        Console.WriteLine($"var: {ciudadVar}");
        Console.WriteLine($"dynamic: {valorDyn}");
        Console.WriteLine($"object: {objO}");
    }
}
