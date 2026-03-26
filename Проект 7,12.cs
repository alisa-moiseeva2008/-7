using System;
{
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
            for (int i = 0; i < N; i++)
            {
                int индексМин = 0;
                for (int j = 1; j < M; j++)
                {
                    if (матрица[i, j] < матрица[i, индексМин])
                    {
                        индексМин = j;
                    }
                }
                int temp = матрица[i, 0];
                матрица[i, 0] = матрица[i, индексМин];
                матрица[i, индексМин] = temp;
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
}