using System;
{
    class Program
    {
        static void ВывестиМассив(int[] массив)
        {
            foreach (int элемент in массив)
            {
                Console.Write(элемент + " ");
            }
            Console.WriteLine();
        }     
        static void ВывестиМассив(int[,] массив)
        {
            for (int i = 0; i < массив.GetLength(0); i++)
            {
                for (int j = 0; j < массив.GetLength(1); j++)
                {
                    Console.Write(массив[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[] одномерный = { 1, 2, 3, 4, 5 };
            int[,] двумерный = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 
            Console.WriteLine("Одномерный массив:");
            ВывестиМассив(одномерный);
            Console.WriteLine("Двумерный массив:");
            ВывестиМассив(двумерный);
            Console.ReadKey();
        }
    }
}