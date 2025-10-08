namespace _5_ej3;

class Program
{
    static void Main(string[] args)
    {
        int edad, edadesMayores = 0, cantMayores = 0;
        double promedio;

        for (int i = 0; i < 20; i++)
        {
            System.Console.Write($"Ingrese la edad numero {i + 1}: ");
            edad = int.Parse(Console.ReadLine() ?? "");
            if (edad >= 18)
            {
                cantMayores++;
                edadesMayores += edad;
            }
        }
        promedio = edadesMayores / (double)cantMayores;
        System.Console.WriteLine($"La edad promedio entre los mayores es {promedio}.");
    }
}
