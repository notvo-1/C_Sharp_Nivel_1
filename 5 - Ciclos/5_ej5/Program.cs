namespace _5_ej5;

class Program
{
    static void Main(string[] args)
    {
        int num;
        int parMayor = int.MinValue;
        int imparMenor = int.MaxValue;

        for (int i = 0; i < 20; i++)
        {
            System.Console.Write($"Ingrese el numero {i}: ");
            num = int.Parse(Console.ReadLine() ?? "");

            if (num % 2 == 0 && num > parMayor)
            {
                parMayor = num;
            }
            else if (num % 2 != 0 && num < imparMenor)
            {
                imparMenor = num;
            }
        }

        System.Console.WriteLine($"El par Mayor es: {parMayor}");
        System.Console.WriteLine($"El impar Menor es: {imparMenor}");

    }
}
