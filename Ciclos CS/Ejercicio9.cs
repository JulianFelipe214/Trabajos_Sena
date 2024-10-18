using System;

class Ciclos
{
    static void Main()
    {
        Console.Write("Ingrese un número para calcular su factorial: ");
        int numero = int.Parse(Console.ReadLine());

        long factorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            factorial *= i; 
        }

        Console.WriteLine("El factorial de " + numero + " es: " + factorial);
    }
}
