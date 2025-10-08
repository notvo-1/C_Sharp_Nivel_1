public class Ej4
{
    public void Resolver()
    {
        Console.WriteLine("4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. Que analice el número y escriba variable recibida por referencia con:\na. 1 si el número es positivo.\nb. -1 si el número es negativo.\nc. 0 si el número es cero.");
        Console.WriteLine();
        int estado = 0;

        Console.Write("Ingrese un numero a evaluar: ");

        if (int.TryParse(Console.ReadLine(), out int num))
        {
            positivoNegativoCero(num, ref estado);
            Console.WriteLine($"El estado del numero {num} es {estado}");
        }
        else
        {
            Console.WriteLine("ERROR. Ingrese un numero valido.");
        }

    }

    public void positivoNegativoCero(int num, ref int x)
    {
        if (num == 0)
        {
            x = 0;
        }
        else if (num > 0)
        {
            x = 1;
        }
        else
        {
            x = -1;
        }
    }
}