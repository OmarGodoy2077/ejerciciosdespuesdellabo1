using System;

namespace programa1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el radio del círculo
            Console.WriteLine("Ingrese el radio del círculo:");
            double radio = Convert.ToDouble(Console.ReadLine());

            // Llamar a la función CalcularAreaCirculo y guardar el resultado
            double area = CalcularAreaCirculo(radio);

            // Mostrar el resultado
            Console.WriteLine("El área del círculo es: " + area);
        }

        // Función que calcula el área de un círculo dado su radio
        static double CalcularAreaCirculo(double radio)
        {
            // Definir la constante pi
            const double pi = 3.14159;

            // Calcular el área usando la fórmula A = π * r^2
            double area = pi * Math.Pow(radio, 2);

          
            return area;
        }
    }
}