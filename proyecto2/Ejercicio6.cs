using System;

class Ejercicio6
{
    public static void Init()
    {
        Console.WriteLine("Ejercicio6: Ingrese la cantidad de ecuaciones:");
        int cantidadEcuaciones = Convert.ToInt32(Console.ReadLine());
        int[] valoresLeidos = new int[cantidadEcuaciones];

        for (int i = 0; i < cantidadEcuaciones; i++)
        {
            Console.WriteLine("Ingrese los valores para la ecuación " + (i + 1) + ":");
            valoresLeidos[i] = Convert.ToInt32(Console.ReadLine());
        }

        int elMayor = 0;

        foreach (int v in valoresLeidos)
        {
            if (elMayor < v)
            {
                elMayor = v;
            }
        }

        Console.WriteLine("El número mayor es " + elMayor);
        Console.ReadLine();
    }
}

