using System;

class Condicionales
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingresa el monto de la cuenta:");
        double cuenta = Convert.ToDouble(Console.ReadLine());


        if (cuenta < 150000)
        {
            Console.WriteLine("Método de pago: Efectivo");
        }
        else if (cuenta >= 150000 && cuenta <= 300000)
        {
            Console.WriteLine("Método de pago: Dinero electrónico (celular)");
        }
        else if (cuenta > 300000 && cuenta <= 600000)
        {
            Console.WriteLine("Método de pago: Tarjeta de débito");
        }
        else if (cuenta > 600000)
        {
            Console.WriteLine("Método de pago: Tarjeta de crédito");
        }
    }
}
