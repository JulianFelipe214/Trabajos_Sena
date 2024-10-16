using System;

class Program
{
    static void Main(string[] args)
    {
        int edad, genero;
        double pulsaciones;

        Console.Write("Ingrese su edad: ");
        edad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese su género (1 para femenino, 2 para masculino): ");
        genero = Convert.ToInt32(Console.ReadLine());

        if (genero != 1 && genero != 2)
        {
            Console.WriteLine("Opción de género inválida.");
            return;
        }

        if (genero == 1)
        {

            pulsaciones = (220 - edad) / 10.0;
        }
        else
        {

            pulsaciones = (210 - edad) / 10.0;
        }

        Console.WriteLine($"El número de pulsaciones por cada 10 segundos de ejercicio es: {pulsaciones:F2}");
    }
}
