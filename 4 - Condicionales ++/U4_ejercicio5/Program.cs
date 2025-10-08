namespace U4_ejercicio5;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3, n4;

        while (true)
        {
            System.Console.WriteLine("Ingrese el numero 1: ");
            if (int.TryParse(Console.ReadLine(), out n1))
            {
                if (n1 >= 0)
                {
                    break;
                }
            }
            System.Console.WriteLine("Ingrese un numero valido.");
        }
        while (true)
        {
            System.Console.WriteLine("Ingrese el numero 2: ");
            if (int.TryParse(Console.ReadLine(), out n2))
            {
                if (n2 >= 0)
                {
                    break;
                }
            }
            System.Console.WriteLine("Ingrese un numero valido.");
        }
        while (true)
        {
            System.Console.WriteLine("Ingrese el numero 3: ");
            if (int.TryParse(Console.ReadLine(), out n3))
            {
                if (n3 >= 0)
                {
                    break;
                }
            }
            System.Console.WriteLine("Ingrese un numero valido.");
        }
        while (true)
        {
            System.Console.WriteLine("Ingrese el numero 4: ");
            if (int.TryParse(Console.ReadLine(), out n4))
            {
                if (n4 >= 0)
                {
                    break;
                }
            }
            System.Console.WriteLine("Ingrese un numero valido.");
        }

        if (n1 > n2 && n2 > n3 && n3 > n4)
        {
            System.Console.WriteLine("El diablo, si esta ordenado.");
        }
    }
}
