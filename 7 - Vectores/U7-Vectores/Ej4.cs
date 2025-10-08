namespace U7_Vectores;

public class Ej4
{
    public void Resolver()
    {
        Console.WriteLine("Guardar 20 números. Determinar si está ordenado.");

        int[] vector = new int[20];
        Random r = new Random();
        bool descendente = true;
        bool ascendente = true;
        int lenght = vector.Length;
        int num;

        // vector = Enumerable.Range(0, 20).ToArray();
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Ingrese el numero {i + 1}: ");
            num = r.Next(100);
            Console.WriteLine(num);
            vector[i] = num;
        }

        Console.WriteLine("{" + string.Join(", ", vector) + "}");
        for (int j = 0; j < lenght-1; j++)
        {
            if (vector[j] > vector[j + 1]) ascendente = false;
            if (vector[j] < vector[j + 1]) descendente = false;

            if (!descendente && !ascendente) break;
        }

        if (descendente || ascendente)
        {
            Console.WriteLine($"El vector SI esta rodenado");
        }
        else
        {
            Console.WriteLine($"El vector NO esta rodenado");
        }

    }
}
