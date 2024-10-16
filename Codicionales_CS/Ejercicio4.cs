using System;

class Condicionales
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa el primer número:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine($"El número mayor es: {numero1} y el número menor es: {numero2}");
        }
        else if (numero1 < numero2)
        {
            Console.WriteLine($"El número mayor es: {numero2} y el número menor es: {numero1}");
        }
        else
        {
            Console.WriteLine("Ambos números son iguales.");
        }
    }
}
