public class Ej1
{
    public void Resolver()
    {
        Console.WriteLine(Producto(2, 3));
        Console.WriteLine(MontoTotalAPagar(300.00, 2));
    }

    public int Producto(int num1, int num2)
    {
        return num1 * num2;
    }

    public double MontoTotalAPagar(double precio, int cantidad)
    {
        return precio * cantidad;
    }
}