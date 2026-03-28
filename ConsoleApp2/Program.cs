using System;
using System.Collections.Generic;

class Ejercicio2
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();

        pila.Push(1);
        pila.Push(2);
        pila.Push(3);

        Console.WriteLine("Eliminando elementos:");

        while (pila.Count > 0)
        {
            Console.WriteLine("Eliminado: " + pila.Pop());
        }

        Console.WriteLine("La pila está vacía.");
    }
}