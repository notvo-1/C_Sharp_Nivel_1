namespace U7_Vectores;

public class Ej1
{
    public void Resolver()
    {
        int[] vector = new int[10];
        int num;
        Console.WriteLine("Guardar 10 números y mostrar la suma");

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Ingrese el numero {i+1}");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                vector[i] = num;
            }
            else
            {
                Console.WriteLine("Error. Ingrese un numero valido");
                i--;
            }
        }
        int suma = 0;
        for (int i = 0; i < vector.Length; i++)
        {
            suma += vector[i];
        }

        Console.WriteLine("{" + String.Join(",", vector) + "}");
            Console.WriteLine($"La suma es {suma}");
        }
    } 
