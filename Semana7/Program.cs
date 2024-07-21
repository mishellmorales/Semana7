using Semana7;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            menu();
            string? opcion = Console.ReadLine();

            switch (opcion)
            {
                case "0":
                    return;
                case "1":
                    encabezado("Teoría de pilas");
                    Pila.Run();
                    pie();
                    break;
                case "2":
                    encabezado("Pilas - Torre de Hanoi");
                    Hanoi.Run();
                    pie();
                    break;
                case "3":
                    encabezado("Pilas - Balanceo de ecuaciones básicas");
                    Balanceo.Run();
                    pie();
                    break;
                default:
                    System.Console.WriteLine("Opción no válida, presione una tecla para continuar");
                    break;
            }
        }


        /**
        * Muestra el menú
*/
        static void menu()
        {
            caratula();
            System.Console.WriteLine("1     Teoría de pilas");
            System.Console.WriteLine("2     Pilas - Torre de Hanoi");
            System.Console.WriteLine("3     Pilas - Balanceo de ecuaciones básica");
            System.Console.WriteLine(new string('-', 55));
            System.Console.WriteLine("0 Salir");
            System.Console.WriteLine();
        }

        /**
        *   Muestra la caratula general del ejercicio.
*/
        static void caratula()
        {
            // Console.Clear();
            Console.WriteLine("\f\u001b\x1b[3J");
            System.Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            System.Console.WriteLine("+             UNIVERSIDAD ESTATAL AMAZÓNICA           +");
            System.Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            System.Console.WriteLine();
            System.Console.WriteLine("           Menú de opciones - Escriba un número");
            System.Console.WriteLine();

        }

        static void encabezado(string opcion)
        {
            System.Console.WriteLine("======================================");
            System.Console.WriteLine(opcion);
            System.Console.WriteLine("======================================");
        }

        static void pie()
        {
            System.Console.WriteLine(new string('=', 20));
            System.Console.WriteLine("                          Pulse la tecla enter para continuar ...");
            Console.ReadLine();
            Console.Read();
        }
    }
}