using System;

class Ciclos
{
    static void Main()
    {
        Console.Write("Ingrese un número entero para mostrar su tabla de multiplicar: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("\nTabla de multiplicar del " + numero + ":");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(numero + " x " + i + " = " + (numero * i));
        }
    }
}
