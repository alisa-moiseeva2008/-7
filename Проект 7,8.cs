using System;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[,] матрица = new int[4, 6];

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                матрица[i, j] = rnd.Next(1, 101);
            }
        }
        Console.WriteLine("Матрица 4x6:");
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(матрица[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int[] суммыСтрок = new int[4];
        for (int i = 0; i < 4; i++)
        {
            int сумма = 0;
            for (int j = 0; j < 6; j++)
            {
                сумма += матрица[i, j];
            }
            суммыСтрок[i] = сумма;
        }
        Console.WriteLine("\nСуммы элементов строк:");
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Строка {i + 1}: {суммыСтрок[i]}");
        }
        int максимум = суммыСтрок[0];
        for (int i = 1; i < 4; i++)
        {
            if (суммыСтрок[i] > максимум)
            {
                максимум = суммыСтрок[i];
            }
        }
        Console.WriteLine($"\nМаксимальная сумма строки: {максимум}");
        Console.ReadKey();
    }
}
