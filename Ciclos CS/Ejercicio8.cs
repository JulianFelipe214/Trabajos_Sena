using System;

class Ciclos
{
    static void Main()
    {
        int num = 1; 
        for (int i = 1; i <= 4; i++)  
        {
            for (int j = 1; j <= 4 - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(num + " ");
                num++;
            }

            Console.WriteLine();
        }
    }
}
