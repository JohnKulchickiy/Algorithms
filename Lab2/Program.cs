using System;
using System.Collections.Generic;

namespace Lab2_1
{
    class Program
    {
        static List<double> RandomMas() //Генератор массива случайных чисел 
        {
            List<double> mass = new List<double>();
            Random rnd = new Random();

            Console.WriteLine("Введите количество элементов для генерации: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Сгенерированый случайно массив : ");
            for (int i = 0; i <= n; i++)
            {
                mass.Add(rnd.Next(-1000, 1000));
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine("\n");

            return mass;
        }
        static void Main(string[] args)
        {
            // Задание 1
            List<double> Mas = RandomMas();

            ShekerSort.Sort(Mas);

            Console.WriteLine("\nОтсортированый случайный массив имеет следующий вид: ");
            for (int i = 0; i < Mas.Count; i++)
            {
                Console.Write(Mas[i] + " ");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
