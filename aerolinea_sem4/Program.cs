using System;

namespace AerolineaSem4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Sistema de reservaciones de vuelos ===");
            Console.WriteLine("La capacidad de la aeronave es de 10 asientos, divididos en dos secciones: fumadores y no fumadores.");
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            Random rnd = new Random();

            Console.Write("¿Cómo se llama?\n-> ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"¡Bienvenido, {nombre}!");

            string preference;
            while (true)
            {
                Console.Write("¿Es usted una persona que fuma o tolera el cigarro? (s/n)\n-> ");
                string respuesta = Console.ReadLine();
                if (respuesta.ToLower() == "s")
                {
                    preference = "Fuma";
                    break;
                }
                else if (respuesta.ToLower() == "n")
                {
                    preference = "NoFuma";
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("=== Error, inténtelo de nuevo ===\nPor favor, responda con 's' o 'n'.");
                }
            }
            if (preference == "Fuma")
            {
                Console.WriteLine("\n¡Bienvenido a bordo! Se le asignará un asiento en la sección de fumadores.");
                Console.WriteLine("Por favor, espere un momento...");
                int asiento = rnd.Next(1, 6);
                Console.WriteLine($"Su asiento es el número {asiento}. En la sección de fumadores.");
            }
            else
            {
                Console.WriteLine("\n¡Bienvenido a bordo! Se le asignará un asiento en la sección de no fumadores.");
                Console.WriteLine("Por favor, espere un momento...");
                int asiento = rnd.Next(6, 11);
                Console.WriteLine($"Su asiento es el número {asiento}. En la sección de no fumadores.");
            }
        }
    }
}