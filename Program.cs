using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Cuántos números vas a ingresar? ");
        int n = int.Parse(Console.ReadLine());

        int pares = 0, impares = 0, mayores10 = 0, positivos = 0, negativos = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingresa el número {i}: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                pares++;
            else
                impares++;

            if (num > 10)
                mayores10++;

            if (num > 0)
                positivos++;
            else if (num < 0)
                negativos++;
        }

        Console.WriteLine("\n--- RESULTADOS ---");
        Console.WriteLine($"Cantidad de números pares: {pares}");
        Console.WriteLine($"Cantidad de números impares: {impares}");
        Console.WriteLine($"Cantidad mayores a 10: {mayores10}");
        Console.WriteLine($"Cantidad de positivos: {positivos}");
        Console.WriteLine($"Cantidad de negativos: {negativos}");
    }
}
