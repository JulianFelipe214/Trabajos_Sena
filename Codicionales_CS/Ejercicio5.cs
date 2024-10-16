using System;

class Condicionales
{
    static void Main(string[] args)
    {
        double[] notas = new double[5];
        double suma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Ingresa la nota {i + 1} (de 0.0 a 5.0):");
            notas[i] = Convert.ToDouble(Console.ReadLine());

            while (notas[i] < 0.0 || notas[i] > 5.0)
            {
                Console.WriteLine("Por favor, ingresa una nota válida (entre 0.0 y 5.0):");
                notas[i] = Convert.ToDouble(Console.ReadLine());
            }

            suma += notas[i];
        }

        double promedio = suma / 5;

        Console.WriteLine($"El promedio de las notas es: {promedio:F2}");

        if (promedio >= 3.0)
        {
            Console.WriteLine("Aprobó.");
        }
        else
        {
            Console.WriteLine("No aprobó.");
        }
    }
}
