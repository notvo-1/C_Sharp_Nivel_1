namespace Punto_3;

class Program
{
    static void Main(string[] args)
    {
        int cantidadNumeros = 0;
        int salida = 0;
        int contador = 0;

        while (salida >= 0)
        {
            while (salida == 0)
            {
                Console.WriteLine("Ingrese numeros para contarlos. Para cerrar la lista, precione 0");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num <= 0)
                    {
                        salida = num;
                        break;
                    }
                    else
                    {
                        cantidadNumeros++;
                    }
                }
                else
                {
                    Console.WriteLine("Error. Ingrese un numero.");
                }

            }
            contador++;
            Console.WriteLine($"La lista {contador} tiene {cantidadNumeros}.");
            cantidadNumeros = 0;
        }
        Console.WriteLine("Fin de programa.");


    }
}
