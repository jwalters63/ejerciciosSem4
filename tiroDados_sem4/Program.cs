using System;

namespace tiroDados_sem4
{
    class Program
    {
        static int[] resultados = new int[13]; // Se inicializa un arreglo, en 13 para evitar errores de índice

        static void Main(string[] args)
        {
            Console.WriteLine("=== Ejercicio 1 // Tiro de dados ===");
            Console.WriteLine("Presione una tecla para tirar los dados");
            Console.ReadKey();

            Random rnd = new Random(); // Se inicializa un objeto Random para generar números aleatorios

            for (uint i = 0; i < 36000; i++)
            {
                int suma = rnd.Next(1, 7) + rnd.Next(1, 7); // Se genera un número aleatorio entre 1 y 6, dos veces, y se suman
                resultados[suma]++; // Se incrementa el contador de la suma obtenida
            }

            Console.WriteLine("=== Resultados ===");
            for (int i = 2; i <= 12; i++)
            {
                Console.WriteLine($"Suma {i}: {resultados[i]} // Probabilidad: {(resultados[i] / 36000.0) * 100}%"); // Se imprime la suma y la probabilidad
            }
        }
    }
}