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
                матрица[i, j] = rnd.Next(-5, 6);
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
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (матрица[i, j] == 0)
                {
                    int temp = матрица[i, j];
                    матрица[i, j] = матрица[N - 1, j];
                    матрица[N - 1, j] = temp;
                }
            }
        }
        Console.WriteLine("\nМатрица после замены:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                Console.Write(матрица[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
