using System;

class Program
{
    static void Main(string[] args)
    {
       

        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("== Menú de Ejercicios - Favio Figueroa P. ==");
            Console.WriteLine("1. Ejercicio 1");
            Console.WriteLine("2. Ejercicio 2");
            Console.WriteLine("3. Ejercicio 3");
            Console.WriteLine("4. Ejercicio 4");
            Console.WriteLine("5. Ejercicio 5");
            Console.WriteLine("6. Ejercicio 6");
            Console.WriteLine("0. Salir");
            Console.WriteLine("=======================");
            Console.Write("Ingrese el número del ejercicio a ejecutar: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Ejercicio1.Init();
                    break;
                case "2":
                    Ejercicio2.Init();
                    break;
                case "3":
                    Ejercicio3.Init();
                    break;
                case "4":
                    Ejercicio4.Init();
                    break;
                case "5":
                    Ejercicio5.Init();
                    break;
                case "6":
                    Ejercicio6.Init();
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número válido.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
            }
        }


    }
}


