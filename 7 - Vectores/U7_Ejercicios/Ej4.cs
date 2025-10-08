class Ej4
{
    public void Resolver()
    {
        Console.WriteLine("4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:");
        Console.WriteLine("-Número de Artículo (1 a 15)");
        Console.WriteLine("- Cantidad Vendida");
        Console.WriteLine("Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.");
        Console.WriteLine("Se pide determinar e informar:");
        Console.WriteLine("a) El número de artículo que más se vendió en total.");
        Console.WriteLine("b) Los números de artículos que no registraron ventas.");
        Console.WriteLine("c) Cuantas unidades se vendieron del número de artículo 10.");

        int[] articulos = new int[15];
        int numeroArticulo;
        int cantidad;

        do
        {
            Console.Write("Ingrese el numero de articulo para registrar (Ingrese 0 para salir): ");
            int.TryParse(Console.ReadLine(), out numeroArticulo);
            if (numeroArticulo != 0)
            {
                Console.Write("Ingrese la cantidad del articulo vendido: ");
                int.TryParse(Console.ReadLine(), out cantidad);
                articulos[numeroArticulo - 1] += cantidad;
            }

        } while (numeroArticulo != 0);

        for (int i = 0; i < articulos.Length; i++)
        {
            Console.WriteLine($"Se vendieron {articulos[i]} items del articulo {i + 1}.");

        }
        // Punto a
        int cantMaxima = int.MinValue;
        int posMaxima = 0;

        for (int item = 0; item < articulos.Length; item++)
        {
            if (articulos[item] > cantMaxima)
            {
                cantMaxima = articulos[item];
                posMaxima = item;
            }
        }

        Console.WriteLine($"El articulo que mas se vendio es el de la posicion {posMaxima + 1} con {articulos[posMaxima]} items vendidos.");


        Console.WriteLine("Los articulos sin venta son: ");
        for (int i = 0; i < articulos.Length; i++)
        {
            if (articulos[i] == 0)
            {
                Console.WriteLine($"Articulo {i + 1}.");
            }
        }

        //Punto c

        int posicion;
        Console.WriteLine("Ingrese la posicion a consultar: ");
        int.TryParse(Console.ReadLine(), out posicion);
        Console.WriteLine($"Se vendieron {articulos[posicion]} del articulo {posicion}");
    }
}