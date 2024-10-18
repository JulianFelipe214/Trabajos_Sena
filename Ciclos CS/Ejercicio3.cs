using System;

class Ciclos
{
    static void Main()
    {
        Console.Write("Ingrese el número de términos de la serie Fibonacci: ");
        int n = int.Parse(Console.ReadLine());

        int primero = 0, segundo = 1, siguiente, suma = 0;

        Console.WriteLine("Los primeros " + n + " términos de la serie Fibonacci son:");

        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write(primero + " ");
                suma += primero;
                continue;
            }
            if (i == 2)
            {
                Console.Write(segundo + " ");
                suma += segundo;
                continue;
            }
            siguiente = primero + segundo;
            Console.Write(siguiente + " ");
            suma += siguiente;
            primero = segundo;
            segundo = siguiente;
        }
        Console.WriteLine("\nLa suma de los primeros " + n + " términos de la serie Fibonacci es: " + suma);
    }
}
