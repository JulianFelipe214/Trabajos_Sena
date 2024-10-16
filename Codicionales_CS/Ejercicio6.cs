using System;

class Condicionales
{
    static void Main(string[] args)
    {
        int opcion;
        double resultado = 0; 

        do
        {
            Console.WriteLine("Seleccione la figura geométrica:");
            Console.WriteLine("1. Rectángulo");
            Console.WriteLine("2. Cuadrado");

            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    resultado = CalcularAreaRectangulo();
                    break;
                case 2:
                    resultado = CalcularAreaCuadrado();
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }


            if (opcion == 1 || opcion == 2) 
            {
                Console.WriteLine("El área es: " + resultado);
            }

        } while (opcion != 0);
    }

    static double CalcularAreaRectangulo()
    {
        Console.Write("Ingrese la base del rectángulo: ");
        double baseRectangulo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura del rectángulo: ");
        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());   

        return baseRectangulo * alturaRectangulo;
    }

    static double CalcularAreaCuadrado()
    {
        Console.Write("Ingrese el lado del cuadrado: ");
        double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

        return ladoCuadrado * ladoCuadrado;
    }

}
