using System;
using System.Collections.Generic;

class Pila
{
    public static void Practica()
    {
        string expresion = "(a + b) * (c + d)";

      
        Stack<char> pila = new Stack<char>();

        bool balanceada = true; 

        foreach (char c in expresion)
        {
            if (c == '(')
            {
                pila.Push(c); 
            }
            else if (c == ')')
            {
                if (pila.Count == 0)
                {
                
                    balanceada = false;
                    break;
                }
                pila.Pop(); 
            }
        }

        if (balanceada && pila.Count == 0)
        {
            Console.WriteLine("Los paréntesis están balanceados.");
        }
        else
        {
            Console.WriteLine(" Los paréntesis NO están balanceados.");
        }
    }
}
