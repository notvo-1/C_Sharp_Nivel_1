public class Ej3
{
    public void Resolver()
    {
        Console.WriteLine("3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. Informar el promedio teniendo en cuenta sólo los números primos.");
        int num;
        int cantPrimos = 0;
        int sumaPrimos = 0;
        do
        {
            Console.Write("Ingrese un numero para evaluar si es primo: ");
            num = int.Parse(Console.ReadLine() ?? "");

            if (num != 0 && EsPrimo(num) == 1)
            {
                cantPrimos++;
                sumaPrimos += num;
            }

        } while (num != 0);

        Console.WriteLine($"La cantidad de numeros primos es {cantPrimos} y la suma de esos numeros es {sumaPrimos}");
        MostrarPromedio(cantPrimos, sumaPrimos);
    }

    public int EsPrimo(int num)
    {
        int divisores = 0;
        for (int i = 2; i <= Math.Sqrt(num) && divisores == 0; i++)
        {
            if (num % i == 0)
            {
                divisores++;
            }
        }
        if (divisores == 0 && num != 1)
        {
            return 1;
        }
        return 0;
    }

    public void MostrarPromedio(int cantidad, int suma)
    {
        Console.WriteLine($"El promedio es {(double)suma / cantidad:F2}");
    }
}