using System;

class Ciclos
{
    static void Main()
    {
        int suma = 0;
        int numero;
        
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Ingrese el número " + i + ": ");
            numero = int.Parse(Console.ReadLine());
            suma += numero;
        }

        double promedio = (double)suma / 10;

        Console.WriteLine("\nLa suma de los 10 números es: " + suma);
        Console.WriteLine("El promedio de los 10 números es: " + promedio);
    }
}
