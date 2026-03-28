using System;
using System.Collections.Generic;

class Ejercicio3
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();

        pila.Push(5);
        pila.Push(10);
        pila.Push(15);

        // Eliminar 2 elementos
        pila.Pop();
        pila.Pop();

        Console.WriteLine("Estado final de la pila:");

        foreach (int num in pila)
        {
            Console.WriteLine(num);
        }
    }
}