using System;

class Ejercicio1
{
    public static void Init()
    {
        Console.WriteLine("Ejercicio1: Ingrese la cantidad de ecuaciones:");
        int cantidadEcuaciones = Convert.ToInt32(Console.ReadLine());
        string[] valoresLeidos = new string[cantidadEcuaciones];

        for (int i = 0; i < cantidadEcuaciones; i++)
        {
            Console.WriteLine("Ingrese los valores para la ecuación " + (i + 1) + ":");
            valoresLeidos[i] = Console.ReadLine();
        }

        int[] res = new int[cantidadEcuaciones];
        for (int i = 0; i < cantidadEcuaciones; i++)
        {
            string[] splitValue = valoresLeidos[i].Split(' ');
            int value1 = int.Parse(splitValue[0]);
            int value2 = int.Parse(splitValue[1]);
            res[i] = (value1 * 5) + (value2 * 9);
        }
        Console.WriteLine("res: " + string.Join(",", res));
        Console.ReadLine();
    }
}

