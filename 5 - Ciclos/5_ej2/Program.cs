namespace _5_ej2;

class Program
{
    static void Main(string[] args)
    {
        int mayor = int.MinValue;
        int num;
        for (int i = 0; i < 10; i++)
        {
            System.Console.Write($"Ingrese el numero {i + 1}: ");
            int.TryParse(Console.ReadLine(), out num);
            mayor = num > mayor ? num : mayor;
        }
        System.Console.WriteLine($"El numero mayor es: {mayor}");
    }
}
