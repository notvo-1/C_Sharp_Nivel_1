namespace CalculoSueldo;

class Program
{
    static void Main(string[] args)
    {
        const double SueldoFijo = 15000;
        const double Comision = 0.05;
        int totalFacturado;

        System.Console.WriteLine("Ingrese el total facturado del mes: ");
        int.TryParse(Console.ReadLine(), out totalFacturado);

        double calculoSueldo = SueldoFijo + totalFacturado * Comision;
        System.Console.WriteLine($"La comision es de {Comision*totalFacturado:F2}");
        System.Console.WriteLine($"El sueldo a cobrar este mes es de {calculoSueldo}");



    }
}
