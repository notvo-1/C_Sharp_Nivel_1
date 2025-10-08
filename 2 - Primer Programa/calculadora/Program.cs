namespace calculadora;

class Program
{
    static void Main(string[] args)
    {
        int n1, n2;
        bool valido1 = false, valido2 = false;

        //pedir valores
        System.Console.WriteLine("Ingrese el primer numero entero: ");
        if (int.TryParse(Console.ReadLine(), out n1))
        {
            Console.WriteLine($"Numero ingresado {n1}.");
            valido1 = true;
        }
        else
        {
            Console.WriteLine("Entrada no valida.");
        }   


        System.Console.WriteLine("Ingrese el segundo numero entero: ");

        if (int.TryParse(Console.ReadLine(), out n2))
        {
            Console.WriteLine($"El numero ingresado es {n2}");
            valido2 = true;
        }
        else
        {
            Console.WriteLine("Entrada no valida.");
        }

        //suma 

        if (valido1 && valido2)
        {
            int suma = n1 + n2;
            Console.WriteLine(suma);

        }
        else
        {
            System.Console.WriteLine("Uno de los valores es incorrecto, intente nuevamente.");
        }

    }
}
