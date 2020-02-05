using System.Collections.Generic;
using System;

namespace Lab2_1
{
    public class ShekerSort
    {
        /// <summary>
        /// Функция Шейкер - сортировки
        /// </summary>
        /// <param name="mass"> Исходный массив </param>
        public static void Sort(List<double> mass)
        {
            int counter = 0;
            int left = 0, right = mass.Count - 1;    // левая и правая граница сортируемого массива
            int flag = 0;                       // Флаг наличия перемещения элементов массива
            do // Выполнение пока левая и правая границы не сомкнутся или пока есть флан перемещния элеменоов
            {
                counter++;
                flag = 0;
                for (int i = 0; i < right; i++)  // Движение слева направо и сортировка в том же направлении
                {
                    if (mass[i] > mass[i + 1])
                    {
                        double t = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = t;
                        flag = 1;
                    }
                }
                right--;                         // Сдвиг правой границы
                for (int i = right; i > left; i--)// Движение с права на лево, сортировка в том же направлении
                {
                    if (mass[i - 1] > mass[i])
                    {
                        double t = mass[i];
                        mass[i] = mass[i - 1];
                        mass[i - 1] = t;
                        flag = 1;
                    }
                }
                left++;                         // Сдвиг левой границы
                if (flag == 1)
                {
                    for (int x = 0; x < mass.Count; x++)
                    {
                        Console.Write(mass[x] + " ");
                    }
                    Console.WriteLine(" - {0} шаг сортировки", counter);
                }
            } while ((left < right) || flag != 0);
        }
    }
}

