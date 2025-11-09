using System;

public class Estudiantes
{
    public static void Notas()
    {
        int estudiantes = 4;
        int evaluaciones = 3;
        double[,] notas = new double[estudiantes, evaluaciones];
        double[] promedios = new double[estudiantes];

  
        for (int i = 0; i < estudiantes; i++)
        {
            Console.WriteLine($"\nNotas del estudiante {i + 1}:");

            for (int j = 0; j < evaluaciones; j++)
            {
                Console.Write($"Ingrese la nota de la evaluación {j + 1}: ");
                notas[i, j] = Convert.ToDouble(Console.ReadLine());
            }
        }

        Console.WriteLine("\n--- Resultados ---\n");
        double sumaGeneral = 0;


        for (int i = 0; i < estudiantes; i++)
        {
            double sumaNotas = 0;

            for (int j = 0; j < evaluaciones; j++)
            {
                sumaNotas += notas[i, j];
            }

            promedios[i] = sumaNotas / evaluaciones;
            double promedioEstudiante = promedios[i];
            sumaGeneral += promedioEstudiante;

            Console.WriteLine($"El promedio del estudiante {i + 1} es: {promedioEstudiante:F2}");
        }


        double promedioGrupo = sumaGeneral / estudiantes;
        Console.WriteLine($"\nEl promedio del grupo es: {promedioGrupo:F2}");
    }
}
