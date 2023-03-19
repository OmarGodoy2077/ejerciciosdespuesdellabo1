using System;

namespace ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número entero
            Console.WriteLine("Ingrese un número entero:");
            int numero = Convert.ToInt32(Console.ReadLine());

            // Llamar a la función EsPar y guardar el resultado
            bool esPar = EsPar(numero);

            // Mostrar el resultado
            if (esPar)
            {
                Console.WriteLine("El número " + numero + " es par.");
            }
            else
            {
                Console.WriteLine("El número " + numero + " es impar.");
            }
        }

        // Función que determina si un número es par o impar
        static bool EsPar(int numero)
        {
            // Usar el operador de módulo (%) para determinar si el número es par
            if (numero % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
