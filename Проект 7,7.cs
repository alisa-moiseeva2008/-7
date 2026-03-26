using System;
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] матрица = new int[7, 4];
            
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    матрица[i, j] = rnd.Next(-30, 31);
                }
            }
            Console.WriteLine("Матрица 7x4:");
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(матрица[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nСтроки, содержащие хотя бы один нечетный отрицательный элемент:");
            for (int i = 0; i < 7; i++)
            {
                bool естьНечетныйОтрицательный = false;
                for (int j = 0; j < 4; j++)
                {
                    if (матрица[i, j] < 0 && матрица[i, j] % 2 != 0)
                    {
                        естьНечетныйОтрицательный = true;
                        break;
                    }
                }
                if (естьНечетныйОтрицательный)
                {
                    Console.Write((i + 1) + " ");
                }
            }
            Console.ReadKey();
        }
    }
}