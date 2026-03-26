using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк N: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов M: ");
        int M = int.Parse(Console.ReadLine());
        Random rnd = new Random();
        int[,] матрица = new int[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                матрица[i, j] = rnd.Next(1, 101);
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(матрица[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int[] суммы = new int[N];
        for (int i = 0; i < N; i++)
        {
            int сумма = 0;
            for (int j = 0; j < M; j++)
            {
                сумма += матрица[i, j];
            }
            суммы[i] = сумма;
        }
        int индексМакс = 0;
        for (int i = 1; i < N; i++)
        {
            if (суммы[i] > суммы[индексМакс])
            {
                индексМакс = i;
            }
        }

        int[] строкаМакс = new int[M];
        for (int j = 0; j < M; j++)
        {
            строкаМакс[j] = матрица[индексМакс, j];
        }

        Console.WriteLine($"\nСтрока с максимальной суммой (строка {индексМакс + 1}):");
        for (int j = 0; j < M; j++)
        {
            Console.Write(строкаМакс[j] + " ");
        }
        Console.WriteLine($"\nСумма: {суммы[индексМакс]}");
        Console.ReadKey();
    }
}
