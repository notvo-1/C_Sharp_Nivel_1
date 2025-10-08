namespace Punto_2;

class Program
{
    static void Main(string[] args)
    {
        int num, numGrupoGanador = 0;
        float mayorPorcentaje = float.MinValue;
        int gruposOrdenados = 0;


        for (int i = 1; i <= 5; i++)
        {
            int salida = 0;
            int cantidadImparesOnLoop = 0;
            string numerosIngresadosOnLoop = "";
            int contadorNumOnLoop = 0;
            int numAnterior = int.MaxValue;
            bool ordenado = true;
            System.Console.WriteLine($"Ingrese los numeros de la lista {i}.");
            System.Console.WriteLine("Ingrese 0 (cero) para cerrar la lista.");

            while (salida == 0)
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num == 0)
                    {
                        salida = 1;
                    }
                    else
                    {
                        if (num % 2 != 0)
                        {
                            cantidadImparesOnLoop++;
                        }
                        contadorNumOnLoop++;
                        numerosIngresadosOnLoop += num + " ";
                    }

                    if (ordenado)
                    {
                        if (num <= numAnterior)
                        {
                            numAnterior = num;
                        }
                        else
                        {
                            ordenado = false;
                        }
                    }
                }
            }

            float porcentajeImparterXGrupo = (float)cantidadImparesOnLoop / contadorNumOnLoop;
            System.Console.WriteLine("Números ingresados: " + numerosIngresadosOnLoop);
            System.Console.WriteLine($"El grupo {i} tiene un porcentaje de impares de {porcentajeImparterXGrupo * 100:F2}%.");


            if (contadorNumOnLoop > 0)
            {
                if (porcentajeImparterXGrupo > mayorPorcentaje)
                {
                    mayorPorcentaje = porcentajeImparterXGrupo;
                    numGrupoGanador = i;
                }
            }

            if (ordenado)
            {
                gruposOrdenados++;
                System.Console.WriteLine($"El grupo {i} esta ordenado.");
            }



        }
        System.Console.WriteLine($"El grupo con mayor numero de impares es el grupo numero {numGrupoGanador} con el {mayorPorcentaje * 100:F2}% de numeros impares.");
        System.Console.WriteLine($"Hay {gruposOrdenados} grupos ordenados.");
    }
}