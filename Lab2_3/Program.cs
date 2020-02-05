using System;

namespace Lab2_3
{
    class Program
    {
        static double[ , ] RandomMatrix()
        {
            Console.WriteLine("Введите столбцов для генерации: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите элементов в столбцах: ");
            int y = int.Parse(Console.ReadLine());
            double[,] Matrix = new double[x,y];
            Random rnd = new Random();
            Console.WriteLine("Сгенерированая случайно матрица : ");
            for (int yi = 0; yi < y; yi++)
            {
                for (int xi = 0; xi < x; xi++)
                {
                    Matrix[xi, yi] = rnd.Next(0, 10);
                }
            }
            for (int yi = 0; yi < y; yi++)
            {
                for (int xi = 0; xi < x; xi++)
                {
                    Console.Write("{0,5}", Matrix[xi, yi]);
                }
                Console.WriteLine();
            }
            return Matrix;
        }
        static void Main(string[] args)
        {
            // Задание 3
            double[ , ] Matrix = RandomMatrix();
            Lab2_3.Zadanie3.SearchForMaxColumn(Matrix);
            Console.ReadKey();
        }
    }
}
