using System;

class Ejercicio3
{

    static int ContarConsonantesRepetitivas(string palabra)
    {
        int contador = 0;
        int maxConsonantes = 0;

        for (int i = 0; i < palabra.Length - 1; i++)
        {
            if (EsConsonante(palabra[i]) && EsConsonante(palabra[i + 1]))
            {
                contador++;
            }
            else
            {
                maxConsonantes = Math.Max(maxConsonantes, contador);
                contador = 0;
            }
        }

        maxConsonantes = Math.Max(maxConsonantes, contador);
        return maxConsonantes;
    }

    static bool EsConsonante(char letra)
    {
        string consonantes = "bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ";
        return consonantes.Contains(letra);
    }

    public static void Init()
    {
        Console.WriteLine("Ejercicio3: Ingrese la cantidad de ecuaciones:");
        int cantidadEcuaciones = Convert.ToInt32(Console.ReadLine());
        string[] valoresLeidos = new string[cantidadEcuaciones];

        for (int i = 0; i < cantidadEcuaciones; i++)
        {
            Console.WriteLine("Ingrese la palabra a procesar" + (i + 1) + ":");
            valoresLeidos[i] = Console.ReadLine();
        }

        string[] res = valoresLeidos.Select(palabra =>
        {
            int cantidadConsonantes = ContarConsonantesRepetitivas(palabra);
            string resultado = cantidadConsonantes >= 4 ? "NO" : "SI";
            return resultado;
        }).ToArray();

        Console.WriteLine(string.Join('\n', res));

        Console.ReadLine();
    }
}
