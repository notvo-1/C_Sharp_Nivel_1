namespace U3_ejercicio3;

class Program
{
    static void Main(string[] args)
    {
        double valorCompra;
        double precioFinal;

        System.Console.WriteLine("Ingrese el valor de la compra para calcular el descuento: ");

        if (!double.TryParse(Console.ReadLine(), out valorCompra))
        {
            System.Console.WriteLine("Ingrese un numero valido.");
        }
        else if (valorCompra < 0)
        {
            System.Console.WriteLine("Ingrese un numero positivo");
        }
        else
        {
            if (valorCompra > 5000)
            {
                precioFinal = valorCompra - valorCompra * 0.18;
                System.Console.WriteLine($"El precio final es {precioFinal}");
            }
            else if (valorCompra > 1000)
            {
                precioFinal = valorCompra - valorCompra * 0.1;
                System.Console.WriteLine($"El precio final es {precioFinal}");
            }else
            {
                System.Console.WriteLine($"El precio final es {valorCompra}");
            }
        }
    }
}
