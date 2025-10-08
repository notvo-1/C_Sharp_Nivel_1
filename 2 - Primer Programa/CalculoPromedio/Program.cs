namespace CalculoPromedio;

class Program
{
    static void Main(string[] args)
    {
        double n1, n2, n3;

        System.Console.WriteLine("Ingrese la nota numero 1: ");
        double.TryParse(Console.ReadLine(), out n1);
        System.Console.WriteLine($"La nota ingresada es {n1}");
        System.Console.WriteLine("###########################");
        System.Console.WriteLine("");
        System.Console.WriteLine("Ingrese la nota numero 2: ");
        double.TryParse(Console.ReadLine(), out n2);
        System.Console.WriteLine($"La nota ingresada es {n2}");
        System.Console.WriteLine("###########################");
        System.Console.WriteLine("");
        System.Console.WriteLine("Ingrese la nota numero 3: ");
        double.TryParse(Console.ReadLine(), out n3);
        System.Console.WriteLine($"La nota ingresada es {n3}");
        System.Console.WriteLine("###########################");
        System.Console.WriteLine("");


        double totalNotas = n1 + n2 + n3;
        double promedio = totalNotas / 3;

        System.Console.WriteLine($"El promedio de notas es {promedio:F2}");
    }
}
