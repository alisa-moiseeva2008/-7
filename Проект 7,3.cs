using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] матрица = new int[15, 9];
            
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    матрица[i, j] = rnd.Next(-100, 101);
                }
            }
            Console.WriteLine("Матрица 15x9:");
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(матрица[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nМинимальные элементы в каждой строке:");
            for (int i = 0; i < 15; i++)
            {
                int мин = матрица[i, 0];
                for (int j = 1; j < 9; j++)
                {
                    if (матрица[i, j] < мин)
                    {
                        мин = матрица[i, j];
                    }
                }
                Console.WriteLine($"Строка {i + 1}: {мин}");
            }
            Console.ReadKey();
        }
    }
}