class Ej1
{


    public void Resolver()
    {
        Console.WriteLine("1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.");

        int[] vector = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Ingrese el numero n°{i + 1}");
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

        int posicion = 0;
        int maximo = int.MinValue;
        for (int f = 0; f < vector.Length; f++)
        {
            if (vector[f] > maximo)
            {
                maximo = vector[f];
                posicion = f;
            }
        }

        Console.WriteLine($"El numero maximo ingresado es {maximo} y esta en la posicion {posicion + 1}");
    }
}