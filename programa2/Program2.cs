using System;

namespace CalculoPerimetroRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el ancho y la altura del rectángulo
            Console.WriteLine("Ingrese el ancho del rectángulo:");
            double ancho = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del rectángulo:");
            double altura = Convert.ToDouble(Console.ReadLine());

            // Llamar a la función CalcularPerimetroRectangulo y guardar el resultado
            double perimetro = CalcularPerimetroRectangulo(ancho, altura);

            // Mostrar el resultado
            Console.WriteLine("El perímetro del rectángulo es: " + perimetro);
        }

        // Función que calcula el perímetro de un rectángulo dado su ancho y altura
        static double CalcularPerimetroRectangulo(double ancho, double altura)
        {
            // Calcular el perímetro usando la fórmula P = 2 * (ancho + altura)
            double perimetro = 2 * (ancho + altura);

            // Retornar el resultado
            return perimetro;
        }
    }
}