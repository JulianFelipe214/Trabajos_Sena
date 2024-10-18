using System;

class Ciclos
{
    static void Main()
    {
        int filas = 7;  

        for (int i = 1; i <= filas; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();

        for (int i = 1; i <= filas - 2; i++)
        {
            for (int j = 1; j <= filas - i - 1; j++)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            Console.WriteLine();
        }

        for (int i = 1; i <= filas; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}
