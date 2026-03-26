using System;
class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[,] матрица = new int[5, 10];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                матрица[i, j] = rnd.Next(-20, 31);
            }
        }
        Console.WriteLine("Матрица 5x10:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(матрица[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nСтроки, содержащие только положительные элементы:");
        for (int i = 0; i < 5; i++)
        {
            bool всеПоложительные = true;
            for (int j = 0; j < 10; j++)
            {
                if (матрица[i, j] <= 0)
                {
                    всеПоложительные = false;
                    break;
                }
            }
            if (всеПоложительные)
            {
                Console.Write((i + 1) + " ");
            }
        }
        Console.ReadKey();
    }
}
