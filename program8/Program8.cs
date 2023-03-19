using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número entero
            Console.WriteLine("Ingrese un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Llamar a la función CalcularFactorial y guardar el resultado
            long factorial = CalcularFactorial(numero);

            // Mostrar el resultado
            Console.WriteLine($"El factorial de {numero} es: {factorial}");
        }

        // Función que calcula el factorial de un número
        static long CalcularFactorial(int numero)
        {
            // Calcular el factorial usando un bucle for
            long factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            // Retornar el resultado
            return factorial;
        }
    }
}