namespace U7_Vectores;

public class Ej6
{
    public void Resolver()
    {
        Console.WriteLine("Ejercicio 6. Guardar 10 números y buscar repetidos.");

        int[] vector = new int[10];
        int cantRepetidos = 0;

        for (int i = 0; i < 10; i++)
        {
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                vector[i] = num;
            }
            else
            {
                Console.WriteLine("Error. Ingrese un numero valido.");
            }
        }
        string rep = "";
        for (int j = 0; j < vector.Length; j++)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == vector[j])
                {
                    cantRepetidos++;
                }
            }

            if (cantRepetidos >= 2)
            {
                rep += vector[j] + ", ";
            }
            cantRepetidos = 0;
        }

        Console.WriteLine($"Los caracteres repetidos son {rep}");
    }
}
