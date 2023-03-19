using System;

namespace ConvertirAMayusculas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese una cadena de texto
            Console.WriteLine("Ingrese una cadena de texto:");
            string texto = Console.ReadLine();

            // Llamar a la función ConvertirAMayusculas y guardar el resultado
            string textoEnMayusculas = ConvertirAMayusculas(texto);

            // Mostrar el resultado
            Console.WriteLine("La cadena de texto en mayúsculas es: " + textoEnMayusculas);
        }

        // Función que convierte una cadena de texto a mayúsculas
        static string ConvertirAMayusculas(string texto)
        {
            // Utilizar el método ToUpper() para convertir la cadena a mayúsculas
            string resultado = texto.ToUpper();

            // Retornar el resultado
            return resultado;
        }
    }
}