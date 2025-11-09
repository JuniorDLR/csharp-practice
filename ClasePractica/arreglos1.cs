using System;
public class RepasoArreglosUnidimensionales
    {
       public  static void Practica()
        {
        const int MAX = 5;
        string[] nombres = new string[MAX];
        double[] notas = new double[MAX];
        bool encontrado = false;
        int contador = 0;
        int opcion;


        do {
            Console.WriteLine("1.Ingresar estudiantes.");
            Console.WriteLine("2.Mostrar todos los registros .");
            Console.WriteLine("3.Buscar un estudiante por nombre..");
            Console.WriteLine("4.Actualizar la nota de un estudiante.");
            Console.WriteLine("5.Borrar un registro.");
            Console.WriteLine("6.Salir.");

           opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre: ");
                    nombres[contador]=Console.ReadLine();
                    Console.Write("Ingrese la nota: ");
                    notas[contador] =Convert.ToDouble(Console.ReadLine());
                    contador++;

                    break;

                case 2:
                    Console.WriteLine("Estudiantes registrados: ");
                    for (int i = 0; i < MAX; i++)
                    {
                        if (nombres[i]!=null )
                        {
                            Console.WriteLine($"Nombre: {nombres[i]}");
                            Console.WriteLine($"Notas: {notas[i]}");
                        }
                    }

                    break;  
                case 3:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string nombre = Console.ReadLine();

                    for (int i = 0; i < MAX; i++)
                    {
                        if (nombres[i] == nombre)
                        {
                            Console.WriteLine("Se a encontrado al estudiante. ");
                            Console.WriteLine($"Nombre: {nombres[i]}");
                            Console.WriteLine($"Notas: {notas[i]}"); break;


                        }
                        else
                        {
                            Console.WriteLine("Estudiante no encontrado.");break;
                        }
                    }

                    break; 
                case 4:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string modificar = Console.ReadLine();

                    for (int i = 0; i < MAX; i++)
                    {
                        if (nombres[i] == modificar)
                        {
                            Console.Write("Ingres el nuevo nombre: ");
                            nombres[i] = Console.ReadLine();
                            break;
    
                           

                        }
                    }
                    break;
                case 5:
                    Console.Write("Ingrese el nombre a buscar: ");
                    string borrar = Console.ReadLine();

                    for (int i = 0; i < MAX; i++)
                    {
                        if (nombres[i] == borrar)
                        {

                            nombres[i] = null;
                            notas[i] = 0.0;
                            break;



                        }
                    }
                    break;
                case 6:
                    Console.WriteLine("Saliendo del programa........");
                    break;
                default: 
                    Console.WriteLine("opcion no valida");
                    break;
            }
        } while (opcion!=6);
 

    }
}

