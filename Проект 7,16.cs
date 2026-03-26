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
        Console.Write("\nВведите заданную величину: ");
        double заданнаяВеличина = double.Parse(Console.ReadLine());
        int количество = 0;
        for (int i = 0; i < N; i++)
        {
            int сумма = 0;
            for (int j = 0; j < M; j++)
            {
                сумма += матрица[i, j];
            }
            double среднее = (double)сумма / M;
            if (среднее < заданнаяВеличина)
            {
                количество++;
            }
        }
        Console.WriteLine($"\nКоличество строк со средним арифметическим меньше {заданнаяВеличина}: {количество}");
        Console.ReadKey();
    }
}
