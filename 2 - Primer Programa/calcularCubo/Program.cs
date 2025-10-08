using System.Runtime.ConstrainedExecution;

namespace calcularCubo;

class Program
{
    static void Main(string[] args)
    {
        int bas;

        System.Console.WriteLine("Ingrese un numero entero para calcular el cubo: ");
        int.TryParse(Console.ReadLine(), out bas);

        //Calcular cubo

        int cubo = bas * bas * bas;
        int cub = (int)Math.Pow(bas,3);
        System.Console.WriteLine($"El cubo de {bas} es {cubo}");
        System.Console.WriteLine($"El cubo de {bas} es {cub}");


    }
}
