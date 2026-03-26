using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер матрицы N: ");
        int N = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        int[,] матрица = new int[N, N];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                матрица[i, j] = rnd.Next(-100, 101);
            }
        }
        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(матрица[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int макс = матрица[0, 0];
        int мин = матрица[0, 0];
        int индексМакс = 0, индексМин = 0;

        for (int i = 1; i < N; i++)
        {
            if (матрица[i, i] > макс)
            {
                макс = матрица[i, i];
                индексМакс = i;
            }
            if (матрица[i, i] < мин)
            {
                мин = матрица[i, i];
                индексМин = i;
            }
        }
        int temp = матрица[индексМакс, индексМакс];
        матрица[индексМакс, индексМакс] = матрица[индексМин, индексМин];
        матрица[индексМин, индексМин] = temp;
        Console.WriteLine("\nМатрица после обмена:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(матрица[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
