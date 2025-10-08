namespace U7_Ejercicios;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE EJERCICIOS ===");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            // Console.WriteLine("5. Ejercicio 5");
            // Console.WriteLine("5. Ejercicio 6");
            // Console.WriteLine("5. Ejercicio 7");
            // Console.WriteLine("5. Ejercicio 8");
            Console.WriteLine("9. Salir");
            Console.Write("Elige una opción: ");

            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    Ej1 ej1 = new Ej1();
                    ej1.Resolver();
                    break;
                case "2":
                    Ej2 ej2 = new Ej2();
                    ej2.Resolver();
                    break;
                case "3":
                    Ej3 ej3 = new Ej3();
                    ej3.Resolver();
                    break;
                case "4":
                    Ej4 ej4 = new Ej4();
                    ej4.Resolver();
                    break;
                // case "5":
                //     Ej5 ej5 = new Ej5();
                //     ej5.Resolver();
                //     break;
                // case "6":
                //     Ej6 ej6 = new Ej6();
                //     ej6.Resolver();
                //     break;
                // case "7":
                //     Ej7 ej7 = new Ej7();
                //     ej7.Resolver();
                //     break;
                // case "8":
                //     Ej8 ej8 = new Ej8();
                //     ej8.Resolver();
                //     break;
                case "9":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("Presiona ENTER para continuar...");
                Console.ReadLine();
            }
        }
    }
}

