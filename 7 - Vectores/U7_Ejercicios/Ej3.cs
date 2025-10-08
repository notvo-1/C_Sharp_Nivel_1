using System.Numerics;

class Ej3
{
    public void Resolver()
    {
        Console.WriteLine("Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla.");

        char car1;
        char car2;
        char[] cadena = new char[10];
        char input;

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Ingrese un caracter. Para terminar precione '.' ");
            input = char.Parse(Console.ReadLine() ?? "");
            if (input == '.')
            {
                break;
            }
            else
            {
                cadena[i] = input;
            }
        }

        Console.WriteLine("Ingrese el valor a buscar: ");
        car1 = char.Parse(Console.ReadLine() ?? "");
        Console.WriteLine("Ingrese el valor a reemplazar: ");
        car2 = char.Parse(Console.ReadLine() ?? "");

        for (int i = 0; i < 10; i++)
        {
            if (cadena[i]== '.')
            {
                break;
            }
            else
            {
                if (cadena[i] == car1)
                {
                    cadena[i] = car2;
                }
            }
        }

        Console.WriteLine(string.Join("", cadena));
    }
}