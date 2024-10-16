using System;

class Program
{
    static void Main(string[] args)
    {
        double peso, estatura, imc;

        Console.Write("Ingrese su peso en kilogramos: ");
        while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
        {
            Console.Write("Por favor ingrese un valor válido para el peso (número positivo): ");
        }

        Console.Write("Ingrese su estatura en metros: ");
        while (!double.TryParse(Console.ReadLine(), out estatura) || estatura <= 0)
        {
            Console.Write("Por favor ingrese un valor válido para la estatura (número positivo): ");
        }

        imc = peso / (estatura * estatura);

        string estado;
        if (imc < 18.5)
        {
            estado = "Desnutrido";
        }
        else if (imc >= 18.5 && imc < 25)
        {
            estado = "Normal";
        }
        else if (imc >= 25 && imc < 30)
        {
            estado = "Sobrepeso";
        }
        else if (imc >= 30 && imc < 35)
        {
            estado = "Obesidad Grado 1";
        }
        else if (imc >= 35 && imc < 40)
        {
            estado = "Obesidad Grado 2";
        }
        else if (imc >= 40 && imc < 50)
        {
            estado = "Obesidad Grado 3";
        }
        else
        {
            estado = "Obesidad Grado 4";
        }

        Console.WriteLine("Tu IMC es: " + imc.ToString("F2"));
        Console.WriteLine("Tu estado de peso es: " + estado);
    }
}
