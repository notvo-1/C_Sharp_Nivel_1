class Ej2
{
    public void Resolver()
    {
        Console.WriteLine("2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.");

        int[] vector = new int[10];
        int suma = 0;   
        for (int i = 0; i < vector.Length; i++)
        {
            Console.WriteLine($"Ingrese el numero n°{i}");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                vector[i] = num;
                suma += num;
            }
            else
            {
                Console.WriteLine("Error. Intente nuevamente");
                i--;
            }
        }

        double promedio = (double)suma / vector.Length;
        Console.WriteLine($"La suma es {suma} y el promedio es {promedio}");
        for (int j = 0; j < vector.Length; j++)
        {
            if (vector[j] > promedio)
            {
                Console.WriteLine($"El numero {vector[j]} es mayor que {promedio}");
            }
        }
    }
}