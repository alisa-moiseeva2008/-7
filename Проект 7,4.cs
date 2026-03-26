class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[,] матрица = new int[6, 11];

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                матрица[i, j] = rnd.Next(-100, 101);
            }
        }
        Console.WriteLine("Матрица 6x11:");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 11; j++)
            {
                Console.Write(матрица[i, j] + "\t");
            }
            Console.WriteLine();
        }
        int сумма = 0;
        Console.WriteLine("\nМаксимальные элементы в каждом столбце:");
        for (int j = 0; j < 11; j++)
        {
            int макс = матрица[0, j];
            for (int i = 1; i < 6; i++)
            {
                if (матрица[i, j] > макс)
                {
                    макс = матрица[i, j];
                }
            }
            сумма += макс;
            Console.WriteLine($"Столбец {j + 1}: {макс}");
        }
        Console.WriteLine($"\nСумма максимальных элементов: {сумма}");
        Console.ReadKey();
    }
}
