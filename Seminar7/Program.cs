// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int rows = Int32.Parse(Console.ReadLine());
// int columns = Int32.Parse(Console.ReadLine());

// int [,] matrix = new int[rows,columns]; 

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = new Random().Next(0,11); //NextDouble() -> от 0 до 1
//         Console.Write(matrix[i,j] + "\t"); // t - Tab
//         // n - new 
//     }
//     Console.WriteLine();
// }

// Задачи для работы в классе:
// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int [,] matrix = new int[3,5]; 
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i,j] = i + j;
//         Console.Write(matrix[i,j] + "\t");
//     }
//     Console.WriteLine();
// }

// *Задача 49: *Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// int[,] matrix = new int[3, 5];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine("Result");
// for (int k = 0; k < matrix.GetLength(0); k++)
// {
//     for (int l = 0; l <matrix.GetLength(1); l++)
//     {
//         if(k % 2 == 0 && l % 2 ==0)
//         {
//             matrix[k, l] = matrix[k, l] * matrix[k, l];
//         }
//         Console.Write(matrix[k, l] + "\t");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int rows = Int32.Parse(Console.ReadLine());
// int columns = Int32.Parse(Console.ReadLine());

// int[,] matrix = new int[rows, columns];
// int sum = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix[i, j] = new Random().Next(0, 11);
//         if (i == j)
//         {
//             sum = sum + matrix[i, j];
//         }
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }
// System.Console.WriteLine(sum);