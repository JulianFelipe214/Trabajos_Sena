using System;

class Condicionales
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese la cantidad de artículos que desea comprar: ");
        int cantidadArticulos = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el precio unitario de cada artículo: ");
        double precioUnitario = Convert.ToDouble(Console.ReadLine());

        double descuento = 0;

        if (cantidadArticulos > 5 && cantidadArticulos < 10)
        {
            descuento = 0.05; 
        }
        else if (cantidadArticulos >= 10)
        {
            descuento = 0.08;  
        }

        double precioTotal = cantidadArticulos * precioUnitario * (1 - descuento);

        Console.WriteLine($"El total a pagar por {cantidadArticulos} artículo(s) es: ${precioTotal:N2}");
    }
}
