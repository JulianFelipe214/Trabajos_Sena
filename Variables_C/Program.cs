using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            // Mostrar el menú de opciones
            Console.WriteLine("Seleccione un ejercicio (1-14) o 0 para salir:");
            Console.WriteLine("1. Multiplicar 3 números");
            Console.WriteLine("2. Calcular el cuadrado de un número");
            Console.WriteLine("3. Calcular la distancia recorrida");
            Console.WriteLine("4. Calcular la edad");
            Console.WriteLine("5. Calcular el 20% de un número");
            Console.WriteLine("6. Calcular el 30%, 60% y 90%");
            Console.WriteLine("7. Calcular el área de un cuadrado");
            Console.WriteLine("8. Calcular el promedio de 5 números");
            Console.WriteLine("9. Calcular el valor total con IVA");
            Console.WriteLine("10. Calcular el salario a pagar a un empleado");
            Console.WriteLine("11. Calcular la raíz cuadrada sin función");
            Console.WriteLine("12. Calcular la hipotenusa con el Teorema de Pitágoras");
            Console.WriteLine("13. Transformar tiempo en segundos a horas y minutos");
            Console.WriteLine("14. Transformar distancia en metros a km, cm y mm");
            Console.Write("Opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    MultiplicarTresNumeros();
                    break;
                case 2:
                    CalcularCuadrado();
                    break;
                case 3:
                    CalcularDistancia();
                    break;
                case 4:
                    CalcularEdad();
                    break;
                case 5:
                    CalcularVeintePorciento();
                    break;
                case 6:
                    CalcularPorcentajes();
                    break;
                case 7:
                    CalcularAreaCuadrado();
                    break;
                case 8:
                    CalcularPromedio();
                    break;
                case 9:
                    CalcularValorConIVA();
                    break;
                case 10:
                    CalcularSalarioEmpleado();
                    break;
                case 11:
                    CalcularRaizCuadrada();
                    break;
                case 12:
                    CalcularHipotenusa();
                    break;
                case 13:
                    TransformarTiempo();
                    break;
                case 14:
                    TransformarDistancia();
                    break;
                case 0:
                    Console.WriteLine("Saliendo...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.\n");
                    break;
            }
        } while (opcion != 0);
    }

    // Ejercicio 1: Multiplicar 3 números
    static void MultiplicarTresNumeros()
    {
        Console.WriteLine("Ejercicio 1: Multiplicar 3 números");
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el tercer número: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        double producto = num1 * num2 * num3;
        Console.WriteLine($"El producto es: {producto}\n");
    }

    // Ejercicio 2: Calcular el cuadrado de un número
    static void CalcularCuadrado()
    {
        Console.WriteLine("Ejercicio 2: Calcular el cuadrado de un número");
        Console.Write("Ingrese un número: ");
        double numero = Convert.ToDouble(Console.ReadLine());
        double cuadrado = numero * numero;
        Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}\n");
    }

    // Ejercicio 3: Calcular la distancia recorrida
    static void CalcularDistancia()
    {
        Console.WriteLine("Ejercicio 3: Calcular la distancia recorrida");
        Console.Write("Ingrese la velocidad (km/h): ");
        double velocidad = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el tiempo (h): ");
        double tiempo = Convert.ToDouble(Console.ReadLine());
        double distancia = velocidad * tiempo;
        Console.WriteLine($"La distancia recorrida es: {distancia} km\n");
    }

    // Ejercicio 4: Calcular la edad
    static void CalcularEdad()
    {
        Console.WriteLine("Ejercicio 4: Calcular la edad");
        Console.Write("Ingrese el año actual: ");
        int añoActual = Convert.ToInt32(Console.ReadLine());
        Console.Write("Ingrese su año de nacimiento: ");
        int añoNacimiento = Convert.ToInt32(Console.ReadLine());
        int edad = añoActual - añoNacimiento;
        Console.WriteLine($"Su edad es: {edad} años\n");
    }

    // Ejercicio 5: Calcular el 20% de un número
    static void CalcularVeintePorciento()
    {
        Console.WriteLine("Ejercicio 5: Calcular el 20% de un número");
        Console.Write("Ingrese un número: ");
        double numero20 = Convert.ToDouble(Console.ReadLine());
        double veintePorciento = numero20 * 0.20;
        Console.WriteLine($"El 20% de {numero20} es: {veintePorciento}\n");
    }

    // Ejercicio 6: Calcular el 30%, 60% y 90%
    static void CalcularPorcentajes()
    {
        Console.WriteLine("Ejercicio 6: Calcular el 30%, 60% y 90%");
        Console.Write("Ingrese un número: ");
        double numeroPorcentaje = Convert.ToDouble(Console.ReadLine());
        double treintaPorciento = numeroPorcentaje * 0.30;
        double sesentaPorciento = numeroPorcentaje * 0.60;
        double noventaPorciento = numeroPorcentaje * 0.90;
        Console.WriteLine($"30%: {treintaPorciento}, 60%: {sesentaPorciento}, 90%: {noventaPorciento}\n");
    }

    // Ejercicio 7: Calcular el área de un cuadrado
    static void CalcularAreaCuadrado()
    {
        Console.WriteLine("Ejercicio 7: Calcular el área de un cuadrado");
        Console.Write("Ingrese la longitud de un lado: ");
        double lado = Convert.ToDouble(Console.ReadLine());
        double areaCuadrado = lado * lado;
        Console.WriteLine($"El área del cuadrado es: {areaCuadrado}\n");
    }

    // Ejercicio 8: Calcular el promedio de 5 números
    static void CalcularPromedio()
    {
        Console.WriteLine("Ejercicio 8: Calcular el promedio de 5 números");
        double suma = 0;
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            double numeroPromedio = Convert.ToDouble(Console.ReadLine());
            suma += numeroPromedio;
        }
        double promedio = suma / 5;
        Console.WriteLine($"El promedio es: {promedio}\n");
    }

    // Ejercicio 9: Calcular el valor total con IVA
    static void CalcularValorConIVA()
    {
        Console.WriteLine("Ejercicio 9: Calcular el valor total con IVA");
        Console.Write("Ingrese el valor unitario: ");
        double valorUnitario = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la cantidad de productos: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());
        double valorTotal = valorUnitario * cantidad;
        double iva = valorTotal * 0.16;
        double valorFinal = valorTotal + iva;
        Console.WriteLine($"El valor final a pagar es: {valorFinal}\n");
    }

    // Ejercicio 10: Calcular el salario a pagar a un empleado
    static void CalcularSalarioEmpleado()
    {
        Console.WriteLine("Ejercicio 10: Calcular el salario a pagar a un empleado");
        Console.Write("Ingrese el salario diario: ");
        double salarioDiario = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el número de días trabajados: ");
        int diasTrabajados = Convert.ToInt32(Console.ReadLine());
        double salarioBruto = salarioDiario * diasTrabajados;
        double descuentoPension = salarioBruto * 0.10;
        double descuentoSalud = salarioBruto * 0.15;
        double salarioNeto = salarioBruto - (descuentoPension + descuentoSalud);
        Console.WriteLine($"El salario a pagar es: {salarioNeto}\n");
    }

    // Ejercicio 11: Calcular la raíz cuadrada sin función
    static void CalcularRaizCuadrada()
    {
        Console.WriteLine("Ejercicio 11: Calcular la raíz cuadrada sin función");
        Console.Write("Ingrese un número: ");
        double numeroRaiz = Convert.ToDouble(Console.ReadLine());
        double raiz = 0;
        for (double i = 0; i <= numeroRaiz; i += 0.01)
        {
            if (i * i >= numeroRaiz)
            {
                raiz = i;
                break;
            }
        }
        Console.WriteLine($"La raíz cuadrada de {numeroRaiz} es aproximadamente: {raiz}\n");
    }

    // Ejercicio 12: Calcular la hipotenusa con el Teorema de Pitágoras
    static void CalcularHipotenusa()
    {
        Console.WriteLine("Ejercicio 12: Calcular la hipotenusa");
        Console.Write("Ingrese el cateto 1: ");
        double cateto1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el cateto 2: ");
        double cateto2 = Convert.ToDouble(Console.ReadLine());
        double hipotenusa = Math.Sqrt((cateto1 * cateto1) + (cateto2 * cateto2));
        Console.WriteLine($"La hipotenusa es: {hipotenusa}\n");
    }

    // Ejercicio 13: Transformar tiempo en segundos a horas y minutos
    static void TransformarTiempo()
    {
        Console.WriteLine("Ejercicio 13: Transformar tiempo en segundos a horas y minutos");
        Console.Write("Ingrese el tiempo en segundos: ");
        int segundos = Convert.ToInt32(Console.ReadLine());
        int horas = segundos / 3600;
        int minutos = (segundos % 3600) / 60;
        Console.WriteLine($"{segundos} segundos son: {horas} horas y {minutos} minutos\n");
    }

    // Ejercicio 14: Transformar distancia en metros a km, cm y mm
    static void TransformarDistancia()
    {
        Console.WriteLine("Ejercicio 14: Transformar distancia en metros a km, cm y mm");
        Console.Write("Ingrese la distancia en metros: ");
        double distanciaMetros = Convert.ToDouble(Console.ReadLine());
        double distanciaKm = distanciaMetros / 1000;
        double distanciaCm = distanciaMetros * 100;
        double distanciaMm = distanciaMetros * 1000;
        Console.WriteLine($"La distancia es: {distanciaKm} km, {distanciaCm} cm, {distanciaMm} mm\n");
    }
}