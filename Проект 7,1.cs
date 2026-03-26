using System;
class Program
{
    static int[,] СоздатьМассив(int строки, int столбцы, int A, int B)
    {
        Random rnd = new Random();
        int[,] массив = new int[строки, столбцы];

        for (int i = 0; i < строки; i++)
        {
            for (int j = 0; j < столбцы; j++)
            {
                массив[i, j] = rnd.Next(A, B + 1);
            }
        }
        return массив;
    }
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int строки = int.Parse(Console.ReadLine());
        Console.Write("Введите количество столбцов: ");
        int столбцы = int.Parse(Console.ReadLine());
        Console.Write("Введите A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введите B: ");
        int B = int.Parse(Console.ReadLine());

        int[,] массив = СоздатьМассив(строки, столбцы, A, B);

        Console.WriteLine("Сгенерированный массив:");
        for (int i = 0; i < строки; i++)
        {
            for (int j = 0; j < столбцы; j++)
            {
                Console.Write(массив[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
