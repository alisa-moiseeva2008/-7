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
                матрица[i, j] = rnd.Next(-100, 101);
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
        int минМодуль = Math.Abs(матрица[0, 0]);
        int строка = 0, столбец = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (Math.Abs(матрица[i, j]) < минМодуль)
                {
                    минМодуль = Math.Abs(матрица[i, j]);
                    строка = i;
                    столбец = j;
                }
            }
        }
        Console.WriteLine($"\nНаименьший по модулю элемент: {матрица[строка, столбец]}");
        Console.WriteLine($"Номер строки: {строка + 1}");
        Console.WriteLine($"Номер столбца: {столбец + 1}");
        Console.ReadKey();
    }
}
