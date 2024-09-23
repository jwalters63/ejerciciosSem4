using System;

class ComisionVendedorSem4
{
    static void Main()
    {
        int[] contadores = new int[9];

        Console.WriteLine("Bienvenido al sistema de ingreso de ventas");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

        while (true)
        {
            Console.Write("Ingrese las ventas para calcular la comisión (Ingrese 0 para terminar): ");
            int ventas = int.Parse(Console.ReadLine());
            if (ventas == 0) break;

            int salario = 200 + (int)(0.09 * ventas);
            int indice;
            if (salario >= 200 && salario < 300) indice = 0;
            else if (salario >= 300 && salario < 400) indice = 1;
            else if (salario >= 400 && salario < 500) indice = 2;
            else if (salario >= 500 && salario < 600) indice = 3;
            else if (salario >= 600 && salario < 700) indice = 4;
            else if (salario >= 700 && salario < 800) indice = 5;
            else if (salario >= 800 && salario < 900) indice = 6;
            else if (salario >= 900 && salario < 1000) indice = 7;
            else indice = 8;
            contadores[indice]++;
        }

        Console.WriteLine("=== Resultados ===");
        Console.WriteLine();
        for (int i = 0; i < 8; i++)
        {
            int min = 200 + i * 100;
            int max = min + 99;
            Console.WriteLine($"{min}-{max}: {contadores[i]}");
        }
        Console.WriteLine($"$1000 o superior: {contadores[8]}");
        Console.WriteLine("==================");
    }
}