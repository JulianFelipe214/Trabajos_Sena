using System;

class Condicionales
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese el número de llantas que desea comprar:");
        int numeroLlantas = Convert.ToInt32(Console.ReadLine());


        double precioUnitario;

        if (numeroLlantas < 6)
        {
            precioUnitario = 240000;
        }
        else if (numeroLlantas == 6 || numeroLlantas == 7)
        {
            precioUnitario = 221000;
        }
        else
        {
            precioUnitario = 180000;
        }

        // Calcular el valor total a pagar
        double totalPagar = precioUnitario * numeroLlantas;

        // Mostrar el valor total a pagar
        Console.WriteLine($"El valor total a pagar por {numeroLlantas} llantas es: ${totalPagar:N0}");
    }
}
