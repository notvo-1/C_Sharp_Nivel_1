namespace U4_ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2;

        while (true)
        {
            System.Console.WriteLine("Ingrese el numero 1: ");
            if (int.TryParse(Console.ReadLine(), out n1))
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Incorrecto. Ingrese un dato valido.");
            }
        }
        while (true)
        {
            System.Console.WriteLine("Ingrese el numero 2: ");
            if (int.TryParse(Console.ReadLine(), out n2))
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Incorrecto. Ingrese un dato valido.");
            }
        }
        if (n1 > n2)
        {
            System.Console.WriteLine($"La resta de los dos numeros es: {n1 - n2}");
        }
        if (n1 < n2)
        {
            System.Console.WriteLine($"El producto de los dos numeros es: {n1*n2}");
        }

        if (n1 == n2)
        {
            System.Console.WriteLine($"La suma de los dos numeros es: {n1 + n2}");
        }
    }
}
