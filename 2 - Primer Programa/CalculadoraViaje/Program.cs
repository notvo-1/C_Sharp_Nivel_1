using System.Runtime.ConstrainedExecution;

namespace CalculadoraViaje;

class Program
{
    static void Main(string[] args)
    {
        int distancia, kmh;

        System.Console.WriteLine("Ingrese la distancia entre el punto A y el punto B en kilometros: ");
        int.TryParse(Console.ReadLine(), out distancia);

        System.Console.WriteLine("Ingrese la velocidad promedio del vehiculo en Km/h: ");
        int.TryParse(Console.ReadLine(), out kmh);

        // calculo tiempo de viaje

        double tiempoHoras;
        tiempoHoras = (double)distancia / kmh;
        int horas = (int)tiempoHoras;
        int tiempoMinutos = (int)((tiempoHoras - horas)*60);

        System.Console.WriteLine($"El tiempo que toma recorrer {distancia} kilometros es {horas} horas y {tiempoMinutos} minutos.");
    }
}
