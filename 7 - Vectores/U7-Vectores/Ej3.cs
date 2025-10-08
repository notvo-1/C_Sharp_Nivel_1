namespace U7_Vectores;

public class Ej3
{
    public void Resolver()
    {
        Console.WriteLine("Guardar 100 números. Calcular promedio, mostrar los mayores");
        int[] vector = new int[100];
        int cantidad = vector.Length;
        int suma = 0;
        Random r = new Random();

        for (int i = 0; i < cantidad; i++)
        {
            Console.Write($"Ingrese el numero {i}: ");
            vector[i] = r.Next(100);
            Console.WriteLine(vector[i]);
            suma += vector[i];
        }

        double promedio = (double)suma / cantidad;

        for (int j = 0; j < cantidad; j++)
        {
            if (vector[j] > promedio)
            {
                Console.WriteLine($"{vector[j]} es mayor que el promedio {promedio:F2}");
            }
        }
    }
}

