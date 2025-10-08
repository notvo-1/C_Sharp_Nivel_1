namespace U7_Vectores;

public class Ej5
{
    public void Resolver()
    {
        Console.WriteLine("Vector de valores Char. Intercambiar caracteres dados.");

        int contador = 0;
        char[] vector = new char[50];
        char salida = 'l';
        string frase = "Hola los vagos como dice que le va la vida? como dicen que le va la vida?";


        while (salida != '.' && contador < vector.Length)
        {
            Console.Write($"Ingrese el caracter {contador + 1}: ");
            vector[contador] = frase[contador];
            Console.WriteLine(vector[contador]);
            if (vector[contador] == '.')
            {
                salida = '.';
            }
            contador++;

        }

        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i]);
            if (vector[i] == 'a')
            {
                vector[i] = 'i';
            }
        }
        Console.WriteLine();

        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write(vector[i]);
        }
        Console.WriteLine();
    }
}
