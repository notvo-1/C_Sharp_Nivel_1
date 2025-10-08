using System.Runtime.InteropServices;

namespace U3_ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4;
        int menor = int.MaxValue;

        System.Console.WriteLine("Ingrese el numero 1: ");
        int.TryParse(Console.ReadLine(), out n1);
        System.Console.WriteLine("Ingrese el numero 2: ");
        int.TryParse(Console.ReadLine(), out n2);
        System.Console.WriteLine("Ingrese el numero 3: ");
        int.TryParse(Console.ReadLine(), out n3);
        System.Console.WriteLine("Ingrese el numero 4: ");
        int.TryParse(Console.ReadLine(), out n4);

        if (n1 < menor)
        {
            menor = n1;
        }
        if (n2 < menor)
        {
            menor = n2;
        }
        if (n3 < menor)
        {
            menor = n3;
        }
        if (n4 < menor)
        {
            menor = n4;
        }

        Console.WriteLine($"El numero menor es {menor}");

    }
}
