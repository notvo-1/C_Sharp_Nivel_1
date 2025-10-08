namespace U3_ejercicio1;

class Program
{
    static void Main(string[] args)
    {
        int n1;

        System.Console.WriteLine("Ingrese el primer numero: ");
        int.TryParse(Console.ReadLine(), out n1);


        if (n1 > 10)
        {
            System.Console.WriteLine($"El numero {n1} es mayor a 10");
        }else
        {
            System.Console.WriteLine($"El numero {n1} no es mayor a 10");
        }
    }
}
