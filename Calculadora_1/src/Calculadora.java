import java.util.Scanner;
//permite usar la clase Scanner para leer entradas del usuario desde la consola.

public class Calculadora {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        //para capturar las entradas del usuario.
        
        //Menu de opciones para la calculadora
        System.out.println("Bienvenido a la calculadora.");
        System.out.println("Elige una operación:");
        System.out.println("1. Sumar");
        System.out.println("2. Restar");
        System.out.println("3. Multiplicar");
        System.out.println("4. Dividir");
        
        
        int opcion = scanner.nextInt();

        System.out.println("Introduce el primer número: ");
        double num1 = scanner.nextDouble();
        
        System.out.println("Introduce el segundo número: ");
        double num2 = scanner.nextDouble();
        
        double resultado = 0;
        
        //Realizar la operación seleccionada por el usuario
        switch(opcion) {
            case 1:
                resultado = num1 + num2;
                System.out.println("Resultado de la suma: " + resultado);
                break;
            case 2:
                resultado = num1 - num2;
                System.out.println("Resultado de la resta: " + resultado);
                break;
            case 3:
                resultado = num1 * num2;
                System.out.println("Resultado de la multiplicación: " + resultado);
                break;  
            case 4:
                if (num2 != 0) {
                    resultado = num1 / num2;
                    System.out.println("Resultado de la división: " + resultado);
                } else {
                    //Si el usuario intenta dividir por cero
                    System.out.println("Error: No se puede dividir entre cero.");
                }
                break;
            default:
            //Si el usuario ingresa un número que no corresponde a una opción válida (diferente de 1 a 4)
                System.out.println("Opción no válida.");
        }
        scanner.close();
    }
}
