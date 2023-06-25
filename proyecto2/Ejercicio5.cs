using System;

class Ejercicio5
{

    public static void Init()
    {
        Console.WriteLine("Ejercicio5: Ingrese la primera entrada:");
        int primerEntrada = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese la segunda entrada:");
        string segundaEntrada = Console.ReadLine();
        string[] splitArray = segundaEntrada.Split(' ');

        int[] res = splitArray.Select(sa =>
        {
            int saInt = int.Parse(sa);
            if (saInt < primerEntrada)
            {
                return saInt;
            }
            else
            {
                return -1; // Usamos -1 para indicar valores inválidos que serán filtrados después
            }
        }).Where(r => r != -1).ToArray();

        Console.WriteLine(string.Join(',', res));

        Console.ReadLine();
    }
}

