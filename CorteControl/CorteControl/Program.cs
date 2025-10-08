using System.Runtime.Intrinsics.X86;

namespace CorteControl;

class Program
{
    static void Main(string[] args)
    {
        int lejago, edad, codigoEquipo, equipoActual;
        float sueldo;

        System.Console.WriteLine("Ingrese el legajo");
        lejago = int.Parse(Console.ReadLine() ?? "");
        System.Console.WriteLine("Ingrese la edad");
        edad = int.Parse(Console.ReadLine() ?? "");
        System.Console.WriteLine("Ingrese el sueldo");
        sueldo = float.Parse(Console.ReadLine() ?? "");
        System.Console.WriteLine("Ingrese el codigo de equipo");
        codigoEquipo = int.Parse(Console.ReadLine() ?? "");

        while (sueldo > 0)
        {
            equipoActual = codigoEquipo;
            while (equipoActual == codigoEquipo)
            {
                System.Console.WriteLine("Ingrese el legajo");
                lejago = int.Parse(Console.ReadLine() ?? "");
                System.Console.WriteLine("Ingrese la edad");
                edad = int.Parse(Console.ReadLine() ?? "");
                System.Console.WriteLine("Ingrese el sueldo");
                sueldo = float.Parse(Console.ReadLine() ?? "");
                System.Console.WriteLine("Ingrese el codigo de equipo");
                codigoEquipo = int.Parse(Console.ReadLine() ?? "");
            }
        }

    }
}
