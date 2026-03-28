using System;
using System.Collections.Generic;

class Ejercicio1
{
    static void Main()
    {
        Stack<int> pila = new Stack<int>();

        // Agregar 4 números
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);
        pila.Push(40);

        // Mostrar contenido
        Console.WriteLine("Contenido de la pila:");
        foreach (int num in pila)
        {
            Console.WriteLine(num);
        }
    }
}