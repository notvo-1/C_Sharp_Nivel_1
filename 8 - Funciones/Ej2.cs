public class Ej2
{
    public void Resolver()
    {
        int num;
        int cantPares = 0;

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"{i+1}- Ingrese un numero para evaluar si es par: ");
            num = int.Parse(Console.ReadLine() ?? "");
            if (EsPar(num))
            {
                cantPares++;
            }
        }

        Console.WriteLine($"La cantidad de pares es {cantPares}");


    }

    public bool EsPar(int num)
    {
        return num % 2 == 0;
    }
}