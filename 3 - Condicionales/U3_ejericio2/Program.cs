using System.Timers;

namespace U3_ejericio2;

class Program
{
    static void Main(string[] args)
    {
        int n1;
        System.Console.WriteLine("Ingrese un numero para ser evaluado: ");
        if (!int.TryParse(Console.ReadLine(), out n1))
        {
            Console.WriteLine("Ingrese un numero correcto");
        }
        else
        {
            if (n1 == 0)
            {
                Console.WriteLine("El numero es cero");
            }
            else if (n1 > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            else
            {
                Console.WriteLine("El numero es negativo");
            }

        }

    }
}
