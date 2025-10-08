namespace _5_ej4;

class Program
{
    static void Main(string[] args)
    {
        int num, divisores = 0;

        System.Console.Write("Ingrese un numero para evaluar: ");
        num = int.Parse(Console.ReadLine() ?? "");

        for (int i = 2; i <= Math.Sqrt(num) && divisores == 0; i++)
        {
            //divisores = num % i == 0 ? divisores + 1 : divisores;
            System.Console.WriteLine(i + " - " + divisores );
            if (num % i == 0)
            {
                divisores++;
            }
        }
        System.Console.WriteLine(" - " + divisores );

        if (divisores == 0 && num != 1)
        {
            System.Console.WriteLine("Es un numero primo.");
        }
        else
        {
            System.Console.WriteLine("No es un numero primo. ");
        }
    }
}
