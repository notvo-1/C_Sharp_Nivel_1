namespace U4_ejercicio2;

class Program
{
    static void Main(string[] args)
    {
        int litros;
        while (true)
        {
            System.Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
            if (int.TryParse(Console.ReadLine(), out litros))
            {
                if (litros >= 0)
                {
                    break;
                }
                System.Console.WriteLine("Numero debe ser positivo");
            }
            else
            {
                System.Console.WriteLine("Ingrese un numero valido");
            }
        }

        if (litros <= 100)
        {
            System.Console.WriteLine("No descuento para ti.");
        }
        if (litros > 100 && litros <= 300)
        {
            System.Console.WriteLine($"El descuendo es de 10%");
        }
        if (litros > 300 && litros <= 500)
        {
            System.Console.WriteLine($"El descuendo es de 15%");
        }
        if (litros > 500)
        {
            System.Console.WriteLine($"El descuendo es de 25%");
        }
    }
}
