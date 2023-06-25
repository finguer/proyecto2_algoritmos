using System;

class Ejercicio2
{

    public static void Init()
    {
        Console.WriteLine("Ejercicio2: Ingrese la cantidad de ecuaciones:");
        int cantidadEcuaciones = Convert.ToInt32(Console.ReadLine());
        string[] valoresLeidos = new string[cantidadEcuaciones];

        for (int i = 0; i < cantidadEcuaciones; i++)
        {
            Console.WriteLine("Ingrese los valores para la ecuación " + (i + 1) + ":");
            valoresLeidos[i] = Console.ReadLine();
        }


        string[] res = new string[cantidadEcuaciones];
        for (int i = 0; i < cantidadEcuaciones; i++)
        {
            string[] splitValue = valoresLeidos[i].Split(' ');
            int value1 = int.Parse(splitValue[0]);
            int value2 = int.Parse(splitValue[1]);
            int value3 = int.Parse(splitValue[2]);
            int sum = value2 + (value3 * 2);
            string result = (value1 >= sum) ? "SI" : "NO";
            res[i] = result;
        }

        Console.WriteLine(string.Join('\n', res));
        Console.ReadLine();
    }
}

