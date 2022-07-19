// Задайте двумерный массив.
// Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

// Console.Write("Введите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()); // null - ссылка в пустоту
// Console.Write("Введите количество столбцов массива: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// /// summary - описание метода
// /// m на n: m - кол-во строк, n - кол-во столбцов
// /// minValue , maxValue
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < m; i++) // Строчки. m = matrix.GetLength(0)
//     {
//         for (int j = 0; j < n; j++) // n = matrix.GetLength(1)
//         {
//             matrix[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }
// /// Печатает массив на экран
// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i, j] + "\t");
//             // 1 2 3 4
//         }
//         Console.WriteLine();
//     }
// }
// int[,] array = GetArray(rows, columns, 0, 10);
// PrintArray(array);

// void ChangeRows(int[,] matrix)
// {
//     int indexLastRow = matrix.GetLength(0) - 1; // индекс полследней строки, чтобы поменять с индексами 1-й строки
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[indexLastRow, i];
//         matrix[indexLastRow, i] = temp;
//     }
// }
// ChangeRows(array);
// Console.WriteLine("Результат: ");
// PrintArray(array);

// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/// метод создает массив рандомных чисел
// void Inizialisazion(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 11);
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

/// метод печатает массив меня строки и столбцы местами
// void ReadMass(int[,] Array)
// {
//     for(int i = 0; i < Array.GetLength(0); i++)
//     {
//         for(int  j= 0; j < Array.GetLength(1); j++)
//         {
//             Console.Write(Array[j, i] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] matrix = new int[5, 5];

// Inizialisazion(matrix);
// System.Console.WriteLine();
// ReadMass(matrix);

// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

// int minValue = int.MaxValue; // пусть минимальное значение массива будет равно максимально допустимому значению типа Int (2147483647)
// int indexRows = 0;
// int indexColumns = 0;
// int[,] matrix = new int[4, 4];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(11);
//         Console.Write(matrix[i, j] + "\t");
//         if (minValue > matrix[i, j]) // нахожу минимальное значение элемента матрицы и его индексы, проверяя все элементы матрицы
//         {
//             minValue = matrix[i, j]; 
//             indexRows = i;
//             indexColumns = j;
//         }
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Result");
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     if (i != indexRows) // исключаю из вывода всю строку с индексом наименьшего элемента матрицы
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j != indexColumns) // исключаю из вывода весь столбец с индексом наименьшего элемента матрицы
//             {
//                 Console.Write(matrix[i, j] + "\t"); // вывожу строки и столбцы матрицы, исключая те, где находится минимальный элемент матрицы
//             }
//         }
//     }
//     Console.WriteLine();
// }