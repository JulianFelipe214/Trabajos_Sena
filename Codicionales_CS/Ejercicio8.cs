using System;

class Condicionales
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingresa el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingresa el tercer número:");
        int num3 = Convert.ToInt32(Console.ReadLine());

   
        int[] numeros = { num1, num2, num3 };


        Array.Sort(numeros);

  
        Console.WriteLine("Números en orden ascendente:");
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

  
        Console.WriteLine("Números en orden descendente:");
        for (int i = numeros.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}
