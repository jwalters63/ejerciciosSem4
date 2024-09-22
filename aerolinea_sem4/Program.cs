using System;

class Program
{
    static void Main()
    {
        // Inicializar arreglo de booleanos para los asientos
        bool[] asientos = new bool[10];

        // Inicializar arreglo de strings para los nombres de los pasajeros
        string[] nombres = new string[10];

        int fumadores = 0;
        int noFumadores = 0;

        while (true)
        {
            // Mostrar mensaje de bienvenida
            Console.WriteLine("Bienvenido al sistema de asignación de asientos.");

            // Mostrar número de personas en cada zona
            Console.WriteLine($"Fumadores: {fumadores}, No Fumadores: {noFumadores}");

            // Solicitar nombre del pasajero
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();

            // Solicitar preferencia de fumador/no fumador
            Console.WriteLine("¿Es fumador? (S/N)");
            string preferencia = Console.ReadLine().ToUpper();

            int asiento = 0;

            // Verificar si la opción es válida
            while (preferencia != "S" && preferencia != "N")
            {
                Console.WriteLine("Opción no válida. Por favor, ingrese S o N.");
                Console.WriteLine("¿Es fumador? (S/N)");
                preferencia = Console.ReadLine().ToUpper();
            }

            // Asignar asiento según preferencia
            if (preferencia == "S")
            {
                // Asignar asiento en sección de fumadores
                Console.WriteLine("\n¡Bienvenido a bordo! Se le asignará un asiento en la sección de fumadores.");
                Console.WriteLine("Por favor, espere un momento...");
                asiento = AsignarAsiento(asientos, 0, 5);
                if (asiento != 0)
                {
                    fumadores++;
                    nombres[asiento - 1] = nombre; // Use the seat number - 1 to index the nombres array
                }
                else
                {
                    Console.WriteLine("Lo sentimos, no hay asientos disponibles en la sección de fumadores.");
                }
            }
            else if (preferencia == "N")
            {
                // Asignar asiento en sección de no fumadores
                Console.WriteLine("\n¡Bienvenido a bordo! Se le asignará un asiento en la sección de no fumadores.");
                Console.WriteLine("Por favor, espere un momento...");
                asiento = AsignarAsiento(asientos, 5, 10);
                if (asiento != 0)
                {
                    noFumadores++;
                    nombres[asiento - 1] = nombre; // Use the seat number - 1 to index the nombres array
                }
                else
                {
                    Console.WriteLine("Lo sentimos, no hay asientos disponibles en la sección de no fumadores.");
                }
            }

            // Verificar si se han asignado 10 asientos
            if (fumadores + noFumadores == 10)
            {
                break;
            }

            // Solicitar tecla para continuar
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        // Imprimir tabla con la distribución de asientos, la zona y el nombre del pasajero
        Console.WriteLine("Distribución de asientos:");
        Console.WriteLine("Asiento\tZona\tNombre");
        Console.WriteLine("----------------------------");
        for (int i = 0; i < 10; i++)
        {
            string zona = i < 5 ? "Fumadores" : "No Fumadores";
            Console.WriteLine($"{i + 1}\t{zona}\t{nombres[i] ?? string.Empty}");
        }
    }

    static int AsignarAsiento(bool[] asientos, int inicio, int fin)
    {
        // Buscar primer asiento disponible en el rango especificado
        for (int i = inicio; i < fin; i++)
        {
            if (!asientos[i])
            {
                asientos[i] = true;
                return i + 1; // Return the seat number (1-based)
            }
        }
        return 0; // No hay espacio disponible
    }
}