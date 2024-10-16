using System;

class Condicionales
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa tu nombre:");
        string nombre = Console.ReadLine();
        
        Console.WriteLine("Ingresa tu edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad < 0 || edad > 100)
        {
            Console.WriteLine("Por favor, ingresa una edad válida.");
        }
        else if (edad >= 18)
        {
            Console.WriteLine($"{nombre}, usted es mayor de edad.");
        }
        else
        {
            Console.WriteLine($"{nombre}, usted es menor de edad.");
        }
    }
}
