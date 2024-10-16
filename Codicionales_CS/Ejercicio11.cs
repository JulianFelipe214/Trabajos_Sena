using System;

class Condicionales
{
    static void Main(string[] args)
    {
     
        Console.WriteLine("Seleccione el tamaño de la pizza:");
        Console.WriteLine("1. Pequeña ($15,000)");
        Console.WriteLine("2. Mediana ($24,000)");
        Console.WriteLine("3. Grande ($36,000)");
        Console.Write("Ingrese el número correspondiente al tamaño de la pizza: ");
        int tamañoPizza = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el número de ingredientes adicionales: ");
        int ingredientesAdicionales = Convert.ToInt32(Console.ReadLine());

       
        int precioBase;

        switch (tamañoPizza)
        {
            case 1:
                precioBase = 15000;
                break;
            case 2:
                precioBase = 24000;
                break;
            case 3:
                precioBase = 36000;
                break;
            default:
                Console.WriteLine("Opción inválida. El tamaño ingresado no existe.");
                return; 
        }
      
        int precioAdicional = ingredientesAdicionales * 4000;

        int precioTotal = precioBase + precioAdicional;

        Console.WriteLine($"El precio total a pagar por la pizza es: ${precioTotal:N0}");
    }
}
