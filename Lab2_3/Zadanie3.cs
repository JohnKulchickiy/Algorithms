using System;

namespace Lab2_3
{
    class Zadanie3
    {
        public static void SearchForMaxColumn(double[,] matrix)
        {
            int rows = matrix.GetLength(1), columns = matrix.GetLength(0); // Инициализируем новые переменные для строк и колонок для простоты работы и чтения дальнейшего кода 
            int global_max = 0, first_column = 0, element_index = 0, maximum_element_index = 0; // global_max - нужна для хранения максимального значения одинаковых элемнтов, first_column - для хранения индекса столбца с таким количеством элементов, element_index - для индекса максимального элемента в столбце, maximum_element_index - для значения максимального элемента 
            for (int column = 0; column < columns; column++) // Делаем проход по столбцам
            {
                int max = 0;
                for (int row = 0; row < rows; row++) // Делаем проход по элементам столбца
                {
                    int temp_max = 0;
                    for (int i = 0; i < rows; i++) // Проверяем на равенство каждый элемент столбца
                    {
                        if (matrix[column , row] == matrix[column , i]) // Если равно
                        {
                            temp_max++; // Увеличиваем каунтер
                        }
                    }
                    if (temp_max > max) // Проверка на кол-во одинаковых элементов 
                    {
                        max = temp_max;
                        element_index = row;
                    }  
                }
                if (max > global_max) // В переменную global_max заносим максимальное значение одинаковых элементов, в first_column - индекс этой колонки
                {
                    global_max = max;
                    first_column = column;
                    maximum_element_index = element_index;
                }
            }
            Console.WriteLine("Столбец имеющий максимальное кол-во одинаковых элементов - " + (first_column + 1) + "\nКол-во одинаковых элементов в этом столбце - " + global_max + "\nЭтот элемент равен: " + matrix[first_column, maximum_element_index]);
        }
    }
}
