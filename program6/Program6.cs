using System;

namespace DistanciaPuntos
{
    class Program6
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese las coordenadas de los dos puntos
            Console.WriteLine("Ingrese las coordenadas del punto 1 (x1, y1):");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese las coordenadas del punto 2 (x2, y2):");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            // Llamar a la función CalcularDistancia y guardar el resultado
            double distancia = CalcularDistancia(x1, y1, x2, y2);

            // Mostrar el resultado
            Console.WriteLine($"La distancia entre los puntos ({x1}, {y1}) y ({x2}, {y2}) es: {distancia}");
        }

        // Función que calcula la distancia entre dos puntos en un plano cartesiano
        static double CalcularDistancia(double x1, double y1, double x2, double y2)
        {
            // Calcular las diferencias entre las coordenadas x e y
            double deltaX = x2 - x1;
            double deltaY = y2 - y1;

            // Calcular la distancia utilizando el teorema de Pitágoras
            double distancia = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

            // Retornar el resultado
            return distancia;
        }
    }
}