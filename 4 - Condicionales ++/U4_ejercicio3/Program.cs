using System.Data;
using System.Runtime.InteropServices;

namespace U4_ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        int[,] preciosBase =
        {
        {800,900,1200},
        {900, 1000, 1400},
        {1000, 1400, 2000}
        };

        System.Console.WriteLine("Elija la opcion de procesador: 1 - i5; 2 - i7; 3 - i9");
        System.Console.Write("Elija 1, 2 o 3: ");
        int procesador = int.Parse(Console.ReadLine() ?? "") - 1;

        System.Console.WriteLine("Elija la opcion de procesador: 1 - 8 RAM; 2 - 16 RAM; 3 - 32 RAM");
        System.Console.Write("Elija 1, 2 o 3: ");
        int ram = int.Parse(Console.ReadLine() ?? "") - 1;

        System.Console.WriteLine("Desea extender el disco? 1 - SI, 2 - NO");
        int disco = Console.ReadLine() == "1" ? 300 : 0;

        int precioBase = preciosBase[ram, procesador];
        int precioFinal = precioBase + disco;

        System.Console.WriteLine($" El precio final es {precioFinal}"); 



    }
}
