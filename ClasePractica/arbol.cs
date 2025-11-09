using System;
using System.Security.Cryptography.X509Certificates;

public class Nodo
{
    public string Nombre;

    public Nodo? Izquierdo;

    public Nodo? Derecho;

    public Nodo(string Nombre)
    {
        this.Nombre = Nombre;
        Izquierdo = null;
        Derecho = null;
    }
}

public class ArbolBinario1
{
    public static void Practica()
    {
        Nodo? raiz = null;

        raiz = Insertar(raiz,"carlos");
        raiz = Insertar(raiz, "Claudio");
        raiz = Insertar(raiz, "Rafael");
        raiz = Insertar(raiz, "Junior");
        raiz = Insertar(raiz, "Neville");
        Console.WriteLine("\nLista en Inorden");
        MostrarInorden(raiz);
        Console.WriteLine("\nLista en Preorden");
        MostrarPreorden(raiz);
        Console.WriteLine("\nLista en Posorden");
        Mostrarposorden(raiz);
    }

    static Nodo Insertar(Nodo? nodo, string Nombre)
    {
        if (nodo == null)
            return new Nodo(Nombre);

        if (string.Compare(Nombre,nodo.Nombre,true) < 0)
            nodo.Izquierdo = Insertar(nodo.Izquierdo, Nombre);
        else if (string.Compare(Nombre,nodo.Nombre, true) > 0)
            nodo.Derecho = Insertar(nodo.Derecho,Nombre);

        return nodo;
    }

    public static void MostrarInorden(Nodo? nodo)
    {
        if (nodo != null)
        {
            MostrarInorden(nodo.Izquierdo);
            Console.WriteLine(nodo.Nombre);
            MostrarInorden(nodo.Derecho);
            
        }
    }

    public static void MostrarPreorden(Nodo? nodo) 
        {
            if (nodo != null)
            {
                Console.WriteLine(nodo.Nombre);
                MostrarPreorden(nodo.Izquierdo);
                MostrarPreorden(nodo.Derecho);
            }
        }


    public static void Mostrarposorden(Nodo? nodo)
    {
        if (nodo != null)
        {

            Mostrarposorden(nodo.Izquierdo);
            Mostrarposorden(nodo.Derecho);
            Console.WriteLine(nodo.Nombre);
        }
    }
}
