using System;

class Ciclos
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 20; i++)
        {
            suma += i;
        }
        Console.WriteLine("La suma de los primeros 20 números naturales es: " + suma);
    }
}
