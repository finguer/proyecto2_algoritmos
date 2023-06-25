using System;

class Ejercicio4
{

    public static void Init()
    {
        Console.WriteLine("Ejercicio4: Ingrese la cantidad de ecuaciones:");
        int cantidadEcuaciones = Convert.ToInt32(Console.ReadLine());
        string[] valoresLeidos = new string[cantidadEcuaciones];

        for (int i = 0; i < cantidadEcuaciones; i++)
        {
            Console.WriteLine("Ingrese los valores para la ecuación " + (i + 1) + ":");
            valoresLeidos[i] = Console.ReadLine();
        }

        int valMultiplicar = cantidadEcuaciones * 5;
        int[] res = new int[cantidadEcuaciones];

        for (int i = 0; i < cantidadEcuaciones; i++)
        {
            res[i] = int.Parse(valoresLeidos[i]) * valMultiplicar;
        }

        Console.WriteLine("\n Salida: \n");
        Console.WriteLine(string.Join('\n', res));

        Console.ReadLine();
    }
}

