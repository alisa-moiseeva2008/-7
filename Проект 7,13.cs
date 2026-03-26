using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] матрица = new int[8, 5];
            
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    матрица[i, j] = rnd.Next(20, 41);
                }
            }
            Console.WriteLine("Матрица 8x5:");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(матрица[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nСтроки, содержащие не более 3-х четных чисел:");
            for (int i = 0; i < 8; i++)
            {
                int четные = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (матрица[i, j] % 2 == 0)
                    {
                        четные++;
                    }
                }
                if (четные <= 3)
                {
                    Console.WriteLine($"Строка {i + 1}: {четные} четных чисел");
                }
            }
            Console.ReadKey();
        }
    }
}