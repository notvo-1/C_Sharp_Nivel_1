namespace U4_ejercicio4;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2, n3;

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

        if ((n1 + n2) > (n2 * n3))
        {
            System.Console.WriteLine("La suma del primero por el segundo es mayor al producto del segundo por el tercero.");
        }
        else
        {
            System.Console.WriteLine("El diablo, no pasa eso.");
        }
    }
}
