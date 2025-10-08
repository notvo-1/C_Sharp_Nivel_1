namespace Punto_1;

class Program
{
    static void Main(string[] args)
    {
        int primos = 0, num;

        for (int i = 1; i < 11; i++)
        {
            int divisores = 0;
            System.Console.Write($"{i}-Ingrese un numero: ");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                if (num > 0)
                {
                    for (int j = 2; j <= Math.Sqrt(num) && divisores == 0; j++)
                    {
                        if (num % j == 0)
                        {
                            divisores++;
                        }
                    }
                    if (divisores == 0 && num > 1)
                    {
                        primos++;
                    }
                }
            }
        }
        System.Console.WriteLine($"La cantidad de numeros primos ingresados es {primos}.");
    }
}
