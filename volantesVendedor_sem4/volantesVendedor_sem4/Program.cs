using System;

class RegistroDeVentas
{
    static void Main(string[] args)
    {
        // Inicializar el arreglo de ventas
        decimal[,] ventas = new decimal[5, 4];

        // Solicitar la entrada de datos
        Console.Write("Ingrese el número de ventas que desea registrar: ");
        int numVentas;
        while (!int.TryParse(Console.ReadLine(), out numVentas) || numVentas <= 0)
        {
            Console.Write("Ingrese un número de ventas válido: ");
        }

        for (int i = 0; i < numVentas; i++)
        {
            Console.WriteLine("Venta {0}: ", i + 1);

            int vendedor;
            while (true)
            {
                Console.Write("Ingrese el número del vendedor (1-4): ");
                if (int.TryParse(Console.ReadLine(), out vendedor) && vendedor >= 1 && vendedor <= 4)
                {
                    vendedor -= 1; // ajustar a índice basado en 0
                    break;
                }
                Console.Write("Ingrese un número de vendedor válido: ");
            }

            int producto;
            while (true)
            {
                Console.Write("Ingrese el número del producto (1-5): ");
                if (int.TryParse(Console.ReadLine(), out producto) && producto >= 1 && producto <= 5)
                {
                    producto -= 1; // ajustar a índice basado en 0
                    break;
                }
                Console.Write("Ingrese un número de producto válido: ");
            }

            decimal valor;
            while (true)
            {
                Console.Write("Ingrese el valor total de la venta: ");
                if (decimal.TryParse(Console.ReadLine(), out valor) && valor > 0)
                {
                    break;
                }
                Console.Write("Ingrese un valor de venta válido: ");
            }

            ventas[producto, vendedor] += valor;
        }

        // Imprimir resultados en forma tabular
        Console.WriteLine("\n[Producto|Vendedor]\t[V1]\t[V2]\t[V3]\t[V4]\t[Total del Producto]");
        for (int i = 0; i < 5; i++)
        {
            decimal totalProducto = 0;
            Console.Write("[Producto] ({0})\t\t", i + 1);
            for (int j = 0; j < 4; j++)
            {
                Console.Write("{0}\t", ventas[i, j]);
                totalProducto += ventas[i, j];
            }
            Console.WriteLine("{0}", totalProducto);
        }

        // Imprimir totales por vendedor
        Console.Write("[Total Vendedor]\t");
        for (int j = 0; j < 4; j++)
        {
            decimal totalVendedor = 0;
            for (int i = 0; i < 5; i++)
            {
                totalVendedor += ventas[i, j];
            }
            Console.Write("{0}\t", totalVendedor);
        }
        Console.WriteLine();
    }
}