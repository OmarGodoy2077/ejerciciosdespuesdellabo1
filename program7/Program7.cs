using System;

namespace SumaNumerosNaturales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número entero n
            Console.WriteLine("Ingrese un número entero n:");
            int n = Convert.ToInt32(Console.ReadLine());

            // Llamar a la función SumaPrimerosN y guardar el resultado
            int suma = SumaPrimerosN(n);

            // Mostrar el resultado
            Console.WriteLine($"La suma de los primeros {n} números naturales es: {suma}");
        }

        // Función que calcula la suma de los primeros n números naturales
        static int SumaPrimerosN(int n)
        {
            // Calcular la suma de los primeros n números naturales usando un bucle for
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }

            // Retornar el resultado
            return suma;
        }
    }
}