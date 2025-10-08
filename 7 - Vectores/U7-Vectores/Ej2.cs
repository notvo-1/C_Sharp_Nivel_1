namespace U7_Vectores;

public class Ej2
{
    public void Resolver()
    {
        Console.WriteLine("Guardar 50 números. Buscar máximo y posición.");
        int[] vector = new int[50];
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine($"Ingrese el numero {i+1}");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                vector[i] = num;
            }
            else
            {
                Console.WriteLine("Error. Ingrese un numero valido");
                i--;
            }
        }
        int mayor = int.MinValue;
        int posMax=0;
        for (int j = 0; j < vector.Length; j++)
        {
            if (vector[j] > mayor)
            {
                mayor = vector[j];
                posMax = j+1;
            }
        }

        Console.WriteLine("{" + string.Join(", ", vector) + "}");
        Console.WriteLine($"La posicion del numero mayor es {posMax} y el numero mayor es {mayor}");
    }

    
}
