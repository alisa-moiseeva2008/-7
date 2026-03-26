class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[,] матрица = new int[5, 8];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                матрица[i, j] = rnd.Next(-50, 51);
            }
        }
        Console.WriteLine("Матрица 5x8:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(матрица[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nСтолбцы, содержащие хотя бы один отрицательный элемент:");
        for (int j = 0; j < 8; j++)
        {
            bool естьОтрицательный = false;
            for (int i = 0; i < 5; i++)
            {
                if (матрица[i, j] < 0)
                {
                    естьОтрицательный = true;
                    break;
                }
            }
            if (естьОтрицательный)
            {
                Console.Write((j + 1) + " ");
            }
        }
        Console.ReadKey();
    }
}
