using System;
using System.Collections.Generic;

namespace CalculoPromedioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista de enteros de 
            List<int> numeros = new List<int> { 10, 8, 9, 10 };

            // Llamar a la función CalcularPromedio y guardar el resultado
            double promedio = CalcularPromedio(numeros);

            // Mostrar el resultado
            Console.WriteLine("El promedio de la lista de números es: " + promedio);
        }

        // Función que calcula el promedio de una lista de números enteros
        static double CalcularPromedio(List<int> numeros)
        {
            // Calcular la suma de los números en la lista
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }

            // Calcular el promedio dividiendo la suma por la cantidad de números
            double promedio = (double)suma / numeros.Count;

            // Retornar el resultado
            return promedio;
        }
    }
}