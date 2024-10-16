using System;

class Condicionales
{
    static void Main(string[] args)
    {
        int opcion;
        double temperatura, resultado;

        do
        {
            Console.WriteLine("Conversor de Temperaturas");
            Console.WriteLine("1. Fahrenheit a Celsius");
            Console.WriteLine("2. Fahrenheit a Kelvin");
            Console.WriteLine("0. Salir"); 
            Console.Write("Opción: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcion))
            {
                Console.WriteLine("Por favor, ingresa una opción válida.");
                continue; 
            }

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la temperatura en Fahrenheit: ");
                    
                    if (!double.TryParse(Console.ReadLine(), out temperatura))
                    {
                        Console.WriteLine("Por favor, ingresa una temperatura válida.");
                        break;
                    }

                    resultado = (temperatura - 32) / 1.8;
                    Console.WriteLine($"La temperatura en Celsius es: {resultado:F2}");
                    break;

                case 2:
                    Console.Write("Ingrese la temperatura en Fahrenheit: ");
                    
                    if (!double.TryParse(Console.ReadLine(), out temperatura))
                    {
                        Console.WriteLine("Por favor, ingresa una temperatura válida.");
                        break;
                    }

                    resultado = (temperatura - 32) / 1.8 + 273.15;
                    Console.WriteLine($"La temperatura en Kelvin es: {resultado:F2}");
                    break;

                case 0:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

        } while (opcion != 0); 
    }
}
