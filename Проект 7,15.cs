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
        Console.Write("\nВведите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++)
        {
            int новыйИндекс = 0;
            for (int j = 0; j < M; j++)
            {
                if (матрица[i, j] < a || матрица[i, j] > b)
                {
                    матрица[i, новыйИндекс] = матрица[i, j];
                    новыйИндекс++;
                }
            }
            for (int j = новыйИндекс; j < M; j++)
            {
                матрица[i, j] = 0;
            }
        }
        Console.WriteLine("\nМатрица после сжатия:");
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
